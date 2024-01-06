using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeTarefas.Controllers;
using GerenciadorDeTarefas.Usuarios ;


namespace GerenciadorDeTarefas.Views
{

    public partial class TelaLogin : Form
    {
        
        internal TextBox TxtUsuario { get => txtUsuario; private set => txtUsuario = value; }
        internal TextBox TxtSenha { get => txtSenha; private set => txtSenha = value; }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
        public TelaLogin()
        {
            InitializeComponent();           
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fazerLogin_Click(object sender, EventArgs e)
        {
           
        }    

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void souTechLead_CheckedChanged(object sender, EventArgs e)
        {
                
        }
    }
}
