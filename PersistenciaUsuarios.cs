using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class PersistenciaUsuarios
    {
        public static List<Usuario> listaUsusarios { get; set; } = new List<Usuario>()
        {
            new Usuario("admin", "admin", "Administrador"),
            new Usuario("balcao", "balcao", "Balconista"),
            new Usuario("cozinha", "cozinha", "Cozinheiro")
        };
    }
}
