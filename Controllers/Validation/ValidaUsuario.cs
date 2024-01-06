using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Controllers.Login
{
    internal class ValidaUsuario
    {
        public static bool IsValid(string login)
        {
            if (login.Length != 8)
            {
                return false;
            }            
            return true;
        }        
    }
}
