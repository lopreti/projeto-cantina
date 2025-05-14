using System;
using System.Drawing;

namespace Cantinaa
{
    public partial class Form1 : Form
    {
        private List<Produtos> listaProdutos = new List<Produtos>();
        private List<Produtos> carrinho = new List<Produtos>();
        private double totalPedido = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (listBoxProduto.SelectedIndex == -1)
            {
                label3.Text = "Selecione um produto antes!";
                label3.Visible = true;
                return;
            }

            else
            {
                Produtos produtoSelecionado = listaProdutos[listBoxProduto.SelectedIndex];
                carrinho.Add(produtoSelecionado);
                listBoxCarrinho.Items.Add(produtoSelecionado);

                totalPedido += produtoSelecionado.Valor;
                label5.Text = $"Total: R${totalPedido}";
                label6.Text = "+ R$ " + produtoSelecionado.Valor;
                label6.ForeColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (listBoxCarrinho.SelectedIndex == -1)
            {
                label4.Text = "Selecione um produto antes!";
                label4.Visible = true;
                return;
            }
            else
            {
                int escolhido = listBoxCarrinho.SelectedIndex;
                totalPedido -= carrinho[escolhido].Valor;
                label6.Text = "- R$ " + carrinho[escolhido].Valor;
                label6.ForeColor = Color.DarkRed;
                carrinho.RemoveAt(escolhido);
                listBoxCarrinho.Items.RemoveAt(escolhido);

                label5.Text = $"Total: R${totalPedido}";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listaProdutos.Add(new Produtos("Coxinha", 5.00));
            listaProdutos.Add(new Produtos("Pastel", 6.00));
            listaProdutos.Add(new Produtos("Refrigerante", 4.50));
            listaProdutos.Add(new Produtos("Suco", 3.00));
            listaProdutos.Add(new Produtos("Brigadeiro", 2.00));

            listBoxProduto.Items.AddRange(listaProdutos.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido finalidado! Total da compra foi de R$" + totalPedido);
            listBoxCarrinho.Items.Clear();
            totalPedido = 0;
            label5.Text = $"Total: R${totalPedido}";
            label6.Text = "";
            carrinho.Clear();
        }

        private void listBoxCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}