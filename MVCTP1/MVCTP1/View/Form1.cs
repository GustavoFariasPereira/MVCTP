using MVCTP1.Controller;
using MVCTP1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCTP1
{
    public partial class Form1 : Form
    {
        LoginValido validaLogin = new LoginValido();
        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrar_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtLogin.Text, txtSenha.Text);
            string mensagem = validaLogin.ValidarLogin(usuario);
            MessageBox.Show(mensagem);
        }
    }
}
