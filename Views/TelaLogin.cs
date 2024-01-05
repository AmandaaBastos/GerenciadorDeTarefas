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
        private TelaInicialController controller;

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
            this.controller = new TelaInicialController(this);
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fazerLogin_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = txtUsuario.Text;

            if (controller.Autenticar(txtUsuario.Text, txtSenha.Text))
            {
                this.Hide();
                TelaPrincipal telaPrincipal = new TelaPrincipal(UsuarioData.SelecionarUsuario(usuarioDigitado));
                telaPrincipal.ShowDialog();
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
