﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantinaa
{
    public partial class TelaCozinha : Form
    {
        private List<Pedidos> listaAuxiliar = new List<Pedidos>();

        private TelaBalcao telaBalcao;

        private bool menuAberto = false;

        public TelaCozinha(TelaBalcao balcao = null)
        {
            InitializeComponent();
            this.telaBalcao = balcao;
        }


        private void Cozinha_Load(object sender, EventArgs e)
        {
            if (Usuario.Adm == true)
            {
                pictureBox2.Visible = true;

            }

            listaAuxiliar.Clear();
            listBox1.Items.Clear();

            foreach (Pedidos pedido in PersistenciaPedido.pedidosCozinha)
            {
                if (pedido.statusPedido == Status.Preparando)
                {
                    List<string> itensFormatados = new List<string>();
                    foreach (Produtos item in pedido.itensPedidos)
                    {
                        if (item.IsChapa)
                        {
                            itensFormatados.Add($"{item.Quantidade}x {item.Descricao}");
                        }
                    }
                    string textoPedido = string.Join(",   ", itensFormatados);
                    listBox1.Items.Add(textoPedido);
                    listaAuxiliar.Add(pedido);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if (indice != -1)
            {
                Pedidos pedidoSelecionado = listaAuxiliar[indice];
                pedidoSelecionado.statusPedido = Status.Pronto;

                PersistenciaPedido.pedidosCozinha.Remove(pedidoSelecionado);
                PersistenciaPedido.pedidosBalcao.Add(pedidoSelecionado);
                GerenciadorDados.SalvarTodosDados();

                listaAuxiliar.RemoveAt(indice);
                listBox1.Items.RemoveAt(indice);
                MessageBox.Show("Pedido entregue para o balcão");

                if (telaBalcao != null)
                {
                    telaBalcao.AtualizarBalcao();
                }


            }
            else
            {
                MessageBox.Show("Selecione o Pedido!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
}
