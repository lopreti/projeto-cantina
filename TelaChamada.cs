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
    public partial class TelaChamada : Form
    {
        public TelaChamada(string nomeCliente)
        {
            InitializeComponent();
            label1.Text = nomeCliente;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TelaChamada_Load(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            string nome = label1.Text;
            if (nome.Length > 10)
            {
                nome = nome.Substring(0, 15) + "...";
            }
            label1.Text = nome;
        }

    }
}
