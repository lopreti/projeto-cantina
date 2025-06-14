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
           
        }
    }
}

    
