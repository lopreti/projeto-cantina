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

        private void AtualizarLista()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(PersistenciaEstoque.listaEstoque.ToArray());
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ProdutosEstoque produtoSelecionado = (ProdutosEstoque)listBox1.SelectedItem;
                label2.Text = produtoSelecionado.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ProdutosEstoque produtoSelecionado = (ProdutosEstoque)listBox1.SelectedItem;

                if (produtoSelecionado.Quantidade > 1)
                {
                    produtoSelecionado.Quantidade -= 1;
                }
                else
                {

                    DialogResult resultado = MessageBox.Show(
                        "Essa ação vai excluir o produto da lista, zerando sua quantidade. Deseja isso?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {

                        PersistenciaEstoque.listaEstoque.Remove(produtoSelecionado);
                        produtoSelecionado.IsAtivo = false;
                        label2.Text = string.Empty;
                        AtualizarLista();
                        return;
                    }
                }
                label2.Text = produtoSelecionado.ToString();
                int Selecionado = listBox1.SelectedIndex;
                AtualizarLista();
                listBox1.SelectedIndex = Selecionado;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ProdutosEstoque produtoSelecionado = (ProdutosEstoque)listBox1.SelectedItem;
                produtoSelecionado.Quantidade += 1;
                label2.Text = produtoSelecionado.ToString();

                int Selecionado = listBox1.SelectedIndex;
                AtualizarLista();
                listBox1.SelectedIndex = Selecionado;
            }
        }
    }
}
    
