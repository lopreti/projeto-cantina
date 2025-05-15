using System;
using System.Drawing;

namespace Cantinaa
{
    public partial class Form1 : Form
    {
        private List<Produtos> listaProdutos = new List<Produtos>();
        private List<Produtos> carrinho = new List<Produtos>();
        private List<double> valores = new List<double>();
        private double totalPedido = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label3.Visible = false;

            if (listBoxProduto.SelectedIndex == -1)
            {
                label3.Text = "Selecione um produto antes!";
                label3.Visible = true;
                return;
            }

            int quantidade = (int)numericUpDown1.Value;
            if (quantidade <= 0)
            {
                label7.Text = "Quantidade deve ser maior que zero!";
                label7.Visible = true;
                return;
            }

            else
            {
                Produtos produtoSelecionado = listaProdutos[listBoxProduto.SelectedIndex];
                double valorItem = produtoSelecionado.Valor * quantidade;
                string itemTexto = $"{quantidade} x {produtoSelecionado.Descricao} - R$ {valorItem:F2}";

                carrinho.Add(produtoSelecionado);
                listBoxCarrinho.Items.Add(itemTexto);
                valores.Add(valorItem);

                totalPedido += valorItem;
                label5.Text = $"Total: R${totalPedido:F2}";
                label6.Text = "+ R$ " + produtoSelecionado.Valor * quantidade;
                label6.ForeColor = Color.Green;
                numericUpDown1.Value = 1;
                listBoxProduto.SelectedIndex = -1;
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
                double valorItem = valores[escolhido];

                totalPedido -= valorItem;
                label6.Text = "- R$ " + carrinho[escolhido].Valor;
                label6.ForeColor = Color.DarkRed;

                numericUpDown1.Value = 1;
                carrinho.RemoveAt(escolhido);
                listBoxCarrinho.Items.RemoveAt(escolhido);
                valores.RemoveAt(escolhido);

                label5.Text = $"Total: R${totalPedido:F2}";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            listaProdutos.Add(new Produtos("Pão de Queijo", 3.50));
            listaProdutos.Add(new Produtos("Coxinha", 5.00));
            listaProdutos.Add(new Produtos("Pastel de Carne", 6.00));
            listaProdutos.Add(new Produtos("Pastel de Queijo", 5.50));
            listaProdutos.Add(new Produtos("Suco Natural (300ml)", 4.00));
            listaProdutos.Add(new Produtos("Refrigerante Lata", 4.50));
            listaProdutos.Add(new Produtos("Hambúrguer Simples", 8.00));
            listaProdutos.Add(new Produtos("Hambúrguer com Queijo", 9.00));
            listaProdutos.Add(new Produtos("X-Tudo", 12.00));
            listaProdutos.Add(new Produtos("Água Mineral (500ml)", 2.50));
            listBoxProduto.Items.AddRange(listaProdutos.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
           Pedido finalidado!
           Total da compra foi de R$" + totalPedido);

            listBoxCarrinho.Items.Clear();
            totalPedido = 0;
            label5.Text = $"Total: R${totalPedido:F2}";
            label6.Text = "";
            carrinho.Clear();
            valores.Clear();
        }

        private void listBoxCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dinheiro");
            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão de Crédito");
            comboBox1.Items.Add("Cartão de Débito");

        }
    }
}