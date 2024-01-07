using GerenciadorDeTarefas.Conections;
using GerenciadorDeTarefas.Usuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Models.Busines
{
    internal class TarefaData
    {
        internal List<Tarefa> listaTarefas;
        internal bool idExiste;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        private UsuarioData usuarioData; // Mantenha uma instância única de UsuarioData

        internal TarefaData()
        {
            usuarioData = new UsuarioData();
        }
        internal List<Tarefa> ListarTarefas()
        {
            listaTarefas = new List<Tarefa>();
            UsuarioData usuarioData = new UsuarioData();
            List<Usuario> listaUsuarios = usuarioData.ListarUsuarios();

            cmd.CommandText = "SELECT * FROM tarefas";
            Conexao conexao = new Conexao();
            cmd.Connection = conexao.Conectar();

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Tarefa tarefa = new Tarefa
                    {
                        idTarefa = Convert.ToInt32(reader["idTarefa"]),
                        titulo = reader["titulo"].ToString(),
                        descricao = reader["descricao"].ToString(),
                        escopo = reader["escopo"].ToString(),
                        dataCriacao = Convert.ToDateTime(reader["dataCriacao"]),
                        dataConclusao = Convert.ToDateTime(reader["dataConclusao"]),
                        responsavel = usuarioData.SelecionarUsuario(reader["responsavel"].ToString()),
                        status = reader["status"].ToString()
                    };

                    listaTarefas.Add(tarefa);
                }
            }

            conexao.Desconectar();

            return listaTarefas;
        }
        internal List<Tarefa> ListarTarefas(string status)
        {
            foreach (Tarefa tarefa in listaTarefas)
            {
                if (tarefa.Status == status)
                {
                    listaTarefas.Add(tarefa);
                }
            }
            return listaTarefas;
        }
        internal List<Tarefa> ListarTarefas(Usuario responsavel, string escopo)
        {
            foreach (Tarefa tarefa in listaTarefas)
            {
                if (tarefa.Responsavel == responsavel || tarefa.Escopo == escopo)
                {
                    listaTarefas.Add(tarefa);
                }
            }
            return listaTarefas;
        }
        internal bool IdExiste(int idTarefa)
        {
            idExiste = listaTarefas.Select(tarefa => tarefa.IdTarefa).Contains(idTarefa);
            return idExiste;
        }

        internal Tarefa SelecionarTarefa (int idTarefa)
        {
            foreach (Tarefa tarefa in listaTarefas)
            {
                if (tarefa.IdTarefa == idTarefa)
                {
                    return tarefa;
                }
            }
            return null;
        }
        
    }
}
