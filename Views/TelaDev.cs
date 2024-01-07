using GerenciadorDeTarefas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using GerenciadorDeTarefas.Conections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

            //this.label1.Text = $"Bem vindo, {nomeCompleto}";
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void TelaDev_Load(object sender, EventArgs e)
        {
            listTarefas.View = View.Details;           
            listTarefas.Columns.Add("ID", 100);
            listTarefas.Columns.Add("Titulo", 300);
            listTarefas.Columns.Add("Responsável", 150);
            listTarefas.Columns.Add("Escopo", 100);
            listTarefas.Columns.Add("Data Criação", 80);
            listTarefas.Columns.Add("Data Entrega", 80);
            Conexao conexao = new Conexao();
            conexao.Conectar();
            // resto do código banco de dados
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TelaCriacaoTarefa telaCriacaoTarefa = new TelaCriacaoTarefa();
            telaCriacaoTarefa.Show();
        }
    }
}
