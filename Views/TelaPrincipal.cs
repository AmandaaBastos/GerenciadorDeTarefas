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
using System.Data.SqlClient;

namespace GerenciadorDeTarefas.Views
{
    public partial class TelaPrincipal : Form
    {
        internal TelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Application.Exit();
        }
    }
}
