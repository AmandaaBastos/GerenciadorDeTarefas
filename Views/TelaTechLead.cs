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

namespace GerenciadorDeTarefas.Views
{
    public partial class TelaTechLead : Form
    {
        public TelaTechLead (string TxtUsuario, string TxtSenha)
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            Usuario usuarioAutenticado = usuario.ObterUsuario(TxtUsuario, TxtSenha);
            string login = usuarioAutenticado.Login;
            string nomeCompleto = usuarioAutenticado.NomeCompleto;
            string cpf = usuarioAutenticado.Cpf;
            string email = usuarioAutenticado.Email;
            string cargo = usuarioAutenticado.Cargo;
           
        }
    }
}
