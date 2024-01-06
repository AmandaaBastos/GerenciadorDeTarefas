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
        internal bool valido = false;
        internal string mensagem = "";
        SqlCommand cmd = new SqlCommand();//para executar os comandos SQL
        SqlDataReader reader;//para ler os dados do banco

        internal bool VerificarLogin(String login, String senha)//Verifica se tem no banco SQL
        {
            cmd.CommandText = "select * from usuarios where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);//testa de o login inserido é igual ao @login (do banco)
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();//executa e guarda a informacao
                if (reader.HasRows)//se tiver linhas
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
        internal String Cadastrar(String email, String senha, String confSenha)//Cadastra no banco SQL
        {
            return mensagem;
        }
        internal bool VerificarCargo (String login,String cargo)
        {
            cmd.CommandText = "select * from usuarios where login = @login and cargo = @cargo";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@cargo", cargo);
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
                this.mensagem = "Erro com a validação do cargo";
            }
            return valido;
        }
       
    }
}
