using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class PersistênciaProduto
    {
       public static List<Produtos> listaProdutos = new List<Produtos>() 
        {
            new Produtos("Pão de Queijo", 3.50, 1, false),
            new Produtos("Coxinha", 5.00, 1, false),
            new Produtos("Pastel de Carne", 6.00, 1, true),
            new Produtos("Pastel de Queijo", 5.50, 1, true),
            new Produtos("Suco Natural (300ml)", 4.00, 1, false),
            new Produtos("Refrigerante Lata", 4.50, 1, false),
            new Produtos("Hambúrguer Simples", 8.00, 1, true),
            new Produtos("Hambúrguer com Queijo", 9.00, 1, true),
            new Produtos("X-Tudo", 12.00, 1, true),
            new Produtos("Água Mineral (500ml)", 2.50, 1, false)
        };
    }
}
