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
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Pedidos pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.statusPedido == Status.Preparando)
                {
                    List<string> itensFormatados = new List<string>();


                    foreach (Produtos item in pedido.itensPedidos)
                    {
                        itensFormatados.Add($"{pedido.nomeCliente} {item.Quantidade}x {item.Descricao}");
                    }

                    listBox1.Items.AddRange(itensFormatados.ToArray());
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
