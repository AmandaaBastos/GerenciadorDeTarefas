using GerenciadorDeTarefas.Conections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers
{
    internal class Controle
    {
        internal bool techLead;
        internal bool valido;        
        internal string mensagem = "";
        
        internal bool Acessar(String login, String senha)//Pega os dados do forms
        {
            LoginComandos loginComandos = new LoginComandos();
            valido = loginComandos.VerificarLogin(login, senha);
            if (loginComandos.mensagem != mensagem)
            {    
                this.mensagem = loginComandos.mensagem;              
            }
            return valido;
        }
        internal String Cadastrar(string email, string senha, string confSenha)
        {
            return mensagem;
        }
        internal bool VerificarCargo(String login, String senha)
        {
            LoginComandos loginComandos = new LoginComandos();
            techLead = loginComandos.VerificarCargo(login, senha);
            if (!loginComandos.techLead)
            {
                techLead = false;
            }
            return techLead;
        }
    }
}
