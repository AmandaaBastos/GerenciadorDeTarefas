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
using GerenciadorDeTarefas.Models.Busines;


namespace GerenciadorDeTarefas.Views
{
    public partial class TelaTech : Form
    {
        public TelaTech(string TxtUsuario)
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            Usuario usuarioAutenticado = usuario.ObterUsuario(TxtUsuario);
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



        private void TelaTech_Load(object sender, EventArgs e)
        {
            listTarefas.View = View.Details;
            listTarefas.Columns.Add("ID", 100);
            listTarefas.Columns.Add("Titulo", 300);
            listTarefas.Columns.Add("Responsável", 150);
            listTarefas.Columns.Add("Escopo", 100);
            listTarefas.Columns.Add("Data Criação", 80);
            listTarefas.Columns.Add("Data Conclusão", 80);
            listTarefas.Columns.Add("Status", 100);

            Conexao conexao = new Conexao();
            conexao.Conectar();
            SqlCommand cmd = new SqlCommand("Select * From tarefas", conexao.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["idTarefa"].ToString());
                item.SubItems.Add(reader["titulo"].ToString());
                item.SubItems.Add(reader["responsavel"].ToString());
                item.SubItems.Add(reader["escopo"].ToString());
                item.SubItems.Add(reader["dataCriacao"].ToString());
                item.SubItems.Add(reader["dataConclusao"].ToString());
                item.SubItems.Add(reader["status"].ToString());
                listTarefas.Items.Add(item);
            }

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
