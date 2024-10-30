using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComMultiplasJanelas
{
    public partial class FormNovoFornecedor : Form
    {
        public string NomeEmpresa { get { return textBoxNomeEmpresa.Text; } }
        public string NomeContato { get { return textBoxNomeContato.Text; } }
        public string CNPJ { get { return textBoxCNPJ.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }

        public string Endereço
        {
            get
            {
                string endereço = "";
                endereço += $"{textBoxEndereçoRua.Text}, ";
                endereço += $"{textBoxEndereçoNúmero.Text}, ";
                endereço += $"({textBoxEndereçoComplemento.Text}), ";
                endereço += $"{textBoxEndereçoCidade.Text} - {textBoxEndereçoUF.Text}, ";
                endereço += $"CEP: {textBoxEndereçoCEP.Text}";
                return endereço;
            }
        }
        public FormNovoFornecedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEndereçoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonEmdereçoOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
