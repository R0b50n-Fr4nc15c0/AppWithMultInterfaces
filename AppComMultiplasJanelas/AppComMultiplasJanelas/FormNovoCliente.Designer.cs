namespace AppComMultiplasJanelas
{
    partial class FormNovoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelClienteNome = new Label();
            labelClienteTelefone = new Label();
            labelClienteEmail = new Label();
            textBoxCliente = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEmail = new TextBox();
            groupBoxClienteEndereço = new GroupBox();
            buttonClienteEndeCancelar = new Button();
            buttonClienteEndeOK = new Button();
            textBoxClienteEndeCEP = new TextBox();
            textBoxClienteEndeUF = new TextBox();
            textBoxClienteEndeCidade = new TextBox();
            textBoxEndereçoComple = new TextBox();
            textBoxEnderecoNumero = new TextBox();
            textBoxEnderecoLagradouro = new TextBox();
            labelClienteEndeCEP = new Label();
            labelClienteEndeUF = new Label();
            labelClienteEndeCidade = new Label();
            labelClienteEndeComple = new Label();
            labelClienteEndereçoNúmero = new Label();
            labelClienteEndeRua = new Label();
            groupBoxClienteEndereço.SuspendLayout();
            SuspendLayout();
            // 
            // labelClienteNome
            // 
            labelClienteNome.AutoSize = true;
            labelClienteNome.Location = new Point(12, 9);
            labelClienteNome.Name = "labelClienteNome";
            labelClienteNome.Size = new Size(43, 15);
            labelClienteNome.TabIndex = 0;
            labelClienteNome.Text = "Nome:";
            // 
            // labelClienteTelefone
            // 
            labelClienteTelefone.AutoSize = true;
            labelClienteTelefone.Location = new Point(12, 34);
            labelClienteTelefone.Name = "labelClienteTelefone";
            labelClienteTelefone.Size = new Size(54, 15);
            labelClienteTelefone.TabIndex = 1;
            labelClienteTelefone.Text = "Telefone:";
            // 
            // labelClienteEmail
            // 
            labelClienteEmail.AutoSize = true;
            labelClienteEmail.Location = new Point(12, 58);
            labelClienteEmail.Name = "labelClienteEmail";
            labelClienteEmail.Size = new Size(44, 15);
            labelClienteEmail.TabIndex = 2;
            labelClienteEmail.Text = "E-mail:";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(124, 6);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(230, 23);
            textBoxCliente.TabIndex = 3;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(124, 31);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(230, 23);
            textBoxTelefone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(124, 55);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(230, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // groupBoxClienteEndereço
            // 
            groupBoxClienteEndereço.Controls.Add(buttonClienteEndeCancelar);
            groupBoxClienteEndereço.Controls.Add(buttonClienteEndeOK);
            groupBoxClienteEndereço.Controls.Add(textBoxClienteEndeCEP);
            groupBoxClienteEndereço.Controls.Add(textBoxClienteEndeUF);
            groupBoxClienteEndereço.Controls.Add(textBoxClienteEndeCidade);
            groupBoxClienteEndereço.Controls.Add(textBoxEndereçoComple);
            groupBoxClienteEndereço.Controls.Add(textBoxEnderecoNumero);
            groupBoxClienteEndereço.Controls.Add(textBoxEnderecoLagradouro);
            groupBoxClienteEndereço.Controls.Add(labelClienteEndeCEP);
            groupBoxClienteEndereço.Controls.Add(labelClienteEndeUF);
            groupBoxClienteEndereço.Controls.Add(labelClienteEndeCidade);
            groupBoxClienteEndereço.Controls.Add(labelClienteEndeComple);
            groupBoxClienteEndereço.Controls.Add(labelClienteEndereçoNúmero);
            groupBoxClienteEndereço.Controls.Add(labelClienteEndeRua);
            groupBoxClienteEndereço.Location = new Point(12, 84);
            groupBoxClienteEndereço.Name = "groupBoxClienteEndereço";
            groupBoxClienteEndereço.Size = new Size(342, 208);
            groupBoxClienteEndereço.TabIndex = 6;
            groupBoxClienteEndereço.TabStop = false;
            groupBoxClienteEndereço.Text = "Endereço";
            // 
            // buttonClienteEndeCancelar
            // 
            buttonClienteEndeCancelar.Location = new Point(171, 175);
            buttonClienteEndeCancelar.Name = "buttonClienteEndeCancelar";
            buttonClienteEndeCancelar.Size = new Size(159, 27);
            buttonClienteEndeCancelar.TabIndex = 13;
            buttonClienteEndeCancelar.Text = "Cancelar";
            buttonClienteEndeCancelar.UseVisualStyleBackColor = true;
            buttonClienteEndeCancelar.Click += buttonClienteEndeCancelar_Click;
            // 
            // buttonClienteEndeOK
            // 
            buttonClienteEndeOK.Location = new Point(6, 175);
            buttonClienteEndeOK.Name = "buttonClienteEndeOK";
            buttonClienteEndeOK.Size = new Size(159, 27);
            buttonClienteEndeOK.TabIndex = 12;
            buttonClienteEndeOK.Text = "OK";
            buttonClienteEndeOK.UseVisualStyleBackColor = true;
            buttonClienteEndeOK.Click += buttonClienteEndeOK_Click;
            // 
            // textBoxClienteEndeCEP
            // 
            textBoxClienteEndeCEP.Location = new Point(129, 146);
            textBoxClienteEndeCEP.Name = "textBoxClienteEndeCEP";
            textBoxClienteEndeCEP.Size = new Size(201, 23);
            textBoxClienteEndeCEP.TabIndex = 11;
            // 
            // textBoxClienteEndeUF
            // 
            textBoxClienteEndeUF.Location = new Point(129, 122);
            textBoxClienteEndeUF.Name = "textBoxClienteEndeUF";
            textBoxClienteEndeUF.Size = new Size(201, 23);
            textBoxClienteEndeUF.TabIndex = 10;
            // 
            // textBoxClienteEndeCidade
            // 
            textBoxClienteEndeCidade.Location = new Point(129, 97);
            textBoxClienteEndeCidade.Name = "textBoxClienteEndeCidade";
            textBoxClienteEndeCidade.Size = new Size(201, 23);
            textBoxClienteEndeCidade.TabIndex = 9;
            // 
            // textBoxEndereçoComple
            // 
            textBoxEndereçoComple.Location = new Point(129, 73);
            textBoxEndereçoComple.Name = "textBoxEndereçoComple";
            textBoxEndereçoComple.Size = new Size(201, 23);
            textBoxEndereçoComple.TabIndex = 8;
            // 
            // textBoxEnderecoNumero
            // 
            textBoxEnderecoNumero.Location = new Point(129, 49);
            textBoxEnderecoNumero.Name = "textBoxEnderecoNumero";
            textBoxEnderecoNumero.Size = new Size(201, 23);
            textBoxEnderecoNumero.TabIndex = 7;
            // 
            // textBoxEnderecoLagradouro
            // 
            textBoxEnderecoLagradouro.Location = new Point(129, 25);
            textBoxEnderecoLagradouro.Name = "textBoxEnderecoLagradouro";
            textBoxEnderecoLagradouro.Size = new Size(201, 23);
            textBoxEnderecoLagradouro.TabIndex = 6;
            // 
            // labelClienteEndeCEP
            // 
            labelClienteEndeCEP.AutoSize = true;
            labelClienteEndeCEP.Location = new Point(20, 149);
            labelClienteEndeCEP.Name = "labelClienteEndeCEP";
            labelClienteEndeCEP.Size = new Size(31, 15);
            labelClienteEndeCEP.TabIndex = 5;
            labelClienteEndeCEP.Text = "CEP:";
            // 
            // labelClienteEndeUF
            // 
            labelClienteEndeUF.AutoSize = true;
            labelClienteEndeUF.Location = new Point(20, 125);
            labelClienteEndeUF.Name = "labelClienteEndeUF";
            labelClienteEndeUF.Size = new Size(70, 15);
            labelClienteEndeUF.TabIndex = 4;
            labelClienteEndeUF.Text = "(UF) Estado:";
            // 
            // labelClienteEndeCidade
            // 
            labelClienteEndeCidade.AutoSize = true;
            labelClienteEndeCidade.Location = new Point(20, 100);
            labelClienteEndeCidade.Name = "labelClienteEndeCidade";
            labelClienteEndeCidade.Size = new Size(47, 15);
            labelClienteEndeCidade.TabIndex = 3;
            labelClienteEndeCidade.Text = "Cidade:";
            // 
            // labelClienteEndeComple
            // 
            labelClienteEndeComple.AutoSize = true;
            labelClienteEndeComple.Location = new Point(20, 76);
            labelClienteEndeComple.Name = "labelClienteEndeComple";
            labelClienteEndeComple.Size = new Size(87, 15);
            labelClienteEndeComple.TabIndex = 2;
            labelClienteEndeComple.Text = "Complemento:";
            // 
            // labelClienteEndereçoNúmero
            // 
            labelClienteEndereçoNúmero.AutoSize = true;
            labelClienteEndereçoNúmero.Location = new Point(20, 52);
            labelClienteEndereçoNúmero.Name = "labelClienteEndereçoNúmero";
            labelClienteEndereçoNúmero.Size = new Size(54, 15);
            labelClienteEndereçoNúmero.TabIndex = 1;
            labelClienteEndereçoNúmero.Text = "Número:";
            // 
            // labelClienteEndeRua
            // 
            labelClienteEndeRua.AutoSize = true;
            labelClienteEndeRua.Location = new Point(20, 28);
            labelClienteEndeRua.Name = "labelClienteEndeRua";
            labelClienteEndeRua.Size = new Size(103, 15);
            labelClienteEndeRua.TabIndex = 0;
            labelClienteEndeRua.Text = "Logradouro (Rua):";
            // 
            // FormNovoCliente
            // 
            AcceptButton = buttonClienteEndeOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClienteEndeCancelar;
            ClientSize = new Size(361, 304);
            Controls.Add(groupBoxClienteEndereço);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxCliente);
            Controls.Add(labelClienteEmail);
            Controls.Add(labelClienteTelefone);
            Controls.Add(labelClienteNome);
            Name = "FormNovoCliente";
            Text = "FormNovoCliente";
            groupBoxClienteEndereço.ResumeLayout(false);
            groupBoxClienteEndereço.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClienteNome;
        private Label labelClienteTelefone;
        private Label labelClienteEmail;
        private TextBox textBoxCliente;
        private TextBox textBoxTelefone;
        private TextBox textBoxEmail;
        private GroupBox groupBoxClienteEndereço;
        private Label labelClienteEndeCEP;
        private Label labelClienteEndeUF;
        private Label labelClienteEndeCidade;
        private Label labelClienteEndeComple;
        private Label labelClienteEndereçoNúmero;
        private Label labelClienteEndeRua;
        private TextBox textBoxClienteEndeCEP;
        private TextBox textBoxClienteEndeUF;
        private TextBox textBoxClienteEndeCidade;
        private TextBox textBoxEndereçoComple;
        private TextBox textBoxEnderecoNumero;
        private TextBox textBoxEnderecoLagradouro;
        private Button buttonClienteEndeCancelar;
        private Button buttonClienteEndeOK;
    }
}