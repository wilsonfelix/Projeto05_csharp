using Projeto05_csharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_csharp.Repositories
{
    /// <summary>
    /// Classe abstrata para definir os método do repositorio de funcionario
    /// </summary>
    public abstract class FuncionarioAbstractRepository
    {
        #region Propriedades

        protected List<Funcionario> Funcionarios { get; set; }

        #endregion

        #region Construtores

        public FuncionarioAbstractRepository()
        {
            Funcionarios = new List<Funcionario>();
        }

        #endregion

        #region Métodos abstratos

        public abstract void Adicionar(Funcionario funcionario);
        public abstract void Atualizar(Funcionario funcionario);
        public abstract void Remover(Funcionario funcionario);

        public abstract List<Funcionario> ObterTodos();
        public abstract List<Funcionario> ObterPorNome(string nome);
        public abstract List<Funcionario> ObterPorDataAdmissao(DateTime? dataMin, DateTime? dataMax);
        public abstract Funcionario ObterPorId(Guid id);

        #endregion
    }

}



