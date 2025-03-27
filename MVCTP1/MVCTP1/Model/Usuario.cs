using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTP1.Model
{
    internal class Usuario
    {
        public string User { get; set; }
        public string Senha { get; set; }

        public Usuario(string User, string Senha)
        {
            this.User = User;
            this.Senha = Senha;
        }
    }
}
