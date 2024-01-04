using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    internal enum StatusTarefa
    {
        EmAtraso = 1,
        Concluida = 2,
        Cancelada = 3,
        Impedimento = 4,
        AguardandoAutorizacao = 5,
        Aberta = 6,
        Reprovada = 7,
        EmAndamento = 8,
    }
}
