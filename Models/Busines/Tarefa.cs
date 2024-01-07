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
        public int _idTarefa;
        private string _titulo, _descricao, _escopo, _status;
        private DateTime _dataCriacao, _dataConclusao;
        private Usuario _responsavel;             
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;


        internal Tarefa() { }

        internal Tarefa ObterTarefa (int idTarefa, string titulo, string descricao, string escopo, Usuario responsavel)
        {
            Tarefa tarefa = null;

            cmd.CommandText = "SELECT * FROM tarefas WHERE idTarefa = @idTarefa";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idTarefa", idTarefa);

            Conexao conexao = new Conexao();
            cmd.Connection = conexao.Conectar();

            using (reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();

                    tarefa = new Tarefa
                    {
                        _idTarefa = Convert.ToInt32(reader["idTarefa"]),
                        _titulo = reader["titulo"].ToString(),
                        _descricao = reader["descricao"].ToString(),
                        _escopo = reader["escopo"].ToString(),
                        _dataCriacao = Convert.ToDateTime(reader["dataCriacao"]),
                        _dataConclusao = Convert.ToDateTime(reader["dataConclusao"]),
                        _responsavel = UsuarioData.SelecionarUsuario(reader["responsavel"].ToString()),
                        _status = reader["status"].ToString()                                              
                    };

                };
            }       
            conexao.Desconectar();

            return tarefa;
        }

        internal int IdTarefa { get { return _idTarefa; } }
        internal string Titulo { get { return _titulo; } }
        internal string Escopo { get { return _escopo; } }
        internal string Descricao { get { return _descricao; } }
        internal DateTime DataDeCriacao { get { return _dataCriacao; } }
        internal DateTime DataDeConclusao
        {
            get { return _dataConclusao; }
            set { _dataConclusao = value; }
        }
        internal Usuario Responsavel { get { return _responsavel; } }
        internal bool Impedimento { get { return _impedimento; } }

        public StatusTarefa Status
        {
            get { return _status; }
            set { _status = value; }
        }
        internal void ConcluirTarefa()
        {
            if (this._status == StatusTarefa.EmAndamento)
            {
                this._status = StatusTarefa.Concluida;
                this._dataConclusao = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Tarefa não pode ser concluída");
            }
        }
        internal void AtribuirResponsavel(Usuario usuario)
        {
            _responsavel = usuario;
        }
    }


        //internal bool DefinirImpedimento(bool impedimento)
        //{
        //    this._impedimento = impedimento;
        //    return true;
        //}
        //internal bool AlterarTitulo(string titulo)
        //{
        //    if (titulo.Length > 0)
        //    {
        //        this._titulo = titulo;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarEscopo(string escopo)
        //{
        //    if (escopo.Length > 0)
        //    {
        //        this._escopo = escopo;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarDescricao(string descricao)
        //{
        //    if (descricao.Length > 0)
        //    {
        //        this._descricao = descricao;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarResponsavel(Usuario responsavel)
        //{
        //    if (responsavel != null)
        //    {
        //        this._responsavel = responsavel;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarStatus(StatusTarefa status)
        //{
        //    this._status = status;
        //    return true;
        //}
        //internal bool AlterarDataDeConclusao(DateTime dataDeConclusao)
        //{
        //    if (dataDeConclusao != null)
        //    {
        //        this._dataDeConclusao = dataDeConclusao;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarDataDeCriacao(DateTime dataDeCriacao)
        //{
        //    if (dataDeCriacao != null)
        //    {
        //        this._dataDeCriacao = dataDeCriacao;
        //        return true;
        //    }
        //    return false;
        //}



    }
}
