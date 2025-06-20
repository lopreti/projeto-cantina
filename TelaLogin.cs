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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            foreach (Usuario user in PersistenciaUsuarios.listaUsusarios)
            {
                if (user.Nome == usuario && user.Senha == senha)
                {
                    if (user.Tipo == "Administrador")
                    {
                        MessageBox.Show("Bem-vindo, Administrador!");

                    }

                    else if (user.Tipo == "Balconista")
                    {
                        MessageBox.Show("Bem-vindo, Balconista!");
                        TelaBalcao telaBalcao = new TelaBalcao();
                        telaBalcao.Show();
                    }

                    else if (user.Tipo == "Cozinha")
                    {
                        MessageBox.Show("Bem-vindo, Cozinha!");
                        
                    }
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Usuário ou senha incorretos.");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
