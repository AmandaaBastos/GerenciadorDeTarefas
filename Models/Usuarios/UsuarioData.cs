using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeTarefas.Models.Busines;

namespace GerenciadorDeTarefas
{
    internal class UsuarioData
    {
        private static List<Desenvolvedor> _desenvolvedores;
        private static List<TechLead> _techLeads;

        private static readonly string _DIRECTORY_PATH = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "") + "\\Data";
        private static readonly string _FILE_PATH_DESENVOLVEDOR = Path.Combine(_DIRECTORY_PATH, "Desenvolvedores.txt");
        private static readonly string _FILE_PATH_TECHLEAD = Path.Combine(_DIRECTORY_PATH, "TechLead.txt");

        static UsuarioData()
        {
            _desenvolvedores = LerDesenvolvedoresTxt();
            _techLeads = LerTechLeadsTxt();
        }

        internal static List<Tarefa> ListarTarefasUsuario(Usuario usuario)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            foreach (Tarefa tarefa in TarefaData.ListarTarefas())
            {
                if (tarefa.Responsavel == usuario)
                {
                    tarefas.Add(tarefa);
                }
            }
            return tarefas;
        }
        internal static Usuario SelecionarUsuario(string login)
        {
            Usuario usuario = _techLeads.Where(u => u.Login == login).FirstOrDefault();
            if (usuario != null) return usuario;

            usuario = _desenvolvedores.Where(u => u.Login == login).FirstOrDefault();
            if (usuario != null) return usuario;

            throw new InvalidOperationException("Usuário não encontrado.");
        }
        internal static List<Usuario> LerUsuariosTxt(string _FILE_PATH, int tipoUsuario)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                if (File.Exists(_FILE_PATH))
                {

                    using (StreamReader sr = new StreamReader(_FILE_PATH))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();
                            if (tipoUsuario == 0)
                            {
                                Desenvolvedor desenvolvedor = ConverterLinhaParaDesenvolvedor(linha);
                                listaUsuarios.Add(desenvolvedor);
                            }
                            else if (tipoUsuario == 1)
                            {
                                TechLead techLead = ConverterLinhaParaTechLead(linha);
                                listaUsuarios.Add(techLead);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo txt de diretor não existe.");
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("O arquivo não pôde ser aberto: " + e.Message);
            }
            return listaUsuarios;
        }
        internal static List<Desenvolvedor> LerDesenvolvedoresTxt()
        {
            List<Desenvolvedor> listaDesenvolvedor = new List<Desenvolvedor>();

            try
            {
                if (File.Exists(_FILE_PATH_DESENVOLVEDOR))
                {
                    List<Usuario> lista = LerUsuariosTxt(_FILE_PATH_DESENVOLVEDOR, 0);
                    if (lista.OfType<Desenvolvedor>().ToList().Count > 0)
                    {
                        listaDesenvolvedor = lista.OfType<Desenvolvedor>().ToList();
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo txt de desenvolvedores não existe.");
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("O arquivo não pôde ser aberto: " + e.Message);
            }
            return listaDesenvolvedor;
        }
        internal static List<TechLead> LerTechLeadsTxt()
        {
            List<TechLead> listaTechLead = new List<TechLead>();

            try
            {
                if (File.Exists(_FILE_PATH_DESENVOLVEDOR))
                {
                    List<Usuario> lista = LerUsuariosTxt(_FILE_PATH_DESENVOLVEDOR, 0);
                    if (lista.OfType<TechLead>().ToList().Count > 0)
                    {
                        listaTechLead = lista.OfType<TechLead>().ToList();
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo txt de TechLeads não existe.");
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("O arquivo não pôde ser aberto: " + e.Message);
            }
            return listaTechLead;
        }
        internal static Desenvolvedor ConverterLinhaParaDesenvolvedor(string linha)
        {
            string[] objetoString = linha.Split(',');

            string login = objetoString[0];
            string senha = objetoString[1];
            string nomeCompleto = objetoString[2];
            string cpf = objetoString[3];
            string email = objetoString[4];
            TipoUsuario tipoUsuario = StringParaTipoUsuario(objetoString[5]);

            return new Desenvolvedor(login, senha, nomeCompleto, cpf, email, tipoUsuario);
        }
        internal static TechLead ConverterLinhaParaTechLead(string linha)
        {
            string[] objetoString = linha.Split(',');

            string login = objetoString[0];
            string senha = objetoString[1];
            string nomeCompleto = objetoString[2];
            string cpf = objetoString[3];
            string email = objetoString[4];
            TipoUsuario tipoUsuario = StringParaTipoUsuario(objetoString[5]);

            return new TechLead(login, senha, nomeCompleto, cpf, email, tipoUsuario);
        }
        internal static TipoUsuario StringParaTipoUsuario(string valor)
        {
            try
            {
                TipoUsuario TipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), valor);
                return TipoUsuario;
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"A string '{valor}' não corresponde a nenhum valor de tipo de usuário");
                throw new ArgumentException();
            }


        }
    }
}
