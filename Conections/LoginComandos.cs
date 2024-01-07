using GerenciadorDeTarefas.Usuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Conections
{
    internal class LoginComandos
    {   
        internal bool techLead = false;
        internal bool valido = false;
        internal string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        internal bool VerificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from usuarios where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    valido = true;                  
                }
                
                conexao.Desconectar();
                reader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }
            return valido;
        }
        internal bool VerificarCargo(String login, String senha)
        {
            cmd.CommandText = "select * from usuarios where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader["cargo"].ToString() == "TechLead")
                    {
                        techLead = true;
                    }
                }
                conexao.Desconectar();
                reader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }
            return techLead;
        }   
        internal String Cadastrar(String email, String senha, String confSenha)//Cadastra no banco SQL
        {
            return mensagem;
        }        
       
    }
}
