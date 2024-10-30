using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComMultiplasJanelas
{
    public partial class FormNovaCompra : Form
    {
        private BindingList<Fornecedor> Fornecedores { get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxCompraFornecedor.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBoxCompraFornecedor.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxCompraProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxCompraProduto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownCompraQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownCompraDesconto.Value; } }

        private decimal PreçoUnitario { get { return Produto.PreçoCompra; } }
        private decimal ValorTotal { get { return PreçoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }

        public FormNovaCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxCompraFornecedor.ValueMember = "Id";
            comboBoxCompraFornecedor.DisplayMember = "NomeEmpresa";
            comboBoxCompraFornecedor.DataSource = Fornecedores;
            comboBoxCompraFornecedor.SelectedIndex = 0;

            Produtos = produtos;
            comboBoxCompraProduto.ValueMember = "Id";
            comboBoxCompraProduto.DisplayMember = "Nome";
            comboBoxCompraProduto.DataSource = Produtos;
            comboBoxCompraFornecedor.SelectedIndex = 0;
        }

        private void comboBoxCompraProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownCompraQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownCompraDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxCompraPreçoUnitario.Text = PreçoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxCompraValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxCompraValorComDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void buttonCompraOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCompraCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}       
        
