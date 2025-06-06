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
        public TelaChamadaStatus()
        {
            InitializeComponent();
        }

        private void TelaChamadaStatus_Load(object sender, EventArgs e)
        {

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
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
