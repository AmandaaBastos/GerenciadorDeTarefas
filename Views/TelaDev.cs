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
    public partial class TelaDev : Form
    {
        public TelaDev (string TxtUsuario)
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            Usuario usuarioAutenticado = usuario.ObterUsuario(TxtUsuario);
            string login = usuarioAutenticado.Login;
            string nomeCompleto = usuarioAutenticado.NomeCompleto;
            string cpf = usuarioAutenticado.Cpf;
            string email = usuarioAutenticado.Email;
            string cargo = usuarioAutenticado.Cargo;
           
        }
    }
}
