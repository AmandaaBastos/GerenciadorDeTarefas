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

            this.label2.Text = $"Olá, {nomeCompleto}";
        }   

        private void TelaTech_Load(object sender, EventArgs e)
        {           
            CarregarDadosListView(listTodasTarefas, "Select * From tarefas");
            CarregarDadosListView(listTarefasAtraso, "select * from tarefas where status = 'Em Atraso'");
            CarregarDadosListView(listTarefaAnalise, "select * from tarefas where status = 'Em Análise'");
            CarregarDadosListView(listTarefaConcluida, "select * from tarefas where status = 'Concluída'");
            CarregarDadosListView(listTarefaImpedimento, "select * from tarefas where status = 'Com Impedimento'");
            CarregarDadosListView(listTarefaAbandonada, "select * from tarefas where status = 'Abandonada'");
            

        }    

        private void label1_Click(object sender, EventArgs e)
        {
            TelaCriacaoTarefa telaCriacaoTarefa = new TelaCriacaoTarefa();
            telaCriacaoTarefa.Show();
        }

        private void CarregarDadosListView(System.Windows.Forms.ListView listView, string query)
        {
            listView.View = View.Details;
            listView.Columns.Add("ID", 100);
            listView.Columns.Add("Titulo", 300);
            listView.Columns.Add("Responsável", 150);
            listView.Columns.Add("Escopo", 100);
            listView.Columns.Add("Data Criação", 80);
            listView.Columns.Add("Data Conclusão", 80);
            listView.Columns.Add("Status", 100);
            listView.Columns.Add("Observação", 200);

            Conexao conexao = new Conexao();
            conexao.Conectar();
            SqlCommand cmd = new SqlCommand(query, conexao.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["idTarefa"].ToString());
                item.SubItems.Add(reader["titulo"].ToString());
                item.SubItems.Add(reader["responsavel"].ToString());
                item.SubItems.Add(reader["escopo"].ToString());
                item.SubItems.Add(reader["dataCriacao"].ToString());
                item.SubItems.Add(reader["dataConclusao"].ToString());
                item.SubItems.Add(reader["status"].ToString());
                item.SubItems.Add(reader["observacao"].ToString());
                listView.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
