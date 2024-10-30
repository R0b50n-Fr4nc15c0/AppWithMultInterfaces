namespace AppComMultiplasJanelas
{
    partial class FormNovoFornecedor
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
            labelNomeEmpresa = new Label();
            labelCNPJ = new Label();
            labelNomeContato = new Label();
            labelTelefone = new Label();
            label5 = new Label();
            textBoxNomeEmpresa = new TextBox();
            textBoxCNPJ = new TextBox();
            textBoxNomeContato = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEmail = new TextBox();
            groupBoxEndereço = new GroupBox();
            textBoxEndereçoUF = new TextBox();
            labelUF = new Label();
            buttonEndereçoCancelar = new Button();
            buttonEndereçoOk = new Button();
            textBoxEndereçoCEP = new TextBox();
            textBoxEndereçoCidade = new TextBox();
            textBoxEndereçoComplemento = new TextBox();
            textBoxEndereçoNúmero = new TextBox();
            textBoxEndereçoRua = new TextBox();
            labelEndereçoCEP = new Label();
            labelEndereçoCidade = new Label();
            labelEndereçoComplemento = new Label();
            labelEndereçoNúmero = new Label();
            labelEndereçoRua = new Label();
            groupBoxEndereço.SuspendLayout();
            SuspendLayout();
            // 
            // labelNomeEmpresa
            // 
            labelNomeEmpresa.AutoSize = true;
            labelNomeEmpresa.Location = new Point(12, 9);
            labelNomeEmpresa.Name = "labelNomeEmpresa";
            labelNomeEmpresa.Size = new Size(107, 15);
            labelNomeEmpresa.TabIndex = 0;
            labelNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // labelCNPJ
            // 
            labelCNPJ.AutoSize = true;
            labelCNPJ.Location = new Point(12, 36);
            labelCNPJ.Name = "labelCNPJ";
            labelCNPJ.Size = new Size(37, 15);
            labelCNPJ.TabIndex = 1;
            labelCNPJ.Text = "CNPJ:";
            // 
            // labelNomeContato
            // 
            labelNomeContato.AutoSize = true;
            labelNomeContato.Location = new Point(12, 62);
            labelNomeContato.Name = "labelNomeContato";
            labelNomeContato.Size = new Size(113, 15);
            labelNomeContato.TabIndex = 2;
            labelNomeContato.Text = "Nome para contato:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(12, 88);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(54, 15);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "E-mail:";
            // 
            // textBoxNomeEmpresa
            // 
            textBoxNomeEmpresa.Location = new Point(125, 6);
            textBoxNomeEmpresa.Name = "textBoxNomeEmpresa";
            textBoxNomeEmpresa.Size = new Size(238, 23);
            textBoxNomeEmpresa.TabIndex = 5;
            textBoxNomeEmpresa.TextChanged += textBox1_TextChanged;
            // 
            // textBoxCNPJ
            // 
            textBoxCNPJ.Location = new Point(125, 33);
            textBoxCNPJ.Name = "textBoxCNPJ";
            textBoxCNPJ.Size = new Size(238, 23);
            textBoxCNPJ.TabIndex = 6;
            // 
            // textBoxNomeContato
            // 
            textBoxNomeContato.Location = new Point(125, 59);
            textBoxNomeContato.Name = "textBoxNomeContato";
            textBoxNomeContato.Size = new Size(238, 23);
            textBoxNomeContato.TabIndex = 7;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(125, 85);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(238, 23);
            textBoxTelefone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(125, 111);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(238, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // groupBoxEndereço
            // 
            groupBoxEndereço.BackColor = SystemColors.ControlLight;
            groupBoxEndereço.Controls.Add(textBoxEndereçoUF);
            groupBoxEndereço.Controls.Add(labelUF);
            groupBoxEndereço.Controls.Add(buttonEndereçoCancelar);
            groupBoxEndereço.Controls.Add(buttonEndereçoOk);
            groupBoxEndereço.Controls.Add(textBoxEndereçoCEP);
            groupBoxEndereço.Controls.Add(textBoxEndereçoCidade);
            groupBoxEndereço.Controls.Add(textBoxEndereçoComplemento);
            groupBoxEndereço.Controls.Add(textBoxEndereçoNúmero);
            groupBoxEndereço.Controls.Add(textBoxEndereçoRua);
            groupBoxEndereço.Controls.Add(labelEndereçoCEP);
            groupBoxEndereço.Controls.Add(labelEndereçoCidade);
            groupBoxEndereço.Controls.Add(labelEndereçoComplemento);
            groupBoxEndereço.Controls.Add(labelEndereçoNúmero);
            groupBoxEndereço.Controls.Add(labelEndereçoRua);
            groupBoxEndereço.Location = new Point(15, 146);
            groupBoxEndereço.Name = "groupBoxEndereço";
            groupBoxEndereço.Size = new Size(348, 233);
            groupBoxEndereço.TabIndex = 10;
            groupBoxEndereço.TabStop = false;
            groupBoxEndereço.Text = "Endereço";
            // 
            // textBoxEndereçoUF
            // 
            textBoxEndereçoUF.Location = new Point(110, 168);
            textBoxEndereçoUF.Name = "textBoxEndereçoUF";
            textBoxEndereçoUF.Size = new Size(232, 23);
            textBoxEndereçoUF.TabIndex = 13;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Location = new Point(6, 171);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(67, 15);
            labelUF.TabIndex = 12;
            labelUF.Text = "UF (Estado)";
            // 
            // buttonEndereçoCancelar
            // 
            buttonEndereçoCancelar.Location = new Point(183, 204);
            buttonEndereçoCancelar.Name = "buttonEndereçoCancelar";
            buttonEndereçoCancelar.Size = new Size(159, 23);
            buttonEndereçoCancelar.TabIndex = 11;
            buttonEndereçoCancelar.Text = "Cancelar";
            buttonEndereçoCancelar.UseVisualStyleBackColor = true;
            buttonEndereçoCancelar.Click += buttonEndereçoCancelar_Click;
            // 
            // buttonEndereçoOk
            // 
            buttonEndereçoOk.Location = new Point(6, 204);
            buttonEndereçoOk.Name = "buttonEndereçoOk";
            buttonEndereçoOk.Size = new Size(159, 23);
            buttonEndereçoOk.TabIndex = 10;
            buttonEndereçoOk.Text = "OK";
            buttonEndereçoOk.UseVisualStyleBackColor = true;
            buttonEndereçoOk.Click += buttonEmdereçoOk_Click;
            // 
            // textBoxEndereçoCEP
            // 
            textBoxEndereçoCEP.Location = new Point(110, 136);
            textBoxEndereçoCEP.Name = "textBoxEndereçoCEP";
            textBoxEndereçoCEP.Size = new Size(232, 23);
            textBoxEndereçoCEP.TabIndex = 9;
            // 
            // textBoxEndereçoCidade
            // 
            textBoxEndereçoCidade.Location = new Point(110, 107);
            textBoxEndereçoCidade.Name = "textBoxEndereçoCidade";
            textBoxEndereçoCidade.Size = new Size(232, 23);
            textBoxEndereçoCidade.TabIndex = 8;
            // 
            // textBoxEndereçoComplemento
            // 
            textBoxEndereçoComplemento.Location = new Point(110, 80);
            textBoxEndereçoComplemento.Name = "textBoxEndereçoComplemento";
            textBoxEndereçoComplemento.Size = new Size(232, 23);
            textBoxEndereçoComplemento.TabIndex = 7;
            // 
            // textBoxEndereçoNúmero
            // 
            textBoxEndereçoNúmero.Location = new Point(110, 53);
            textBoxEndereçoNúmero.Name = "textBoxEndereçoNúmero";
            textBoxEndereçoNúmero.Size = new Size(232, 23);
            textBoxEndereçoNúmero.TabIndex = 6;
            // 
            // textBoxEndereçoRua
            // 
            textBoxEndereçoRua.Location = new Point(110, 26);
            textBoxEndereçoRua.Name = "textBoxEndereçoRua";
            textBoxEndereçoRua.Size = new Size(232, 23);
            textBoxEndereçoRua.TabIndex = 5;
            // 
            // labelEndereçoCEP
            // 
            labelEndereçoCEP.AutoSize = true;
            labelEndereçoCEP.Location = new Point(6, 139);
            labelEndereçoCEP.Name = "labelEndereçoCEP";
            labelEndereçoCEP.Size = new Size(31, 15);
            labelEndereçoCEP.TabIndex = 4;
            labelEndereçoCEP.Text = "CEP:";
            // 
            // labelEndereçoCidade
            // 
            labelEndereçoCidade.AutoSize = true;
            labelEndereçoCidade.Location = new Point(6, 110);
            labelEndereçoCidade.Name = "labelEndereçoCidade";
            labelEndereçoCidade.Size = new Size(47, 15);
            labelEndereçoCidade.TabIndex = 3;
            labelEndereçoCidade.Text = "Cidade:";
            // 
            // labelEndereçoComplemento
            // 
            labelEndereçoComplemento.AutoSize = true;
            labelEndereçoComplemento.Location = new Point(6, 83);
            labelEndereçoComplemento.Name = "labelEndereçoComplemento";
            labelEndereçoComplemento.Size = new Size(87, 15);
            labelEndereçoComplemento.TabIndex = 2;
            labelEndereçoComplemento.Text = "Complemento:";
            // 
            // labelEndereçoNúmero
            // 
            labelEndereçoNúmero.AutoSize = true;
            labelEndereçoNúmero.Location = new Point(6, 56);
            labelEndereçoNúmero.Name = "labelEndereçoNúmero";
            labelEndereçoNúmero.Size = new Size(54, 15);
            labelEndereçoNúmero.TabIndex = 1;
            labelEndereçoNúmero.Text = "Número:";
            // 
            // labelEndereçoRua
            // 
            labelEndereçoRua.AutoSize = true;
            labelEndereçoRua.Location = new Point(6, 29);
            labelEndereçoRua.Name = "labelEndereçoRua";
            labelEndereçoRua.Size = new Size(103, 15);
            labelEndereçoRua.TabIndex = 0;
            labelEndereçoRua.Text = "Logradouro (Rua):";
            // 
            // FormNovoFornecedor
            // 
            AcceptButton = buttonEndereçoOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonEndereçoCancelar;
            ClientSize = new Size(375, 391);
            Controls.Add(groupBoxEndereço);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxNomeContato);
            Controls.Add(textBoxCNPJ);
            Controls.Add(textBoxNomeEmpresa);
            Controls.Add(label5);
            Controls.Add(labelTelefone);
            Controls.Add(labelNomeContato);
            Controls.Add(labelCNPJ);
            Controls.Add(labelNomeEmpresa);
            Name = "FormNovoFornecedor";
            Text = "FormNovoFornecedor";
            groupBoxEndereço.ResumeLayout(false);
            groupBoxEndereço.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeEmpresa;
        private Label labelCNPJ;
        private Label labelNomeContato;
        private Label labelTelefone;
        private Label label5;
        private TextBox textBoxNomeEmpresa;
        private TextBox textBoxCNPJ;
        private TextBox textBoxNomeContato;
        private TextBox textBoxTelefone;
        private TextBox textBoxEmail;
        private GroupBox groupBoxEndereço;
        private Label labelEndereçoCEP;
        private Label labelEndereçoCidade;
        private Label labelEndereçoComplemento;
        private Label labelEndereçoNúmero;
        private Label labelEndereçoRua;
        private TextBox textBoxEndereçoCEP;
        private TextBox textBoxEndereçoCidade;
        private TextBox textBoxEndereçoComplemento;
        private TextBox textBoxEndereçoNúmero;
        private TextBox textBoxEndereçoRua;
        private Button buttonEndereçoCancelar;
        private Button buttonEndereçoOk;
        private TextBox textBoxEndereçoUF;
        private Label labelUF;
    }
}