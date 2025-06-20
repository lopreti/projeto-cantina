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
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.ShowDialog();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaBalcao telaBalcao = new TelaBalcao();
            telaBalcao.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TelaChamadaStatus telaChamadaStatus = new TelaChamadaStatus();
            telaChamadaStatus.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.ShowDialog();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaGestão telaGestão = new TelaGestão();
            telaGestão.ShowDialog();
            this.Hide();
        }
    }
}
