using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Cantinaa
{
    internal static class GerenciadorDados
    {
        private static readonly string pastaApp = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "SistemaCantina"
        );

        private static readonly string arquivoPedidos = Path.Combine(pastaApp, "pedidos.json");
        private static readonly string arquivoEstoque = Path.Combine(pastaApp, "estoque.json");
        private static readonly string arquivoProdutos = Path.Combine(pastaApp, "produtos.json");

        static GerenciadorDados()
        {
            // Cria a pasta se não existir
            if (!Directory.Exists(pastaApp))
                Directory.CreateDirectory(pastaApp);
        }

        #region SALVAR DADOS
        public static void SalvarTodosDados()
        {
            SalvarPedidos();
            SalvarEstoque();
            SalvarProdutos();
        }

        private static void SalvarPedidos()
        {
            try
            {
                var todosPedidos = new
                {
                    PedidosCozinha = PersistenciaPedido.pedidosCozinha,
                    PedidosBalcao = PersistenciaPedido.pedidosBalcao,
                    PedidosEntregues = PersistenciaPedido.pedidosEntregues
                };

                string json = JsonConvert.SerializeObject(todosPedidos, Formatting.Indented);
                File.WriteAllText(arquivoPedidos, json);
            }
            catch (Exception ex)
            {
                // Se der erro, só ignora - não quebra o programa
                Console.WriteLine($"Erro ao salvar pedidos: {ex.Message}");
            }
        }

        private static void SalvarEstoque()
        {
            try
            {
                string json = JsonConvert.SerializeObject(PersistênciaEstoque.listaEstoque, Formatting.Indented);
                File.WriteAllText(arquivoEstoque, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar estoque: {ex.Message}");
            }
        }

        private static void SalvarProdutos()
        {
            try
            {
                string json = JsonConvert.SerializeObject(PersistênciaProduto.listaProdutos, Formatting.Indented);
                File.WriteAllText(arquivoProdutos, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar produtos: {ex.Message}");
            }
        }
        #endregion

        #region CARREGAR DADOS
        public static void CarregarTodosDados()
        {
            CarregarProdutos();
            CarregarEstoque();
            CarregarPedidos();
        }

        private static void CarregarPedidos()
        {
            try
            {
                if (File.Exists(arquivoPedidos))
                {
                    string json = File.ReadAllText(arquivoPedidos);
                    var dados = JsonConvert.DeserializeObject<dynamic>(json);

                    if (dados?.PedidosCozinha != null)
                        PersistenciaPedido.pedidosCozinha = JsonConvert.DeserializeObject<List<Pedidos>>(dados.PedidosCozinha.ToString());

                    if (dados?.PedidosBalcao != null)
                        PersistenciaPedido.pedidosBalcao = JsonConvert.DeserializeObject<List<Pedidos>>(dados.PedidosBalcao.ToString());

                    if (dados?.PedidosEntregues != null)
                        PersistenciaPedido.pedidosEntregues = JsonConvert.DeserializeObject<List<Pedidos>>(dados.PedidosEntregues.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar pedidos: {ex.Message}");
                // Se der erro, inicializa listas vazias
                PersistenciaPedido.pedidosCozinha = new List<Pedidos>();
                PersistenciaPedido.pedidosBalcao = new List<Pedidos>();
                PersistenciaPedido.pedidosEntregues = new List<Pedidos>();
            }
        }

        private static void CarregarEstoque()
        {
            try
            {
                if (File.Exists(arquivoEstoque))
                {
                    string json = File.ReadAllText(arquivoEstoque);
                    PersistênciaEstoque.listaEstoque = JsonConvert.DeserializeObject<List<Estoque>>(json) ?? new List<Estoque>();
                }
                else
                {
                    // Se não existe arquivo, inicializa com dados padrão
                    PersistênciaEstoque.IniciarEstoque();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar estoque: {ex.Message}");
                PersistênciaEstoque.IniciarEstoque();
            }
        }

        private static void CarregarProdutos()
        {
            try
            {
                if (File.Exists(arquivoProdutos))
                {
                    string json = File.ReadAllText(arquivoProdutos);
                    var produtosCarregados = JsonConvert.DeserializeObject<List<Produtos>>(json);
                    if (produtosCarregados != null && produtosCarregados.Count > 0)
                    {
                        PersistênciaProduto.listaProdutos = produtosCarregados;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar produtos: {ex.Message}");
                // Se der erro, mantém a lista padrão que já existe
            }
        }
        #endregion
    }
}