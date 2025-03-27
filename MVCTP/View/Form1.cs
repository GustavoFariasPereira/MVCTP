using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCTP.Controller;
using MVCTP.Model;

namespace MVCTP
{
    public partial class Form1 : Form
    {
        ControladorAgenda controlador = new ControladorAgenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string msg = controlador.SalvarContato(txtNome.Text, txtWhatsapp.Text, txtEmail.Text);
            MessageBox.Show(msg);
            if (msg == "Contato salvo com sucesso!")
            {
                Atualizar();
            }
        }

        private void Atualizar()
        {
            dgvContatos.DataSource = null;
            dgvContatos.DataSource = controlador.VerTodosContatos();
            dgvContatos.Height += 22;
            dgvContatos.Visible = true;
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

    }
}
