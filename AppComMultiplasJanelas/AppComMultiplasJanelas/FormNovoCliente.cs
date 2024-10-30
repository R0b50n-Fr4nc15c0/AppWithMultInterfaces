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
    public partial class FormNovoCliente : Form
    {
        public string Nome { get { return textBoxCliente.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }

        public string Endereço
        {
            get
            {
                string endereço = "";
                endereço += $"({textBoxEndereçoComple.Text}), ";
                endereço += $"{textBoxEnderecoNumero.Text}), ";
                endereço += $"{textBoxEnderecoLagradouro.Text}), ";
                endereço += $"{textBoxClienteEndeCidade.Text} - {textBoxClienteEndeUF.Text}), ";
                endereço += $"CEP:{textBoxClienteEndeCEP.Text}";
                return endereço;
            }
        }
        public FormNovoCliente()
        {
            InitializeComponent();
        }

        private void buttonClienteEndeOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonClienteEndeCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
