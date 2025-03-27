using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTP.Model
{
    internal class Agenda
    {
        List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }
        
        public List<Contato> VerContatos()
        {
            return contatos;
        }
    }
}
