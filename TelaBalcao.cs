﻿using System;
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
        bool menuAberto = false;

        public TelaBalcao()
        {
            InitializeComponent();
        }
        public void AtualizarBalcao()
        {
            string viagem = "";
            listBox1.Items.Clear();


            foreach (Pedidos pedido in PersistenciaPedido.pedidosBalcao)
            {
                if (pedido.statusPedido == Status.Pronto)
                {
                    if (pedido.isviagem == true)
                    {
                        viagem = "- Para Viagem";
                    }
                    else
                    {
                        viagem = "";
                    }

                    string dataPedido = pedido.dataPedido.ToString("dd/MM/yyyy HH:mm");
                    string resumo = $"Cliente: {pedido.nomeCliente} -  {dataPedido} {viagem}";
                    listBox1.Items.Add(resumo);

                }
            }

            listBox2.Items.Clear();
            foreach (Pedidos pedido in PersistenciaPedido.pedidosEntregues)
            {
                string dataPedido = pedido.dataPedido.ToString("dd/MM/yyyy HH:mm");
                string resumo = $"Cliente: {pedido.nomeCliente} -  {dataPedido} ";
                listBox2.Items.Add(resumo);

            }
        }

        private void TelaBalcao_Load(object sender, EventArgs e)
        {
            if (Usuario.Adm == true)
            {
                pictureBox2.Visible = true;

            }

            AtualizarBalcao();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pedidoEscolhido = listBox1.SelectedIndex;
            if (pedidoEscolhido >= 0 && pedidoEscolhido < PersistenciaPedido.pedidosBalcao.Count)
            {
                Pedidos pedidoSelecionado = PersistenciaPedido.pedidosBalcao[pedidoEscolhido];

                TelaPedido telapedido = new TelaPedido(pedidoSelecionado, this);
                telapedido.ShowDialog();
            }
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click_1(object sender, EventArgs e)
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
    }
}

