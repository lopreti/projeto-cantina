using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cantinaa
{

    public partial class TelaVendas : Form
    {
        private List<Produtos> carrinho = new List<Produtos>();

        private double totalPedido = 0;

        private bool menuAberto = false;

        public TelaVendas()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            listBoxCarrinho.Items.Clear();
            totalPedido = 0;
            label5.Text = $"Total: R${totalPedido:F2}";
            label6.Text = "";
            carrinho.Clear();
            comboBox1.SelectedIndex = -1;
            textBoxValor.Clear();
            textBoxTroco.Clear();
            textBoxNome.Clear();
            checkBox1.Checked = false;
        }
        private void AtualizarLista()
        {
            GerenciadorDados.CarregarTodosDados();

            listBoxProduto.Items.Clear();

            foreach (var estoqueItem in PersistênciaEstoque.listaEstoque)
            {
                if (estoqueItem.Produtos.ISAtivo && estoqueItem.quantidade > 0)
                {

                    listBoxProduto.Items.Add(estoqueItem.Produtos);
                }
            }
        }

        private Estoque EncontrarEstoque(string descricao)
        {
            foreach (Estoque item in PersistênciaEstoque.listaEstoque)
            {
                if (item.Produtos.Descricao == descricao)
                {
                    return item;
                }
            }
            return null;
        }

        private bool ValidarPagamento()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (double.TryParse(textBoxValor.Text, out double valorPago))
                {
                    if (valorPago >= totalPedido)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Valor pago insuficiente.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor válido em dinheiro.");
                    return false;
                }
            }
            else
            {
                return comboBox1.SelectedIndex != -1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;

            if (PersistênciaEstoque.listaEstoque.Count == 0)
            {
                PersistênciaEstoque.IniciarEstoque();
                GerenciadorDados.SalvarTodosDados();
            }

            AtualizarLista();
            comboBox1.Items.Add("Dinheiro");
            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão de Crédito");
            comboBox1.Items.Add("Cartão de Débito");
            comboBox1.Items.Add("Vale Refeição");
            comboBox1.Items.Add("Vale Alimentação");

            panel1.Visible = false;
        }

        private void listBoxCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCarrinho.SelectedIndex != -1)
            {
                label9.Visible = false;
                numericUpDown1.Visible = false;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxValor.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                textBoxTroco.Visible = true;
            }

            else
            {
                textBoxValor.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                textBoxTroco.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxValor.Text, out double valorPago))
            {
                if (valorPago >= totalPedido)
                {
                    double troco = valorPago - totalPedido;
                    textBoxTroco.Text = $"R$ {troco:F2}";
                }
                else
                {
                    textBoxTroco.Text = "Insuficiente!";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void listBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProduto.SelectedIndex != -1)
            {
                label9.Visible = true;
                numericUpDown1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuAberto)
            {
                panel1.Visible = false;
                menuAberto = false;
            }
            else
            {
                panel1.Visible = true;
                menuAberto = true;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a forma de pagamento!");
                return;
            }

            if (textBoxNome.Text == string.Empty)
            {
                MessageBox.Show("Digite um nome!");
                return;
            }
            if (listBoxCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Carrinho Vazio");
                return;
            }

            if (comboBox1.SelectedIndex == 0)
            {

                if (!ValidarPagamento())
                {
                    return;
                }

                MessageBox.Show(@$"EXTRATO
------------------------------------
Pedido finalizado, {textBoxNome.Text}!

Total da compra: R$ {totalPedido:F2}

Forma de Pagamento: Dinheiro
Você pagou: R$ {textBoxValor.Text}
Troco de: {textBoxTroco.Text}

Data/Hora: {dataHora}
------------------------------------");

            }
            else
            {
                MessageBox.Show(@$"EXTRATO
------------------------------------
Pedido finalizado, {textBoxNome.Text}!

Total da compra: R$ {totalPedido:F2}
Forma de Pagamento: {comboBox1.SelectedItem}

Data/Hora: {dataHora}
------------------------------------");
            }

            bool temChapa = false;

            foreach (Produtos produtos in carrinho)
            {
                if (produtos.IsChapa)
                {
                    temChapa = true;
                    break;
                }
            }
            Pedidos PedidoFeito = new Pedidos(textBoxNome.Text , comboBox1.SelectedItem.ToString(), checkBox1.Checked, carrinho.ToList());

            if (temChapa)
            {
                PedidoFeito.statusPedido = Status.Preparando;
                PersistenciaPedido.pedidosCozinha.Add(PedidoFeito);
                MessageBox.Show("Seu pedido foi enviado para a cozinha! Espere enquanto preparamos.");
            }

            else
            {
                PedidoFeito.statusPedido = Status.Pronto;
                PersistenciaPedido.pedidosBalcao.Add(PedidoFeito);
            }

            GerenciadorDados.SalvarTodosDados();
            AtualizarLista();
            LimparTela();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label3.Visible = false;

            int quantidade = (int)numericUpDown1.Value;

            if (listBoxProduto.SelectedIndex == -1)
            {
                label3.Text = "Selecione um produto!";
                label3.Visible = true;
                return;
            }

            if (quantidade <= 0)
            {
                label7.Text = "Quantidade deve ser maior que zero!";
                label7.Visible = true;
                return;
            }


            Produtos produtoSelecionado = (Produtos)listBoxProduto.SelectedItem;

            Estoque estoqueItem = EncontrarEstoque(produtoSelecionado.Descricao);

            if (estoqueItem == null || estoqueItem.quantidade < quantidade)
            {
                MessageBox.Show("Quantidade indisponível. A quantidade atual no estoque é: " + estoqueItem.quantidade);
                numericUpDown1.Value = estoqueItem.quantidade;
                return;

            }
            estoqueItem.RemoverQuantidade(quantidade);

            Produtos produtoCarrinho = new Produtos(produtoSelecionado.Descricao, produtoSelecionado.Valor, quantidade, produtoSelecionado.IsChapa, produtoSelecionado.ISAtivo);
            carrinho.Add(produtoCarrinho);

            double valorItem = produtoCarrinho.Valor * produtoCarrinho.Quantidade;
            string itemTexto = $"{quantidade} x {produtoSelecionado.Descricao} - R$ {valorItem:F2}";

            listBoxCarrinho.Items.Add(itemTexto);

            if (estoqueItem.quantidade == 0)
            {
                estoqueItem.Produtos.ISAtivo = false;
                MessageBox.Show($"Produto '{estoqueItem.Produtos.Descricao}' esgotado e desativado do estoque.");
                GerenciadorDados.SalvarTodosDados();
            }

            totalPedido += valorItem;
            label5.Text = $"Total: R${totalPedido:F2}";
            label6.Text = "+ R$ " + valorItem.ToString("F2");
            label6.ForeColor = Color.Yellow;

            numericUpDown1.Value = 1;
            listBoxProduto.SelectedIndex = -1;
            GerenciadorDados.SalvarTodosDados();
            AtualizarLista();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;

            if (listBoxCarrinho.SelectedIndex == -1)
            {
                label4.Text = "Selecione um produto!";
                label4.Visible = true;
                return;
            }

            else
            {
                int escolhido = listBoxCarrinho.SelectedIndex;
                Produtos produtoRemovido = carrinho[escolhido];

                Estoque estoqueItem = EncontrarEstoque(produtoRemovido.Descricao);

                if (estoqueItem != null)
                {
                    estoqueItem.AdicionarQuantidade(produtoRemovido.Quantidade);

                    if (estoqueItem.quantidade > 0 && estoqueItem.Produtos.ISAtivo == false)
                    {
                        estoqueItem.Produtos.ISAtivo = true;
                        MessageBox.Show($"Produto '{estoqueItem.Produtos.Descricao}' reativado no estoque.");
                        GerenciadorDados.SalvarTodosDados();
                    }
                }

                double valorItem = produtoRemovido.Valor * produtoRemovido.Quantidade;
                totalPedido -= valorItem;
                label6.Text = "- R$ " + valorItem.ToString("F2");
                label6.ForeColor = Color.LightGray;

                numericUpDown1.Value = 1;
                carrinho.RemoveAt(escolhido);
                listBoxCarrinho.Items.RemoveAt(escolhido);

                label5.Text = $"Total: R${totalPedido:F2}";
                GerenciadorDados.SalvarTodosDados();
                AtualizarLista();
            }
        }
    }
}