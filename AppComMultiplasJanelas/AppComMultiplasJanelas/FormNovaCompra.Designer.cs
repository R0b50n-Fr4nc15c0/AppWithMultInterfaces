namespace AppComMultiplasJanelas
{
    partial class FormNovaCompra
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
            labelCompraProduto = new Label();
            labelCompraFornecedor = new Label();
            labelCompraQuantidade = new Label();
            labelCompraDesconto = new Label();
            labelCompraPreçoUnitario = new Label();
            labelCompraValorTotal = new Label();
            labelCompraValorComDesconto = new Label();
            comboBoxCompraProduto = new ComboBox();
            comboBoxCompraFornecedor = new ComboBox();
            numericUpDownCompraQuantidade = new NumericUpDown();
            numericUpDownCompraDesconto = new NumericUpDown();
            textBoxCompraPreçoUnitario = new TextBox();
            textBoxCompraValorTotal = new TextBox();
            textBoxCompraValorComDesconto = new TextBox();
            buttonCompraOK = new Button();
            buttonCompraCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompraQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompraDesconto).BeginInit();
            SuspendLayout();
            // 
            // labelCompraProduto
            // 
            labelCompraProduto.AutoSize = true;
            labelCompraProduto.Location = new Point(26, 15);
            labelCompraProduto.Name = "labelCompraProduto";
            labelCompraProduto.Size = new Size(53, 15);
            labelCompraProduto.TabIndex = 0;
            labelCompraProduto.Text = "Produto:";
            // 
            // labelCompraFornecedor
            // 
            labelCompraFornecedor.AutoSize = true;
            labelCompraFornecedor.Location = new Point(26, 49);
            labelCompraFornecedor.Name = "labelCompraFornecedor";
            labelCompraFornecedor.Size = new Size(70, 15);
            labelCompraFornecedor.TabIndex = 1;
            labelCompraFornecedor.Text = "Fornecedor:";
            // 
            // labelCompraQuantidade
            // 
            labelCompraQuantidade.AutoSize = true;
            labelCompraQuantidade.Location = new Point(26, 80);
            labelCompraQuantidade.Name = "labelCompraQuantidade";
            labelCompraQuantidade.Size = new Size(72, 15);
            labelCompraQuantidade.TabIndex = 2;
            labelCompraQuantidade.Text = "Quantidade:";
            // 
            // labelCompraDesconto
            // 
            labelCompraDesconto.AutoSize = true;
            labelCompraDesconto.Location = new Point(26, 112);
            labelCompraDesconto.Name = "labelCompraDesconto";
            labelCompraDesconto.Size = new Size(81, 15);
            labelCompraDesconto.TabIndex = 3;
            labelCompraDesconto.Text = "Desconto (%):";
            // 
            // labelCompraPreçoUnitario
            // 
            labelCompraPreçoUnitario.AutoSize = true;
            labelCompraPreçoUnitario.Location = new Point(26, 145);
            labelCompraPreçoUnitario.Name = "labelCompraPreçoUnitario";
            labelCompraPreçoUnitario.Size = new Size(85, 15);
            labelCompraPreçoUnitario.TabIndex = 4;
            labelCompraPreçoUnitario.Text = "Preço Unitario:";
            // 
            // labelCompraValorTotal
            // 
            labelCompraValorTotal.AutoSize = true;
            labelCompraValorTotal.Location = new Point(26, 180);
            labelCompraValorTotal.Name = "labelCompraValorTotal";
            labelCompraValorTotal.Size = new Size(64, 15);
            labelCompraValorTotal.TabIndex = 5;
            labelCompraValorTotal.Text = "Valor Total:";
            // 
            // labelCompraValorComDesconto
            // 
            labelCompraValorComDesconto.AutoSize = true;
            labelCompraValorComDesconto.Location = new Point(26, 216);
            labelCompraValorComDesconto.Name = "labelCompraValorComDesconto";
            labelCompraValorComDesconto.Size = new Size(118, 15);
            labelCompraValorComDesconto.TabIndex = 6;
            labelCompraValorComDesconto.Text = "Valor Com Desconto:";
            // 
            // comboBoxCompraProduto
            // 
            comboBoxCompraProduto.FormattingEnabled = true;
            comboBoxCompraProduto.Location = new Point(161, 12);
            comboBoxCompraProduto.Name = "comboBoxCompraProduto";
            comboBoxCompraProduto.Size = new Size(237, 23);
            comboBoxCompraProduto.TabIndex = 7;
            comboBoxCompraProduto.SelectedIndexChanged += comboBoxCompraProduto_SelectedIndexChanged;
            // 
            // comboBoxCompraFornecedor
            // 
            comboBoxCompraFornecedor.FormattingEnabled = true;
            comboBoxCompraFornecedor.Location = new Point(161, 46);
            comboBoxCompraFornecedor.Name = "comboBoxCompraFornecedor";
            comboBoxCompraFornecedor.Size = new Size(237, 23);
            comboBoxCompraFornecedor.TabIndex = 8;
            // 
            // numericUpDownCompraQuantidade
            // 
            numericUpDownCompraQuantidade.Location = new Point(161, 78);
            numericUpDownCompraQuantidade.Name = "numericUpDownCompraQuantidade";
            numericUpDownCompraQuantidade.Size = new Size(237, 23);
            numericUpDownCompraQuantidade.TabIndex = 9;
            numericUpDownCompraQuantidade.ValueChanged += numericUpDownCompraQuantidade_ValueChanged;
            // 
            // numericUpDownCompraDesconto
            // 
            numericUpDownCompraDesconto.Location = new Point(161, 110);
            numericUpDownCompraDesconto.Name = "numericUpDownCompraDesconto";
            numericUpDownCompraDesconto.Size = new Size(237, 23);
            numericUpDownCompraDesconto.TabIndex = 10;
            numericUpDownCompraDesconto.ValueChanged += numericUpDownCompraDesconto_ValueChanged;
            // 
            // textBoxCompraPreçoUnitario
            // 
            textBoxCompraPreçoUnitario.BackColor = SystemColors.ControlDark;
            textBoxCompraPreçoUnitario.ForeColor = SystemColors.ControlLight;
            textBoxCompraPreçoUnitario.Location = new Point(161, 142);
            textBoxCompraPreçoUnitario.Name = "textBoxCompraPreçoUnitario";
            textBoxCompraPreçoUnitario.ReadOnly = true;
            textBoxCompraPreçoUnitario.Size = new Size(237, 23);
            textBoxCompraPreçoUnitario.TabIndex = 11;
            // 
            // textBoxCompraValorTotal
            // 
            textBoxCompraValorTotal.BackColor = SystemColors.ControlDark;
            textBoxCompraValorTotal.ForeColor = SystemColors.ControlLight;
            textBoxCompraValorTotal.Location = new Point(161, 177);
            textBoxCompraValorTotal.Name = "textBoxCompraValorTotal";
            textBoxCompraValorTotal.ReadOnly = true;
            textBoxCompraValorTotal.Size = new Size(237, 23);
            textBoxCompraValorTotal.TabIndex = 12;
            // 
            // textBoxCompraValorComDesconto
            // 
            textBoxCompraValorComDesconto.BackColor = SystemColors.ControlDark;
            textBoxCompraValorComDesconto.ForeColor = SystemColors.ControlLight;
            textBoxCompraValorComDesconto.Location = new Point(161, 213);
            textBoxCompraValorComDesconto.Name = "textBoxCompraValorComDesconto";
            textBoxCompraValorComDesconto.ReadOnly = true;
            textBoxCompraValorComDesconto.Size = new Size(237, 23);
            textBoxCompraValorComDesconto.TabIndex = 13;
            // 
            // buttonCompraOK
            // 
            buttonCompraOK.Location = new Point(26, 239);
            buttonCompraOK.Name = "buttonCompraOK";
            buttonCompraOK.Size = new Size(146, 23);
            buttonCompraOK.TabIndex = 14;
            buttonCompraOK.Text = "OK";
            buttonCompraOK.UseVisualStyleBackColor = true;
            buttonCompraOK.Click += buttonCompraOK_Click;
            // 
            // buttonCompraCancelar
            // 
            buttonCompraCancelar.Location = new Point(252, 242);
            buttonCompraCancelar.Name = "buttonCompraCancelar";
            buttonCompraCancelar.Size = new Size(146, 23);
            buttonCompraCancelar.TabIndex = 15;
            buttonCompraCancelar.Text = "Cancelar";
            buttonCompraCancelar.UseVisualStyleBackColor = true;
            buttonCompraCancelar.Click += buttonCompraCancelar_Click;
            // 
            // FormNovaCompra
            // 
            AcceptButton = buttonCompraOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCompraCancelar;
            ClientSize = new Size(410, 274);
            Controls.Add(buttonCompraCancelar);
            Controls.Add(buttonCompraOK);
            Controls.Add(textBoxCompraValorComDesconto);
            Controls.Add(textBoxCompraValorTotal);
            Controls.Add(textBoxCompraPreçoUnitario);
            Controls.Add(numericUpDownCompraDesconto);
            Controls.Add(numericUpDownCompraQuantidade);
            Controls.Add(comboBoxCompraFornecedor);
            Controls.Add(comboBoxCompraProduto);
            Controls.Add(labelCompraValorComDesconto);
            Controls.Add(labelCompraValorTotal);
            Controls.Add(labelCompraPreçoUnitario);
            Controls.Add(labelCompraDesconto);
            Controls.Add(labelCompraQuantidade);
            Controls.Add(labelCompraFornecedor);
            Controls.Add(labelCompraProduto);
            Name = "FormNovaCompra";
            Text = "FormNovaCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompraQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompraDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCompraProduto;
        private Label labelCompraFornecedor;
        private Label labelCompraQuantidade;
        private Label labelCompraDesconto;
        private Label labelCompraPreçoUnitario;
        private Label labelCompraValorTotal;
        private Label labelCompraValorComDesconto;
        private ComboBox comboBoxCompraProduto;
        private ComboBox comboBoxCompraFornecedor;
        private NumericUpDown numericUpDownCompraQuantidade;
        private NumericUpDown numericUpDownCompraDesconto;
        private TextBox textBoxCompraPreçoUnitario;
        private TextBox textBoxCompraValorTotal;
        private TextBox textBoxCompraValorComDesconto;
        private Button buttonCompraOK;
        private Button buttonCompraCancelar;
    }
}