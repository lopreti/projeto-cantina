using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantinaa
{
    public partial class TelaPedido : Form
    {
        private Pedidos pedido;
        private TelaBalcao tela;
        internal TelaPedido(Pedidos pedidoSelecionado, TelaBalcao telaBalcao)
        {
            InitializeComponent();
            pedido = pedidoSelecionado;
            tela = telaBalcao;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TelaPedido_Load(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            List<string> itensFormatados = new List<string>();


            foreach (Produtos item in pedido.itensPedidos)
            {
                itensFormatados.Add($"{item.Quantidade}x {item.Descricao}");

            }

            label1.Text = pedido.nomeCliente;


            listBox1.Items.AddRange(itensFormatados.ToArray());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (PersistenciaPedido.pedidos.Contains(pedido))
            {
                PersistenciaPedido.pedidosEntregues.Insert(0, pedido);

                if (PersistenciaPedido.pedidosEntregues.Count > 5)
                {
                    PersistenciaPedido.pedidosEntregues.RemoveAt(5);
                }

                PersistenciaPedido.pedidos.Remove(pedido);
                tela.AtualizarBalcao();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
