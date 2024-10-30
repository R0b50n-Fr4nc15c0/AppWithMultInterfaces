using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComMultiplasJanelas
{
    public partial class FormNovaVenda : Form
    {
        private BindingList<Cliente> Clientes { get; set; }
        private Cliente Cliente { get { return Clientes.FirstOrDefault(f => f.Id == (int)comboBoxCliente.SelectedValue); } }
        public int IdCliente { get { return (int)comboBoxCliente.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBoxProduto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal Desconto { get { return numericUpDownDesconto.Value; } }

        private decimal PreçoUnitario { get { return Produto.PreçoVenda; } }
        private decimal ValorTotal { get { return PreçoUnitario * Quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }

        public FormNovaVenda(BindingList<Cliente> clientes, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Clientes = clientes;
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.DisplayMember = "NomeEmpresa";
            comboBoxCliente.DataSource = Clientes;
            comboBoxCliente.SelectedIndex = 0;

            Produtos = produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "NomeEmpresa";
            comboBoxProduto.DataSource = Produtos;
            comboBoxProduto.SelectedIndex = 0;

        }

        private void buttonVendaOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonVendaCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPreçoUnitario.Text = PreçoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorComDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
    }
}
