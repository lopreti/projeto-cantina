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
    public partial class TelaChamadaStatus : Form
    {
        bool menuAberto = false;

        public TelaChamadaStatus()
        {
            InitializeComponent();
        }

        private void TelaChamadaStatus_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            foreach (Pedidos pedido in PersistenciaPedido.pedidosEntregues)
            {
                listBoxProntos.Items.Add($" -> {pedido.nomeCliente}");
            }

            foreach (Pedidos pedido in PersistenciaPedido.pedidosBalcao)
            {
                listBoxPreparando.Items.Add($" -> {pedido.nomeCliente}");
            }

            foreach (Pedidos pedido in PersistenciaPedido.pedidosCozinha)
            {
                listBoxPreparando.Items.Add($" -> {pedido.nomeCliente}");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TelaBalcao telaBalcao = new TelaBalcao();
            telaBalcao.ShowDialog();
            this.Close();
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
    }
}
