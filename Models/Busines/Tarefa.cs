using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Conections;
using GerenciadorDeTarefas.Models.Busines;
using GerenciadorDeTarefas.Usuarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GerenciadorDeTarefas.Models.Busines
{
    internal class Tarefa
    {
        internal int idTarefa;
        internal string titulo, descricao, escopo, status;
        internal DateTime dataCriacao, dataConclusao;
        internal Usuario responsavel;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;


        internal Tarefa() { }

        internal Tarefa ObterTarefa()
        {
            Tarefa tarefa = null;

            cmd.CommandText = "SELECT * FROM tarefas";
            cmd.Parameters.Clear();

            Conexao conexao = new Conexao();
            cmd.Connection = conexao.Conectar();
           
            UsuarioData usuarioData = new UsuarioData();
            List<Usuario> listaUsuarios = usuarioData.ListarUsuarios();

            using (reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    idTarefa = Convert.ToInt32(reader["idTarefa"]);
                    titulo = reader["titulo"].ToString();
                    descricao = reader["descricao"].ToString();
                    escopo = reader["escopo"].ToString();
                    dataCriacao = Convert.ToDateTime(reader["dataCriacao"]);
                    dataConclusao = Convert.ToDateTime(reader["dataConclusao"]);
                    responsavel = usuarioData.SelecionarUsuario(reader["responsavel"].ToString());
                    status = reader["status"].ToString();

                    tarefa = this;
                };
            }
            conexao.Desconectar();

            return tarefa;
        }

        internal int IdTarefa { get { return idTarefa; } }
        internal string Titulo { get { return titulo; } }
        internal string Escopo { get { return escopo; } }
        internal string Descricao { get { return descricao; } }
        internal DateTime DataCriacao { get { return dataCriacao; } }
        internal DateTime DataConclusao
        {
            get { return dataConclusao; }
            set { dataConclusao = DateTime.MinValue; }
        }
        internal Usuario Responsavel { get { return responsavel; } }
        internal string Status { get { return status; } }
       

        
        internal void ConcluirTarefa()
        {
            if (this.status == "EmAndamento")
            {
                this.status = "Concluida";
                this.dataConclusao = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Tarefa não pode ser concluída");
            }
        }
        internal void GerarId()
        {
            TarefaData tarefaData = new TarefaData();
            Random random = new Random();
            int id;
            do
            {                
                id = random.Next(0000000, 9999999);
            } while (!tarefaData.idExiste);
            this.idTarefa = id;
        }      

        //internal void AutoResponsavel(Usuario usuario)
        //{
        //    this._responsavel = usuario;
        //}       
    }
   
}
