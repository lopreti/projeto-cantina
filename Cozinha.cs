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

        private void Cozinha_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Pedidos pedido in PersistenciaPedido.pedidosCozinha)
            {
                TextBox txtPedido = new TextBox();
                txtPedido.Multiline = true;
                txtPedido.ReadOnly = true;
                txtPedido.Width = 200;
                txtPedido.Height = 125;
                txtPedido.ScrollBars = ScrollBars.Vertical;

                if (pedido.statusPedido == Status.Preparando)
                {
                    List<string> itensFormatados = new List<string>();


                    foreach (Produtos item in pedido.itensPedidos)
                    {
                        if (item.IsChapa)
                        {
                            itensFormatados.Add($"{item.Quantidade}x {item.Descricao}");
                        }
                    }

                 txtPedido.Text = string.Join("\r\n", itensFormatados);
                 flowLayoutPanel1.Controls.Add(txtPedido);
                 flowLayoutPanel1.AutoScroll = true;
                }
            }
        }
    }
}
