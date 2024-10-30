using System.ComponentModel;
using System.Reflection;

namespace AppComMultiplasJanelas
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        private BindingList<Cliente> Clientes = new BindingList<Cliente>();
        private BindingList<Fornecedor> Fornecedores = new BindingList<Fornecedor>();
        private BindingList<Venda> Vendas = new BindingList<Venda>();
        private BindingList<Compra> Compras = new BindingList<Compra>();
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = Produtos;
        }

        private void ButtonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();
            DialogResult resultado = fnp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //string textoProduto = $"{fnp.Nome}-{fnp.Fabricante}(R${fnp.PreçoCompra})(R${fnp.PreçoVenda})";
                //listBoxProdutos.Items.Add(textoProduto);

                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fnp.Nome;
                produto.Fabricante = fnp.Fabricante;
                produto.PreçoVenda = fnp.PreçoVenda;
                produto.PreçoCompra = fnp.PreçoCompra;

                Produtos.Add(produto);
            }
        }





        private void ButtonDeletarProduto_Click(object sender, EventArgs e)
        {
            //if (listBoxProdutos.Items.Count > 0) 
            //{
            //    if (listBoxProdutos.SelectedIndex >= 0)
            //    { listBoxProdutos.Items.RemoveAt(listBoxProdutos.SelectedIndex); }
            //}

            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonSeeProduto_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Produtos;
        }

        private void buttonSeeFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Fornecedores;
        }

        private void buttonSeeClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Clientes;
        }

        private void buttonSeeCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;
        }

        private void buttonSeeVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor fnf = new FormNovoFornecedor();
            var resultado = fnf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.NomeEmpresa = fnf.NomeEmpresa;
                fornecedor.NomeContato = fnf.NomeContato;
                fornecedor.Endereço = fnf.Endereço;
                fornecedor.Email = fnf.Email;
                fornecedor.Telefone = fnf.Telefone;
                Fornecedores.Add(fornecedor);
            }
        }

        private void buttonCancelarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Fornecedores)
            {
                Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente fnc = new FormNovoCliente();
            var resultado = fnc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (Clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Nome = fnc.Nome;
                cliente.Endereço = fnc.Endereço;
                cliente.Email = fnc.Email;
                cliente.Telefone = fnc.Telefone;
                Clientes.Add(cliente);
            }
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows.Count - 1);
                }
            }
        }

        private void buttonNovaCompra_Click(object sender, EventArgs e)
        {
            if (Fornecedores.Count == 0)
            {
                MessageBox.Show("Você precisa cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }

            if (Produtos.Count == 0)
            {
                MessageBox.Show("Você precisa cadastrar produtos antes de efetuar uma compra.");
                return;
            }

            FormNovaCompra fnc = new FormNovaCompra(Fornecedores, Produtos);
            var resultado = fnc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (Compras.Count == 0) compra.Id = 1;
                else compra.Id = Compras.Max(x => x.Id) + 1;

                compra.IdProduto = fnc.IdProduto;
                compra.IdFornecedor = fnc.IdFornecedor;
                compra.Quantidade = (int)fnc.Quantidade;
                compra.Desconto = fnc.Desconto;
                compra.DataCompra = DateTime.Now;

                Compras.Add(compra);
                this.dataGridView1.DataSource = Compras;
            }
        }

        private void buttonNovaVenda_Click(object sender, EventArgs e)
        {
            if (Clientes.Count == 0) { MessageBox.Show("Você precisa cadastrar Clientes antes de efetuar uma venda.");return; }
            if (Produtos.Count == 0) { MessageBox.Show("Você precisa cadastrar Produtos antes de efetuar uma venda.");return; }

            FormNovaVenda fnv = new FormNovaVenda(Clientes, Produtos);
            var resultado = fnv.ShowDialog();
            if (resultado == DialogResult.OK) 
            {
                Venda venda = new Venda();
                if (Vendas.Count == 0) venda.Id = 1;
                else venda.Id = Vendas.Max(x => x.Id) + 1;

                venda.IdProduto = fnv.IdProduto;
                venda.IdCliente = fnv.IdCliente;
                venda.Quantidade = (int)fnv.Quantidade;
                venda.Desconto = fnv.Desconto;
                venda.DataVenda = DateTime.Now;

                Vendas.Add(venda);
                this.dataGridView1.DataSource = Vendas;
                
            }
        }
    }
}
