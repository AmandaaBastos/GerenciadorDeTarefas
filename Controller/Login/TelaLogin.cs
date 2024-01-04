using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas.Controller.Login
{
    internal class TelaLogin
    {
        internal class TelaInicialController
        {
            private readonly TelaLogin _telaLogin;

            internal TelaInicialController(TelaLogin telaLogin)
            {
                _telaLogin = telaLogin;
            }

            //internal bool RealizarLogin()
            //{
            //    bool verificador = false;
            //    try
            //    {
            //        if (_telaLogin.TxtUsuario.Text != null && _telaLogin.TxtUsuario.Text == UsuarioData.SelecionarUsuario(_telaLogin.TxtUsuario.Text).Login)
            //        {
            //            if (UsuarioData.SelecionarUsuario(_telaLogin.TxtUsuario.Text).FazerLogin(_telaLogin.TxtUsuario.Text, _telaLogin.TxtSenha.Text))
            //            {
            //                MessageBox.Show("Login realizado com sucesso!");
            //                return true;
            //            }
            //            else
            //            {
            //                MessageBox.Show("Senha incorreta!");
            //                return verificador;
            //            }
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Usuário não encontrado!");
            //    }
            //    return verificador;

            //}

            //internal bool ValidaLogin()
            //{
            //    //if (_telaLogin.CmbUsuario.Text == "Funcionário")
            //    //{
            //    //    return ValidaCpf.IsValid(_telaLogin.TxtUsuario.Text);
            //    //}

            //    //if (_telaLogin.CmbUsuario.Text == "Aluno")
            //    //{
            //    //    return ValidaMatricula.IsValidAluno(_telaLogin.TxtUsuario.Text);
            //    //}

            //    //if (_telaLogin.CmbUsuario.Text == "Professor")
            //    //{
            //    //    return ValidaMatricula.IsValidProfessor(_telaLogin.TxtUsuario.Text);
            //    //}
            //    //return false;
            //}

            internal bool ValidaSenha(string senha)
            {
                if (senha.Length < 8 && senha.Length > 16)
                {
                    MessageBox.Show("A senha deve conter entre 8 e 16 caractéres");
                    return false;
                }

                if (!senha.Any(char.IsUpper))
                {
                    MessageBox.Show("A senha deve conter pelo menos uma letra MAIÚSCULA");
                    return false;
                }

                if (!senha.Any(char.IsLower))
                {
                    MessageBox.Show("A senha deve conter pelo menos uma letra minúscula");
                    return false;
                }

                if (!senha.Any(char.IsDigit))
                {
                    MessageBox.Show("A senha deve conter pelo menos um número");
                    return false;
                }

                return true;
            }

        }
    }
}
