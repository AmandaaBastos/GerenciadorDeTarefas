using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Conections
{
    internal class Conexao
    {
        SqlConnection conexao = new SqlConnection();
        internal Conexao()
        {
            conexao.ConnectionString = @"Data Source=DESKTOP-92EASPI;Initial Catalog=GerenciadorDeTarefas;Integrated Security=True;";
        }
        internal SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        internal void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
