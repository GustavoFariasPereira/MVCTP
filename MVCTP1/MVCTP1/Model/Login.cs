using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTP1.Model
{
    internal class Login
    {
        List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario("Gustavo", "1234"),
            new Usuario("Neymar", "Craque")
        };
        public bool LoginValido(Usuario usuario)
        {
            foreach (Usuario outro in usuarios)
            {
                if (usuario.User == outro.User && usuario.Senha == outro.Senha) return true;
            }
            return false;
        }
    }
}
