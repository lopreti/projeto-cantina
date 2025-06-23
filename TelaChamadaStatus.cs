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
        private bool menuAberto = false;

        public TelaChamadaStatus()
        {
            InitializeComponent();
        }

        private void TelaChamadaStatus_Load(object sender, EventArgs e)
        {
            if (Usuario.Adm == true)
            {
                pictureBox1.Visible = true;

            }

            foreach (Pedidos pedido in PersistenciaPedido.pedidosEntregues)
            {
                if (pedido.statusPedido != Status.Exibido)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBoxProntos.Items.Count > 0)
            {
                int ultimoNome = listBoxProntos.Items.Count - 1;
                listBoxProntos.Items.RemoveAt(ultimoNome);

                foreach (Pedidos pedidos in PersistenciaPedido.pedidosEntregues)
                {
                    pedidos.statusPedido = Status.Exibido;
                }

                GerenciadorDados.SalvarTodosDados();
            }
            else
            {
                timer1.Stop();
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

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaChamadaStatus_Activated(object sender, EventArgs e)
        {
          
        }
    }
}
