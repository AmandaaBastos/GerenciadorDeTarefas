﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    abstract class Usuario
    {
        protected string login,senha,nomeCompleto,cpf,email;
        private TipoUsuario cargo;
        
        protected Usuario(string login, string senha, string nomeCompleto, string cpf, string email, TipoUsuario cargo)
        {
            this.login = login;
            this.senha = senha;
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
            this.email = email;
            this.cargo = cargo;
        }
        internal string Login { get { return login; } }
        internal string Senha { get { return senha; } }
        internal string NomeCompleto { get { return nomeCompleto; } }
        internal string Cpf { get { return cpf; } }
        internal string Email { get { return email; } }        
        internal TipoUsuario Cargo 
        { 
            get { return cargo; }
            set { cargo = value; }
        }

        protected bool FazerLogin(string login, string senha)
        {
            return (this.login == login && this.senha == senha);
        }
        protected bool AlterarSenha(string senhaAtual, string novaSenha)
        {
            if (this.senha == senhaAtual)
            {
                this.senha = novaSenha;
                return true;
            }
            return false;
        }
        protected bool AlterarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                this.email = email;
                return true;
            }
            return false;
        }
        protected bool AlterarNomeCompleto(string nomeCompleto)
        {
            if (nomeCompleto.Length > 0)
            {
                this.nomeCompleto = nomeCompleto;
                return true;
            }
            return false;
        }
        protected bool AlterarCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                this.cpf = cpf;
                return true;
            }
            return false;
        }
        protected bool AlterarCargo(TipoUsuario cargo)
        {
            this.cargo = cargo;
            return true;
        }
        internal void CriarTarefa(int idTarefa, string titulo, string descricao, string escopo, Usuario responsavel)
        {
            if (this is TechLead)
            {
                Tarefa tarefa = new Tarefa(idTarefa, titulo, descricao, escopo, responsavel);
                tarefa.Status = StatusTarefa.Aberta;
                Console.WriteLine("Tarefa criada com sucesso");
            }
            else
            {
                Tarefa tarefa = new Tarefa(idTarefa, titulo, descricao, escopo, responsavel);
                responsavel = this;
                tarefa.Status = StatusTarefa.AguardandoAutorizacao;                               
            }
        }
    }
}
