﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    internal class Desenvolvedor: Usuario
    {
        internal Desenvolvedor(string login, string senha, string nomeCompleto, string cpf, string email, TipoUsuario cargo)
            : base(login, senha, nomeCompleto, cpf, email, cargo)
        {
        }     

        internal bool IniciarTarefa(Tarefa tarefa)
        {
            if (tarefa.Status == StatusTarefa.Aberta && tarefa.Responsavel == this)
            {
                tarefa.Status = StatusTarefa.EmAndamento;
                return true;
            }
            return false;
        }
        internal void ConcluirTarefa(Tarefa tarefa)
        {
            if (tarefa.Responsavel == this)
            {
                tarefa.ConcluirTarefa();          
            }
            else
            {
                Console.WriteLine("Você não é o responsável por essa tarefa, portanto não pode conclui-la");
            }
        }
        
        
       

        
    }
}
