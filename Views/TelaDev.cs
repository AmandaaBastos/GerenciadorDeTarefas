using GerenciadorDeTarefas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GerenciadorDeTarefas.Views
{
    public partial class TelaDev : Form
    {
        public TelaDev(string TxtUsuario, string TxtSenha)
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            Usuario usuarioAutenticado = usuario.ObterUsuario(TxtUsuario, TxtSenha);
            string login = usuarioAutenticado.Login;
            string nomeCompleto = usuarioAutenticado.NomeCompleto;
            string cpf = usuarioAutenticado.Cpf;
            string email = usuarioAutenticado.Email;
            string cargo = usuarioAutenticado.Cargo;

            this.label1.Text = $"Bem vindo {nomeCompleto}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
