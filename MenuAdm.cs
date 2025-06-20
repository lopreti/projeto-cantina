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
        private TelaBalcao telabalcao;

        public MenuAdm()
        {
            InitializeComponent();
            telabalcao = new TelaBalcao();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVendas telaVendas = new TelaVendas();
            telaVendas.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telabalcao.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCozinha telaCozinha = new TelaCozinha(telabalcao);
            telaCozinha.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaChamadaStatus telaChamadaStatus = new TelaChamadaStatus();
            telaChamadaStatus.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGestão telaGestão = new TelaGestão();
            telaGestão.ShowDialog();
            this.Show();
        }

        private void MenuAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
