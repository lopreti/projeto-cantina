using System;
using System.Drawing;

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

            else
            {
                Produtos produtoSelecionado = PersistênciaProduto.listaProdutos[listBoxProduto.SelectedIndex];
                Produtos produtoCarrinho = new Produtos(produtoSelecionado.Descricao, produtoSelecionado.Valor, quantidade, produtoSelecionado.IsChapa);
                Estoque estoque = new Estoque();

                foreach (var item in PersistênciaProduto.listaProdutos) 
                {
                    if (item.Descricao == produtoSelecionado.Descricao)
                    {
                        if (item.Quantidade < quantidade)
                        {
                            MessageBox.Show("Quantidade insuficiente no estoque!");
                            return;
                        }
                        else 
                        {
                            item.Quantidade -= quantidade;

                            foreach (var estoqueItem in PersistênciaEstoque.listaEstoque)
                            {
                                if (estoqueItem.Produtos.Descricao == produtoSelecionado.Descricao)
                                {
                                    estoqueItem.quantidade -= quantidade;
                                    break;
                                }
                            }
                            break;
                        }

                    }
                }

                carrinho.Add(produtoCarrinho);

                double valorItem = produtoCarrinho.Valor * produtoCarrinho.Quantidade;
                string itemTexto = $"{quantidade} x {produtoSelecionado.Descricao} - R$ {valorItem:F2}";

                listBoxCarrinho.Items.Add(itemTexto);
                
                totalPedido += valorItem;
                label5.Text = $"Total: R${totalPedido:F2}";
                label6.Text = "+ R$ " + valorItem.ToString("F2");
                label6.ForeColor = Color.Yellow;

                numericUpDown1.Value = 1;
                listBoxProduto.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantidade = (int)numericUpDown1.Value;

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

                foreach (var item in PersistênciaProduto.listaProdutos)
                {
                    if (item.Descricao == produtoRemovido.Descricao)
                    {
                        item.Quantidade += produtoRemovido.Quantidade;

                        foreach (var estoqueItem in PersistênciaEstoque.listaEstoque)
                        {
                            if (estoqueItem.Produtos.Descricao == item.Descricao)
                            {
                                estoqueItem.quantidade += produtoRemovido.Quantidade;
                                break;
                            }
                        }
                        break;
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
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;

            foreach (var item in PersistênciaProduto.listaProdutos)
            {
                listBoxProduto.Items.Add(item);
            }

            comboBox1.Items.Add("Dinheiro");
            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão de Crédito");
            comboBox1.Items.Add("Cartão de Débito");
            comboBox1.Items.Add("Vale Refeição");
            comboBox1.Items.Add("Vale Alimentação");

            panel1.Visible = false;
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

            bool temChapa = false;

            foreach (Produtos produtos in carrinho)
            {
                if (produtos.IsChapa)
                {
                    temChapa = true;
                    break;
                }
            }
            Pedidos PedidoFeito = new Pedidos(textBoxNome.Text, comboBox1.SelectedItem.ToString(), checkBox1.Checked, carrinho.ToList());

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

            LimparTela();
            TelaBalcao telaBalcao = new TelaBalcao();
            telaBalcao.ShowDialog();
            this.Close();
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
        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Hide();
            TelaBalcao telaBalcao = new TelaBalcao();
            telaBalcao.ShowDialog();
            this.Close();

        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaChamadaStatus telaChamadaStatus = new TelaChamadaStatus();
            telaChamadaStatus.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.ShowDialog();
        }
    }
}