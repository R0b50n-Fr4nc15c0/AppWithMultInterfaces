namespace AppComMultiplasJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionarProduto = new Button();
            buttonDeletarProduto = new Button();
            dataGridView1 = new DataGridView();
            buttonSeeProduto = new Button();
            buttonSeeFornecedores = new Button();
            buttonSeeClientes = new Button();
            buttonSeeCompras = new Button();
            buttonSeeVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonCancelarFornecedor = new Button();
            buttonAdicionarCliente = new Button();
            buttonDeletarCliente = new Button();
            buttonNovaCompra = new Button();
            buttonDeletarCompra = new Button();
            buttonNovaVenda = new Button();
            buttonDeletarVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.BackColor = Color.FromArgb(128, 255, 128);
            buttonAdicionarProduto.Location = new Point(12, 45);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(142, 23);
            buttonAdicionarProduto.TabIndex = 0;
            buttonAdicionarProduto.Text = "Novo produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = false;
            buttonAdicionarProduto.Click += ButtonAdicionarProduto_Click;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.BackColor = Color.FromArgb(128, 255, 128);
            buttonDeletarProduto.Location = new Point(12, 68);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(142, 23);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = false;
            buttonDeletarProduto.Click += ButtonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 356);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSeeProduto
            // 
            buttonSeeProduto.BackColor = Color.FromArgb(128, 255, 128);
            buttonSeeProduto.Location = new Point(12, 4);
            buttonSeeProduto.Name = "buttonSeeProduto";
            buttonSeeProduto.Size = new Size(142, 37);
            buttonSeeProduto.TabIndex = 3;
            buttonSeeProduto.Text = "Produto";
            buttonSeeProduto.UseVisualStyleBackColor = false;
            buttonSeeProduto.Click += buttonSeeProduto_Click;
            // 
            // buttonSeeFornecedores
            // 
            buttonSeeFornecedores.BackColor = Color.FromArgb(255, 192, 128);
            buttonSeeFornecedores.Location = new Point(160, 4);
            buttonSeeFornecedores.Name = "buttonSeeFornecedores";
            buttonSeeFornecedores.Size = new Size(142, 38);
            buttonSeeFornecedores.TabIndex = 4;
            buttonSeeFornecedores.Text = "Fornecedores";
            buttonSeeFornecedores.UseVisualStyleBackColor = false;
            buttonSeeFornecedores.Click += buttonSeeFornecedores_Click;
            // 
            // buttonSeeClientes
            // 
            buttonSeeClientes.BackColor = Color.FromArgb(255, 255, 128);
            buttonSeeClientes.Location = new Point(308, 4);
            buttonSeeClientes.Name = "buttonSeeClientes";
            buttonSeeClientes.Size = new Size(142, 38);
            buttonSeeClientes.TabIndex = 5;
            buttonSeeClientes.Text = "Clientes";
            buttonSeeClientes.UseVisualStyleBackColor = false;
            buttonSeeClientes.Click += buttonSeeClientes_Click;
            // 
            // buttonSeeCompras
            // 
            buttonSeeCompras.BackColor = Color.PaleTurquoise;
            buttonSeeCompras.Location = new Point(456, 3);
            buttonSeeCompras.Name = "buttonSeeCompras";
            buttonSeeCompras.Size = new Size(142, 38);
            buttonSeeCompras.TabIndex = 6;
            buttonSeeCompras.Text = "Compras";
            buttonSeeCompras.UseVisualStyleBackColor = false;
            buttonSeeCompras.Click += buttonSeeCompras_Click;
            // 
            // buttonSeeVendas
            // 
            buttonSeeVendas.BackColor = Color.FromArgb(128, 128, 255);
            buttonSeeVendas.Location = new Point(604, 3);
            buttonSeeVendas.Name = "buttonSeeVendas";
            buttonSeeVendas.Size = new Size(142, 38);
            buttonSeeVendas.TabIndex = 7;
            buttonSeeVendas.Text = "Vendas";
            buttonSeeVendas.UseVisualStyleBackColor = false;
            buttonSeeVendas.Click += buttonSeeVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.BackColor = Color.FromArgb(255, 192, 128);
            buttonAdicionarFornecedor.Location = new Point(160, 45);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(142, 23);
            buttonAdicionarFornecedor.TabIndex = 8;
            buttonAdicionarFornecedor.Text = "Novo Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedor.Click += buttonNovoFornecedor_Click;
            // 
            // buttonCancelarFornecedor
            // 
            buttonCancelarFornecedor.BackColor = Color.FromArgb(255, 192, 128);
            buttonCancelarFornecedor.Location = new Point(160, 68);
            buttonCancelarFornecedor.Name = "buttonCancelarFornecedor";
            buttonCancelarFornecedor.Size = new Size(142, 23);
            buttonCancelarFornecedor.TabIndex = 9;
            buttonCancelarFornecedor.Text = "Deletar Fornecedor";
            buttonCancelarFornecedor.UseVisualStyleBackColor = false;
            buttonCancelarFornecedor.Click += buttonCancelarFornecedor_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = Color.FromArgb(255, 255, 128);
            buttonAdicionarCliente.Location = new Point(308, 45);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(142, 23);
            buttonAdicionarCliente.TabIndex = 10;
            buttonAdicionarCliente.Text = "Novo Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.BackColor = Color.FromArgb(255, 255, 128);
            buttonDeletarCliente.Location = new Point(308, 68);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(142, 23);
            buttonDeletarCliente.TabIndex = 11;
            buttonDeletarCliente.Text = "Deletar Cliente";
            buttonDeletarCliente.UseVisualStyleBackColor = false;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // buttonNovaCompra
            // 
            buttonNovaCompra.BackColor = Color.PaleTurquoise;
            buttonNovaCompra.Location = new Point(456, 44);
            buttonNovaCompra.Name = "buttonNovaCompra";
            buttonNovaCompra.Size = new Size(142, 24);
            buttonNovaCompra.TabIndex = 12;
            buttonNovaCompra.Text = "Nova Compra";
            buttonNovaCompra.UseVisualStyleBackColor = false;
            buttonNovaCompra.Click += buttonNovaCompra_Click;
            // 
            // buttonDeletarCompra
            // 
            buttonDeletarCompra.BackColor = Color.PaleTurquoise;
            buttonDeletarCompra.Location = new Point(456, 68);
            buttonDeletarCompra.Name = "buttonDeletarCompra";
            buttonDeletarCompra.Size = new Size(142, 23);
            buttonDeletarCompra.TabIndex = 13;
            buttonDeletarCompra.Text = "Deletar Compra";
            buttonDeletarCompra.UseVisualStyleBackColor = false;
            // 
            // buttonNovaVenda
            // 
            buttonNovaVenda.BackColor = Color.FromArgb(128, 128, 255);
            buttonNovaVenda.Location = new Point(604, 44);
            buttonNovaVenda.Name = "buttonNovaVenda";
            buttonNovaVenda.Size = new Size(142, 24);
            buttonNovaVenda.TabIndex = 14;
            buttonNovaVenda.Text = "Nova Venda";
            buttonNovaVenda.UseVisualStyleBackColor = false;
            buttonNovaVenda.Click += buttonNovaVenda_Click;
            // 
            // buttonDeletarVenda
            // 
            buttonDeletarVenda.BackColor = Color.FromArgb(128, 128, 255);
            buttonDeletarVenda.Location = new Point(604, 68);
            buttonDeletarVenda.Name = "buttonDeletarVenda";
            buttonDeletarVenda.Size = new Size(142, 23);
            buttonDeletarVenda.TabIndex = 15;
            buttonDeletarVenda.Text = "Deletar Venda";
            buttonDeletarVenda.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 465);
            Controls.Add(buttonDeletarVenda);
            Controls.Add(buttonNovaVenda);
            Controls.Add(buttonDeletarCompra);
            Controls.Add(buttonNovaCompra);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonCancelarFornecedor);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonSeeVendas);
            Controls.Add(buttonSeeCompras);
            Controls.Add(buttonSeeClientes);
            Controls.Add(buttonSeeFornecedores);
            Controls.Add(buttonSeeProduto);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeletarProduto);
            Controls.Add(buttonAdicionarProduto);
            ForeColor = SystemColors.InfoText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
        private Button buttonDeletarProduto;
        private DataGridView dataGridView1;
        private Button buttonSeeProduto;
        private Button buttonSeeFornecedores;
        private Button buttonSeeClientes;
        private Button buttonSeeCompras;
        private Button buttonSeeVendas;
        private Button buttonAdicionarFornecedor;
        private Button buttonCancelarFornecedor;
        private Button buttonAdicionarCliente;
        private Button buttonDeletarCliente;
        private Button buttonNovaCompra;
        private Button buttonDeletarCompra;
        private Button buttonNovaVenda;
        private Button buttonDeletarVenda;
    }
}
