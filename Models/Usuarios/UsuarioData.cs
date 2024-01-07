using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeTarefas.Conections;
using GerenciadorDeTarefas.Models.Busines;
using GerenciadorDeTarefas.Usuarios.Cargos;

namespace GerenciadorDeTarefas.Usuarios
{
    internal class UsuarioData
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        internal List<Usuario> listaUsuarios;

        internal List<Usuario> ListarUsuarios()
        {
            listaUsuarios = new List<Usuario>();

            Conexao conexao = new Conexao();
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM usuarios";

            reader = cmd.ExecuteReader();

            while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        login = reader["login"].ToString(),
                        senha = reader["senha"].ToString(),
                        nomeCompleto = reader["nomeCompleto"].ToString(),
                        cpf = reader["cpf"].ToString(),
                        email = reader["email"].ToString(),
                        cargo = reader["cargo"].ToString()
                    };

                    listaUsuarios.Add(usuario);
                }
            
            conexao.Desconectar();

            return listaUsuarios;
        }


        internal Usuario SelecionarUsuario(string login)
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Login == login)
                {
                    return usuario;
                }
            }
            return null;
        }

        














        //internal static List<Usuario> LerUsuariosTxt(string _FILE_PATH, int tipoUsuario)
        //{
        //    List<Usuario> listaUsuarios = new List<Usuario>();
        //    MessageBox.Show("2");
        //    try
        //    {
        //        if (File.Exists(_FILE_PATH))
        //        {

        //            using (StreamReader sr = new StreamReader(_FILE_PATH))
        //            {
        //                while (!sr.EndOfStream)
        //                {
        //                    string linha = sr.ReadLine();
        //                    if (tipoUsuario == 0)
        //                    {
        //                        Desenvolvedor desenvolvedor = ConverterLinhaParaDesenvolvedor(linha);
        //                        listaUsuarios.Add(desenvolvedor);
        //                    }
        //                    else if (tipoUsuario == 1)
        //                    {
        //                        TechLead techLead = ConverterLinhaParaTechLead(linha);
        //                        listaUsuarios.Add(techLead);
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("O arquivo txt não existe.");
        //        }
        //    }
        //    catch (IOException e)
        //    {
        //        MessageBox.Show("O arquivo não pôde ser aberto: " + e.Message);
        //    }
        //    return listaUsuarios;
        //}
        //internal static List<Desenvolvedor> LerDesenvolvedoresTxt()
        //{
        //    List<Desenvolvedor> listaDesenvolvedor = new List<Desenvolvedor>();
        //    MessageBox.Show("1");
        //    try
        //    {
        //        if (File.Exists(_FILE_PATH_DESENVOLVEDOR))
        //        {
        //            List<Usuario> lista = LerUsuariosTxt(_FILE_PATH_DESENVOLVEDOR, 0);
        //            if (lista.OfType<Desenvolvedor>().ToList().Count > 0)
        //            {
        //                listaDesenvolvedor = lista.OfType<Desenvolvedor>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("O arquivo txt de desenvolvedores não existe.");
        //        }
        //    }
        //    catch (IOException e)
        //    {
        //        MessageBox.Show("O arquivo não pôde ser aberto: " + e.Message);
        //    }
        //    return listaDesenvolvedor;
        //}
        //internal static List<TechLead> LerTechLeadsTxt()
        //{
        //    List<TechLead> listaTechLead = new List<TechLead>();

        //    try
        //    {
        //        if (File.Exists(_FILE_PATH_TECHLEAD))
        //        {
        //            List<Usuario> lista = LerUsuariosTxt(_FILE_PATH_TECHLEAD, 1);
        //            if (lista.OfType<TechLead>().ToList().Count > 0)
        //            {
        //                listaTechLead = lista.OfType<TechLead>().ToList();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("O arquivo txt de TechLeads não existe.");
        //        }
        //    }
        //    catch (IOException e)
        //    {
        //        MessageBox.Show("O arquivo não pôde ser aberto: " + e.Message);
        //    }
        //    return listaTechLead;
        //}

        //internal static Desenvolvedor ConverterLinhaParaDesenvolvedor(string linha)

        //{
        //    MessageBox.Show("3");
        //    string[] objetoString = linha.Split(',');

        //    string login = objetoString[0];
        //    string senha = objetoString[1];
        //    string nomeCompleto = objetoString[2];
        //    string cpf = objetoString[3];
        //    string email = objetoString[4];
        //    TipoUsuario tipoUsuario = StringParaTipoUsuario(objetoString[5]);

        //    return new Desenvolvedor(login, senha, nomeCompleto, cpf, email, tipoUsuario);
        //}
        //internal static TechLead ConverterLinhaParaTechLead(string linha)
        //{
        //    string[] objetoString = linha.Split(',');

        //    string login = objetoString[0];
        //    string senha = objetoString[1];
        //    string nomeCompleto = objetoString[2];
        //    string cpf = objetoString[3];
        //    string email = objetoString[4];
        //    TipoUsuario tipoUsuario = StringParaTipoUsuario(objetoString[5]);

        //    return new TechLead(login, senha, nomeCompleto, cpf, email, tipoUsuario);
        //}
        //internal static TipoUsuario StringParaTipoUsuario(string valor)
        //{
        //    MessageBox.Show("4");
        //    try
        //    {
        //        TipoUsuario TipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), valor);
        //        return TipoUsuario;
        //    }
        //    catch (ArgumentException)
        //    {
        //        Console.WriteLine($"A string '{valor}' não corresponde a nenhum valor de tipo de usuário");
        //        throw new ArgumentException();
        //    }


        //}
    }
}
