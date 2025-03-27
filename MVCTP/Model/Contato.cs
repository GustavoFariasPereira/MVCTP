using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTP.Model
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string whatsapp, string email)
        {
            Nome = nome;
            Whatsapp = whatsapp;
            Email = email;
        }
    }
}
