using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantinaa
{
    public partial class TelaEstoque : Form
    {
        private bool menuAberto = false;

        public TelaEstoque()
        {
            InitializeComponent();
        }

        public void AtualizarLista()
        {
            listBox1.Items.Clear();
            foreach (var produto in PersistênciaEstoque.listaEstoque)
            {
                listBox1.Items.Add(produto);
            }
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {

            if (PersistênciaEstoque.listaEstoque.Count == 0)
            {
                PersistênciaEstoque.IniciarEstoque();
                GerenciadorDados.SalvarTodosDados();
            }
            AtualizarLista();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;
                label2.Text = $"{produtoSelecionado.Produtos.Descricao} - Quant: {produtoSelecionado.quantidade}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int quantidadeEscolhida = (int)numericUpDown1.Value;
                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;

                if (quantidadeEscolhida > produtoSelecionado.quantidade)
                {
                    MessageBox.Show("Você não pode remover mais do que tem em estoque!");
                    return;
                }

                produtoSelecionado.RemoverQuantidade(quantidadeEscolhida);
                GerenciadorDados.SalvarTodosDados();

                label2.Text = produtoSelecionado.ToString();
                int Selecionado = listBox1.SelectedIndex;
                AtualizarLista();
                listBox1.SelectedIndex = Selecionado;
                numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("Selecione um produto!");
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int quantidadeEscolhida = (int)numericUpDown1.Value;

                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;
                produtoSelecionado.AdicionarQuantidade(quantidadeEscolhida);
                GerenciadorDados.SalvarTodosDados();

                label2.Text = produtoSelecionado.ToString();

                int Selecionado = listBox1.SelectedIndex;
                AtualizarLista();
                listBox1.SelectedIndex = Selecionado;
                numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("Selecione um produto!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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
    }
}
    
