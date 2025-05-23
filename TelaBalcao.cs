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
    public partial class TelaBalcao : Form
    {
        public TelaBalcao()
        {
            InitializeComponent();
        }
        private void AtualizarBalcao()
        {
            foreach (Pedidos pedido in PersistenciaPedido.pedidos)
            {

                string resumo = $"{pedido.nomeCliente}: ";
                List<string> itensFormatados = new List<string>();

                foreach (Produtos item in pedido.itensPedidos)
                {
                    itensFormatados.Add($"{item.Quantidade}x {item.Descricao}");
                }

                resumo += string.Join(", ", itensFormatados);
                listBox1.Items.Add(resumo);
            }
        }

        private void TelaBalcao_Load(object sender, EventArgs e)
        {
            AtualizarBalcao();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(PersistenciaPedido.pedidos);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
