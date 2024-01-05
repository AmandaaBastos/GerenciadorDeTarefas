using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Controllers.Login;
using GerenciadorDeTarefas.Models.Busines;
using GerenciadorDeTarefas.Usuarios;
using GerenciadorDeTarefas.Views;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using GerenciadorDeTarefas.Usuarios.Cargos;

namespace GerenciadorDeTarefas.Controllers
{
    internal class TelaInicialController
    {
        private TelaLogin telaLogin;
        private List<Desenvolvedor> desenvolvedores;
        string caminhoDesenvolvedor = "Desenvolvedores.txt";
        
        public TelaInicialController(TelaLogin telaLogin)
        {
            this.telaLogin = telaLogin;
            desenvolvedores = LerDesenvolvedoresTxt(caminhoDesenvolvedor);
        }

        private List<Desenvolvedor> LerDesenvolvedoresTxt(string caminhoDesenvolvedor)
        {
            List<Desenvolvedor> desenvolvedores = new List<Desenvolvedor>();

            try
            {
                string[] linhas = File.ReadAllLines(caminhoDesenvolvedor);

                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(',');
                    
                    if (dados.Length >= 5)
                    {
                        Desenvolvedor desenvolvedor = new Desenvolvedor(dados[0], dados[1], dados[2], dados[3], dados[4]);
                        desenvolvedores.Add(desenvolvedor);
                    }
                    else
                    {
                        Console.WriteLine($"A linha '{linha}' não contém dados suficientes para criar um Desenvolvedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }

            return desenvolvedores;
        }
        public bool Autenticar(string login, string senha)
            
        {
            Desenvolvedor usuarioAutenticado = desenvolvedores.Find(u => u.Login == login && u.Senha == senha);

            if (usuarioAutenticado != null)
            {
                if (usuarioAutenticado.Senha == senha)
                {
                    MessageBox.Show($"Autenticação bem-sucedida. Bem-vindo, {usuarioAutenticado.NomeCompleto}!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Falha na autenticação. Senha incorreta.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Falha na autenticação. Login incorreto.");
                return false;
            }
        }

        
        
    }

}

