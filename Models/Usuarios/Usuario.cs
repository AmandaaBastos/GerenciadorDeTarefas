﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Conections;
using GerenciadorDeTarefas.Models.Busines;
using GerenciadorDeTarefas.Usuarios.Cargos;


namespace GerenciadorDeTarefas.Usuarios
{
    internal class Usuario
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        internal string login,senha,nomeCompleto,cpf,email, cargo;

        internal Usuario() { }

        internal Usuario ObterUsuario(string login)
        {
            Usuario usuario = null;

            cmd.CommandText = "SELECT * FROM usuarios WHERE login = @login";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@login", login);           

            Conexao conexao = new Conexao();
            cmd.Connection = conexao.Conectar();

            using ( reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {                    
                    reader.Read();

                    usuario = new Usuario
                    {
                        login = reader["login"].ToString(),
                        senha = reader["senha"].ToString(),
                        nomeCompleto = reader["nomeCompleto"].ToString(),
                        cpf = reader["cpf"].ToString(),
                        email = reader["email"].ToString(),
                        cargo = reader["cargo"].ToString()
                    };
                }
            }
            conexao.Desconectar();

            return usuario;
        }

        internal string Login { get { return login; } }
        internal string Senha { get { return senha; } }
        internal string NomeCompleto { get { return nomeCompleto; } }
        internal string Cpf { get { return cpf; } }
        internal string Email { get { return email; } }  
        internal string Cargo { get { return cargo; } }
       
        
        
        
        internal bool AlterarSenha(string senhaAtual, string novaSenha)
        {
            if (this.senha == senhaAtual)
            {
                this.senha = novaSenha;
                return true;
            }
            return false;
        }
        internal bool AlterarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                this.email = email;
                return true;
            }
            return false;
        }
        internal bool AlterarNomeCompleto(string nomeCompleto)
        {
            if (nomeCompleto.Length > 0)
            {
                this.nomeCompleto = nomeCompleto;
                return true;
            }
            return false;
        }
        internal bool AlterarCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                this.cpf = cpf;
                return true;
            }
            return false;
        }
      
       
    }
}
