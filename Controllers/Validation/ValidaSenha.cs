using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas.Controllers.Login
{
    internal class ValidaSenha
    {
        public static bool IsValid(string senha)
        {
            
            bool senhaValida = false;
            do
            {
                if (senha.Length < 8)
                {
                    MessageBox.Show("Sua senha precisa ter, no mínimo, 8 dígitos. Digite novamente: ");
                    
                }
                else if (!senha.Any(char.IsUpper))
                {
                    MessageBox.Show("Sua senha precisa ter, no mínimo, uma letra maiúscula. Digite novamente: ");
                   
                }
                else if (!senha.Any(char.IsLower))
                {
                    MessageBox.Show("Sua senha precisa ter, no mínimo, uma letra minúscula. Digite novamente: ");
                    
                }
                else if (!senha.Any(char.IsDigit))
                {
                    MessageBox.Show("Sua senha precisa ter, no mínimo, um número. Digite novamente: ");
                    
                }
                else
                {
                    senhaValida = true;
                }
            } while (senhaValida == false);

            MessageBox.Show("Senha válida!");
            return senhaValida;
        }
    }
}
