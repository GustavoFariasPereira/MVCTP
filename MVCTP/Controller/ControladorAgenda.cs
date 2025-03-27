using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTP.Model;

namespace MVCTP.Controller
{
    internal class ControladorAgenda
    {
        Agenda agenda = new Agenda();

        public string SalvarContato(string nome, string whatsapp, string email)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(whatsapp) || string.IsNullOrWhiteSpace(email))
            {
                return "Os campos devem ser preenchidos!";
            }
            if (!int.TryParse(whatsapp, out int whatsappValido))
            {
                return "O campo Whatsapp deve ser somente números!";
            }
            Contato contato = new Contato(nome, whatsapp, email);
            agenda.AdicionarContato(contato);
            return "Contato salvo com sucesso!";
        }

        public List<Contato> VerTodosContatos()
        {
            return agenda.VerContatos();
        }
    }
}
