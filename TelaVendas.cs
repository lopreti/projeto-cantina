using System;
using System.Drawing;

namespace Cantinaa
{

    public partial class TelaVendas : Form
    {
        private List<ClasseProdutos> listaProdutos = new List<ClasseProdutos>();

        private List<ClasseProdutos> carrinho = new List<ClasseProdutos>();

        private List<double> valores = new List<double>();

        private double totalPedido = 0;

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


        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label3.Visible = false;

            if (listBoxProduto.SelectedIndex == -1)
            {
                label3.Text = "Selecione um produto!";
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
                ClasseProdutos produtoSelecionado = listaProdutos[listBoxProduto.SelectedIndex];
                double valorItem = produtoSelecionado.Valor * quantidade;
                string itemTexto = $"{quantidade} x {produtoSelecionado.Descricao} - R$ {valorItem:F2}";

                carrinho.Add(produtoSelecionado);
                listBoxCarrinho.Items.Add(itemTexto);
                valores.Add(valorItem);

                totalPedido += valorItem;
                label5.Text = $"Total: R${totalPedido:F2}";
                double preco = produtoSelecionado.Valor * quantidade;
                label6.Text = "+ R$ " + preco.ToString("F2");
                label6.ForeColor = Color.Yellow;
                numericUpDown1.Value = 1;
                listBoxProduto.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                double valorItem = valores[escolhido];

                totalPedido -= valorItem;
                label6.Text = "- R$ " + valorItem.ToString("F2");
                label6.ForeColor = Color.LightGray;

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


            listaProdutos.Add(new ClasseProdutos("Pão de Queijo", 3.50));
            listaProdutos.Add(new ClasseProdutos("Coxinha", 5.00));
            listaProdutos.Add(new ClasseProdutos("Pastel de Carne", 6.00));
            listaProdutos.Add(new ClasseProdutos("Pastel de Queijo", 5.50));
            listaProdutos.Add(new ClasseProdutos("Suco Natural (300ml)", 4.00));
            listaProdutos.Add(new ClasseProdutos("Refrigerante Lata", 4.50));
            listaProdutos.Add(new ClasseProdutos("Hambúrguer Simples", 8.00));
            listaProdutos.Add(new ClasseProdutos("Hambúrguer com Queijo", 9.00));
            listaProdutos.Add(new ClasseProdutos("X-Tudo", 12.00));
            listaProdutos.Add(new ClasseProdutos("Água Mineral (500ml)", 2.50));
            listBoxProduto.Items.AddRange(listaProdutos.ToArray());

            comboBox1.Items.Add("Dinheiro");
            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão de Crédito");
            comboBox1.Items.Add("Cartão de Débito");
            comboBox1.Items.Add("Vale Refeição");
            comboBox1.Items.Add("Vale Alimentação");


        }

        private void button3_Click(object sender, EventArgs e)
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

            LimparTela();
            TelaBalcao telabalcao = new TelaBalcao();
            telabalcao.Show();
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
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxValor.Visible = true;
                label12.Visible = true;

                if (double.TryParse(textBoxValor.Text, out double valorPago))
                {
                    if (valorPago >= totalPedido)
                    {
                        double troco = valorPago - totalPedido;
                        textBoxTroco.Text = $"R$ {troco}";
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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
    }
}