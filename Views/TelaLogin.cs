using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeTarefas.Conections;
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

        private void fazerLogin_Click(object sender, EventArgs e)
        {           
            Controle controle = new Controle();           
            controle.Acessar(TxtUsuario.Text, TxtSenha.Text);
            controle.VerificarCargo(TxtUsuario.Text, TxtSenha.Text);
            if(controle.mensagem == "" )
            {              
                if (controle.valido)
                {                    
                    if(controle.techLead)
                    {
                        TelaTech telaTech = new TelaTech(TxtUsuario.Text);
                        telaTech.Show();               
                        MessageBox.Show("TechLead logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        TelaDev telaDesenvolvedor = new TelaDev(TxtUsuario.Text);
                        telaDesenvolvedor.Show();                       
                        MessageBox.Show("Desenvolvedor logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }           

        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
