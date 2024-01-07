using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Models.Busines;

namespace GerenciadorDeTarefas.Usuarios.Cargos
{
    internal class TechLead: Usuario
    {
       internal TechLead()
        {
        }

        
        //internal bool AlterarTarefa(Tarefa tarefa, string titulo, string escopo, string descricao)
        //{
        //    if (tarefa.Status == StatusTarefa.AguardandoAutorizacao)
        //    {
        //        tarefa.AlterarTitulo(titulo);
        //        tarefa.AlterarEscopo(escopo);
        //        tarefa.AlterarDescricao(descricao);
        //        return true;
        //    }
        //    return false;
        //}
        internal bool ReprovarTarefa(Tarefa tarefa)
        {
            if (tarefa.Status == StatusTarefa.AguardandoAutorizacao)
            {
                tarefa.Status = StatusTarefa.Reprovada;
                return true;
            }
            return false;
        }
        internal bool AprovarTarefa(Tarefa tarefa, Desenvolvedor desenvolvedor)
        {
            if (tarefa.Status == StatusTarefa.AguardandoAutorizacao)
            {
                tarefa.Status = StatusTarefa.Aberta;                
                return true;
            }
            return false;
        }
        
        internal bool ReabrirTarefa(Tarefa tarefa)
        {
            if (tarefa.Status == StatusTarefa.Concluida)
            {
                tarefa.Status = StatusTarefa.Aberta;               
                return true;
            }
            return false;
        }
        internal bool CancelarTarefa(Tarefa tarefa)
        {
            if (tarefa.Status == StatusTarefa.Aberta || tarefa.Status == StatusTarefa.EmAndamento)
            {
                tarefa.Status = StatusTarefa.Cancelada;
                return true;
            }
            return false;
        }           
        internal bool InformarResolucao(Tarefa tarefa)
        {
            if (tarefa.Status == StatusTarefa.Impedimento)
            {
                tarefa.Status = StatusTarefa.EmAndamento;
                return true;
            }
            return false;
        }
        internal bool InformarAtraso(Tarefa tarefa)
        {
            if (tarefa.Status == StatusTarefa.EmAndamento)
            {
                tarefa.Status = StatusTarefa.EmAtraso;
                return true;
            }
            return false;
        }

        

    }
}
       
