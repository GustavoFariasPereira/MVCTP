using MVCTP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTP1.Controller
{
    internal class LoginValido
    {
        Login login = new Login();

        public string ValidarLogin(Usuario usuario)
        {
            if (!login.LoginValido(usuario)) return "Usuario ou Senha incorreto!";
            else return "Conectado ...";
        }

    }
}
