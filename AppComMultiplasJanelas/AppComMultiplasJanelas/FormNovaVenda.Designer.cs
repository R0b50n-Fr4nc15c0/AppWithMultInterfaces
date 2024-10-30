namespace AppComMultiplasJanelas
{
    partial class FormNovaVenda
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
            labelVendaProduto = new Label();
            labelVendaCliente = new Label();
            comboBoxProduto = new ComboBox();
            comboBoxCliente = new ComboBox();
            labelVendaQuantidade = new Label();
            labelVendaDesconto = new Label();
            labelVendaPreçoUnitario = new Label();
            labelVendaValorTotal = new Label();
            labelVendaValorComDesconto = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            textBoxPreçoUnitario = new TextBox();
            textBoxValorComDesconto = new TextBox();
            textBoxValorTotal = new TextBox();
            buttonVendaOK = new Button();
            buttonVendaCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // labelVendaProduto
            // 
            labelVendaProduto.AutoSize = true;
            labelVendaProduto.Location = new Point(12, 15);
            labelVendaProduto.Name = "labelVendaProduto";
            labelVendaProduto.Size = new Size(53, 15);
            labelVendaProduto.TabIndex = 1;
            labelVendaProduto.Text = "Produto:";
            // 
            // labelVendaCliente
            // 
            labelVendaCliente.AutoSize = true;
            labelVendaCliente.Location = new Point(12, 44);
            labelVendaCliente.Name = "labelVendaCliente";
            labelVendaCliente.Size = new Size(47, 15);
            labelVendaCliente.TabIndex = 2;
            labelVendaCliente.Text = "Cliente:";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(181, 12);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(237, 23);
            comboBoxProduto.TabIndex = 8;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(181, 41);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(237, 23);
            comboBoxCliente.TabIndex = 9;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // labelVendaQuantidade
            // 
            labelVendaQuantidade.AutoSize = true;
            labelVendaQuantidade.Location = new Point(12, 70);
            labelVendaQuantidade.Name = "labelVendaQuantidade";
            labelVendaQuantidade.Size = new Size(72, 15);
            labelVendaQuantidade.TabIndex = 10;
            labelVendaQuantidade.Text = "Quantidade:";
            // 
            // labelVendaDesconto
            // 
            labelVendaDesconto.AutoSize = true;
            labelVendaDesconto.Location = new Point(12, 101);
            labelVendaDesconto.Name = "labelVendaDesconto";
            labelVendaDesconto.Size = new Size(81, 15);
            labelVendaDesconto.TabIndex = 11;
            labelVendaDesconto.Text = "Desconto (%):";
            // 
            // labelVendaPreçoUnitario
            // 
            labelVendaPreçoUnitario.AutoSize = true;
            labelVendaPreçoUnitario.Location = new Point(12, 128);
            labelVendaPreçoUnitario.Name = "labelVendaPreçoUnitario";
            labelVendaPreçoUnitario.Size = new Size(85, 15);
            labelVendaPreçoUnitario.TabIndex = 12;
            labelVendaPreçoUnitario.Text = "Preço Unitario:";
            // 
            // labelVendaValorTotal
            // 
            labelVendaValorTotal.AutoSize = true;
            labelVendaValorTotal.Location = new Point(12, 154);
            labelVendaValorTotal.Name = "labelVendaValorTotal";
            labelVendaValorTotal.Size = new Size(64, 15);
            labelVendaValorTotal.TabIndex = 13;
            labelVendaValorTotal.Text = "Valor Total:";
            // 
            // labelVendaValorComDesconto
            // 
            labelVendaValorComDesconto.AutoSize = true;
            labelVendaValorComDesconto.Location = new Point(12, 186);
            labelVendaValorComDesconto.Name = "labelVendaValorComDesconto";
            labelVendaValorComDesconto.Size = new Size(118, 15);
            labelVendaValorComDesconto.TabIndex = 14;
            labelVendaValorComDesconto.Text = "Valor Com Desconto:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(181, 70);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(237, 23);
            numericUpDownQuantidade.TabIndex = 15;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.Location = new Point(181, 99);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(237, 23);
            numericUpDownDesconto.TabIndex = 16;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // textBoxPreçoUnitario
            // 
            textBoxPreçoUnitario.BackColor = SystemColors.ControlDark;
            textBoxPreçoUnitario.ForeColor = SystemColors.ControlLight;
            textBoxPreçoUnitario.Location = new Point(181, 125);
            textBoxPreçoUnitario.Name = "textBoxPreçoUnitario";
            textBoxPreçoUnitario.ReadOnly = true;
            textBoxPreçoUnitario.Size = new Size(237, 23);
            textBoxPreçoUnitario.TabIndex = 17;
            // 
            // textBoxValorComDesconto
            // 
            textBoxValorComDesconto.BackColor = SystemColors.ControlDark;
            textBoxValorComDesconto.ForeColor = SystemColors.ControlLight;
            textBoxValorComDesconto.Location = new Point(181, 183);
            textBoxValorComDesconto.Name = "textBoxValorComDesconto";
            textBoxValorComDesconto.ReadOnly = true;
            textBoxValorComDesconto.Size = new Size(237, 23);
            textBoxValorComDesconto.TabIndex = 18;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.ControlDark;
            textBoxValorTotal.ForeColor = SystemColors.ControlLight;
            textBoxValorTotal.Location = new Point(181, 154);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(237, 23);
            textBoxValorTotal.TabIndex = 19;
            // 
            // buttonVendaOK
            // 
            buttonVendaOK.Location = new Point(12, 215);
            buttonVendaOK.Name = "buttonVendaOK";
            buttonVendaOK.Size = new Size(163, 23);
            buttonVendaOK.TabIndex = 20;
            buttonVendaOK.Text = "OK";
            buttonVendaOK.UseVisualStyleBackColor = true;
            buttonVendaOK.Click += buttonVendaOK_Click;
            // 
            // buttonVendaCancelar
            // 
            buttonVendaCancelar.Location = new Point(255, 215);
            buttonVendaCancelar.Name = "buttonVendaCancelar";
            buttonVendaCancelar.Size = new Size(163, 23);
            buttonVendaCancelar.TabIndex = 21;
            buttonVendaCancelar.Text = "Cancelar";
            buttonVendaCancelar.UseVisualStyleBackColor = true;
            buttonVendaCancelar.Click += buttonVendaCancelar_Click;
            // 
            // FormNovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 245);
            Controls.Add(buttonVendaCancelar);
            Controls.Add(buttonVendaOK);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxValorComDesconto);
            Controls.Add(textBoxPreçoUnitario);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelVendaValorComDesconto);
            Controls.Add(labelVendaValorTotal);
            Controls.Add(labelVendaPreçoUnitario);
            Controls.Add(labelVendaDesconto);
            Controls.Add(labelVendaQuantidade);
            Controls.Add(comboBoxCliente);
            Controls.Add(comboBoxProduto);
            Controls.Add(labelVendaCliente);
            Controls.Add(labelVendaProduto);
            Name = "FormNovaVenda";
            Text = "FormNovaVenda";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVendaProduto;
        private Label labelVendaCliente;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxCliente;
        private Label labelVendaQuantidade;
        private Label labelVendaDesconto;
        private Label labelVendaPreçoUnitario;
        private Label labelVendaValorTotal;
        private Label labelVendaValorComDesconto;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private TextBox textBoxPreçoUnitario;
        private TextBox textBoxValorComDesconto;
        private TextBox textBoxValorTotal;
        private Button buttonVendaOK;
        private Button buttonVendaCancelar;
    }
}