using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantinaa
{
    public partial class TelaGestão : Form
    {
        public TelaGestão()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            listBox1.Items.Clear();
            foreach (var produto in PersistênciaEstoque.listaEstoque)
            {
                listBox1.Items.Add(produto);
            }
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }


        private void TelaGestão_Load(object sender, EventArgs e)
        {
            if (PersistênciaEstoque.listaEstoque.Count == 0)
            {
                PersistênciaEstoque.IniciarEstoque();
            }
            AtualizarLista();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;
                textBox1.Text = produtoSelecionado.Produtos.Descricao.ToString();
                textBox3.Text = "R$ " + produtoSelecionado.Produtos.Valor.ToString();

                if (produtoSelecionado.Produtos.IsChapa == true)
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox2.Checked = true;
                    checkBox1.Checked = false;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;
                PersistênciaEstoque.listaEstoque.Remove(produtoSelecionado);
                PersistênciaProduto.listaProdutos.Remove(produtoSelecionado.Produtos);
                AtualizarLista();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um produto para deletar!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            foreach (var produto in PersistênciaProduto.listaProdutos)
            {
                if (produto.Descricao == textBox1.Text)
                {
                    MessageBox.Show("Produto já cadastrado!");
                    LimparCampos();
                    return;
                }
            }

            Produtos Produto = new Produtos();
            Produto.Descricao = textBox1.Text;


            if (checkBox1.Checked)
            {
                Produto.IsChapa = true;
            }

            else
            {
                Produto.IsChapa = false;
            }

            if (double.TryParse(textBox3.Text.Replace("R$ ", ""), out double valor))
            {
                Produto.Valor = valor;
            }
            else
            {
                MessageBox.Show("Valor inválido!");
                return;
            }

            Estoque estoqueNovo = new Estoque
            {
                Produtos = Produto,
                quantidade = 0
            };

            PersistênciaEstoque.listaEstoque.Add(estoqueNovo);
            PersistênciaProduto.listaProdutos.Add(Produto);

            AtualizarLista();
            MessageBox.Show("Produto criado com sucesso!");
            LimparCampos();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                int indexSelecionado = listBox1.SelectedIndex;

                Estoque itemAnterior = PersistênciaEstoque.listaEstoque[indexSelecionado];

                Produtos Produto = new Produtos();
                Produto.Descricao = textBox1.Text;

                if (checkBox1.Checked)
                {
                    Produto.IsChapa = true;
                }

                else
                {
                    Produto.IsChapa = false;
                }

                if (double.TryParse(textBox3.Text.Replace("R$ ", ""), out double valor))
                {
                    Produto.Valor = valor;
                }

                else
                {
                    MessageBox.Show("Valor inválido!");
                    return;
                }

                Estoque estoqueNovo = new Estoque
                {
                    Produtos = Produto,
                    quantidade = itemAnterior.quantidade

                };

                foreach (var produto in PersistênciaProduto.listaProdutos)
                {
                    if (produto.Descricao == textBox1.Text && produto != itemAnterior.Produtos)
                    {
                        MessageBox.Show("Produto com esse nome já cadastrado!");
                        return;
                    }
                }
                
                PersistênciaEstoque.listaEstoque[indexSelecionado] = estoqueNovo;

                PersistênciaProduto.listaProdutos.Remove(itemAnterior.Produtos);
                PersistênciaProduto.listaProdutos.Add(Produto);

                AtualizarLista();
                MessageBox.Show("Produto editado com sucesso!");
                listBox1.SelectedIndex = indexSelecionado;
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar!");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}

    
