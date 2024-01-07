using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Models.Busines
{
    internal class TarefaData
    {
        private static List<Tarefa> _tarefas;

        internal static List<Tarefa> ListarTarefas()
        {
            return _tarefas;
        }
        internal void AdicionarTarefa(Tarefa tarefa)
        {
            _tarefas.Add(tarefa);
        }
         

    }
}
