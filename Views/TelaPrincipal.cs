using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Usuarios;
using System.Windows.Forms;

namespace GerenciadorDeTarefas.Views
{
    public partial class TelaPrincipal : Form
    {
        internal TelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
        }
    }
}
