using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Models.Busines;
using GerenciadorDeTarefas.Usuarios;

namespace GerenciadorDeTarefas.Models.Busines
{
    internal class Tarefa
    {
        public int _idTarefa;
        private string _titulo, _descricao, _escopo;
        private DateTime _dataDeCriacao, _dataDeConclusao;
        private Usuario _responsavel;
        private StatusTarefa _status;
        private bool _impedimento;


        internal Tarefa(int idTarefa, string titulo, string descricao, string escopo, Usuario responsavel)
        {
            this._idTarefa = idTarefa;
            this._titulo = titulo;
            this._descricao = descricao;
            this._escopo = escopo;
            this._responsavel = responsavel;
            this._dataDeCriacao = DateTime.Now;
            this._dataDeConclusao = DataDeConclusao;
            this._status = StatusTarefa.Aberta;
            this._impedimento = false;
        }

        internal int IdTarefa { get { return _idTarefa; } }
        internal string Titulo { get { return _titulo; } }
        internal string Escopo { get { return _escopo; } }
        internal string Descricao { get { return _descricao; } }
        internal DateTime DataDeCriacao { get { return _dataDeCriacao; } }
        internal DateTime DataDeConclusao
        {
            get { return _dataDeConclusao; }
            set { _dataDeConclusao = value; }
        }
        internal Usuario Responsavel { get { return _responsavel; } }
        internal bool Impedimento { get { return _impedimento; } }

        public StatusTarefa Status
        {
            get { return _status; }
            set { _status = value; }
        }
        internal void ConcluirTarefa()
        {
            if (this._status == StatusTarefa.EmAndamento)
            {
                this._status = StatusTarefa.Concluida;
                this._dataDeConclusao = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Tarefa não pode ser concluída");
            }
        }
        internal void AtribuirResponsavel(Usuario usuario)
        {
            _responsavel = usuario;
        }


        //internal bool DefinirImpedimento(bool impedimento)
        //{
        //    this._impedimento = impedimento;
        //    return true;
        //}
        //internal bool AlterarTitulo(string titulo)
        //{
        //    if (titulo.Length > 0)
        //    {
        //        this._titulo = titulo;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarEscopo(string escopo)
        //{
        //    if (escopo.Length > 0)
        //    {
        //        this._escopo = escopo;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarDescricao(string descricao)
        //{
        //    if (descricao.Length > 0)
        //    {
        //        this._descricao = descricao;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarResponsavel(Usuario responsavel)
        //{
        //    if (responsavel != null)
        //    {
        //        this._responsavel = responsavel;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarStatus(StatusTarefa status)
        //{
        //    this._status = status;
        //    return true;
        //}
        //internal bool AlterarDataDeConclusao(DateTime dataDeConclusao)
        //{
        //    if (dataDeConclusao != null)
        //    {
        //        this._dataDeConclusao = dataDeConclusao;
        //        return true;
        //    }
        //    return false;
        //}
        //internal bool AlterarDataDeCriacao(DateTime dataDeCriacao)
        //{
        //    if (dataDeCriacao != null)
        //    {
        //        this._dataDeCriacao = dataDeCriacao;
        //        return true;
        //    }
        //    return false;
        //}



    }
}
