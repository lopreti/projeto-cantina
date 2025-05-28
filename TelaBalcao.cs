using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantinaa
{
    public partial class TelaBalcao : Form
    {
        public TelaBalcao()
        {
            InitializeComponent();
        }
        public void AtualizarBalcao()
        {
            string viagem = "";
            listBox1.Items.Clear();
            bool chapaa = false;

            foreach (Pedidos pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.isviagem == true)
                {
                    viagem = "- Para Viagem";
                }
                else
                {
                    viagem = "";
                }

                string dataPedido = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string resumo = $"Cliente: {pedido.nomeCliente} -  {dataPedido} {viagem}";
                listBox1.Items.Add(resumo);
            }

            listBox2.Items.Clear();
            foreach (Pedidos pedido in PersistenciaPedido.pedidosEntregues)
            {
                string dataPedido = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string resumo = $"Cliente: {pedido.nomeCliente} -  {dataPedido} {viagem} ";
                listBox2.Items.Add(resumo);
            }
        }

        private void TelaBalcao_Load(object sender, EventArgs e)
        {
            AtualizarBalcao();

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pedidoEscolhido = listBox1.SelectedIndex;
            if (pedidoEscolhido >= 0 && pedidoEscolhido < PersistenciaPedido.pedidos.Count)
            {
                Pedidos pedidoSelecionado = PersistenciaPedido.pedidos[pedidoEscolhido];

                TelaPedido telapedido = new TelaPedido(pedidoSelecionado, this);
                telapedido.Show();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
