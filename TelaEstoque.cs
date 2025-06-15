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
            }
            AtualizarLista();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;
                label2.Text = produtoSelecionado.ToString();
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

                label2.Text = produtoSelecionado.ToString();
                int Selecionado = listBox1.SelectedIndex;
                AtualizarLista();
                listBox1.SelectedIndex = Selecionado;
                numericUpDown1.Value = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int quantidadeEscolhida = (int)numericUpDown1.Value;

                Estoque produtoSelecionado = (Estoque)listBox1.SelectedItem;
                produtoSelecionado.AdicionarQuantidade(quantidadeEscolhida);
                label2.Text = produtoSelecionado.ToString();

                int Selecionado = listBox1.SelectedIndex;
                AtualizarLista();
                listBox1.SelectedIndex = Selecionado;
                numericUpDown1.Value = 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaGestão telaGestão = new TelaGestão();
            telaGestão.ShowDialog();
            this.Close();
        }
    }
}
    
