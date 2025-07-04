﻿using System;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            foreach (Usuario user in PersistenciaUsuarios.listaUsusarios)
            {
               
                if (user.Nome == usuario && user.Senha == senha)
                {
                    if (user.Tipo == "Administrador")
                    {
                        Usuario.Adm = true;
                        MessageBox.Show("Bem-vindo, Administrador!");
                        this.Hide();
                        MenuAdm menuAdm = new MenuAdm();
                        menuAdm.ShowDialog();
                        this.Show();
                        return;
                    }

                    else if (user.Tipo == "Balconista")
                    {
                        MessageBox.Show("Bem-vindo, Balconista!");
                        this.Hide();
                        TelaBalcao telaBalcao = new TelaBalcao();
                        telaBalcao.ShowDialog();
                        this.Show();
                        return;
                    }

                    else if (user.Tipo == "Cozinheiro")
                    {
                        MessageBox.Show("Bem-vindo, Cozinheiro!");
                        this.Hide();
                        TelaCozinha telaCozinha = new TelaCozinha();
                        telaCozinha.ShowDialog();
                        this.Show();
                        return;

                    }

                    else if (user.Tipo == "Chamada")
                    {
                        this.Hide();
                        TelaChamadaStatus telaChamadaStatus = new TelaChamadaStatus();
                        telaChamadaStatus.ShowDialog();
                        this.Show();
                        return;
                    }
                }
            }

            MessageBox.Show("Usuário ou senha incorretos.");

        }
    }
}
