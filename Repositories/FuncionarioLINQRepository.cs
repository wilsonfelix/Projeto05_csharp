using Projeto05_csharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_csharp.Repositories
{
    /// <summary>
    /// Classe para implementar os métodos do repositorio em sintaxe LINQ
    /// </summary>
    public class FuncionarioLINQRepository : FuncionarioAbstractRepository
    {
        public override void Adicionar(Funcionario funcionario)
        {
            //adicionando o funcionário na lista
            Funcionarios.Add(funcionario);
        }

        public override void Atualizar(Funcionario funcionario)
        {
            //buscando o funcionário pelo id
            var item = ObterPorId(funcionario.Id);

            //verificando se o funcionário não foi encontrado
            if (item == null)
                throw new Exception("Funcionário não encontrado.");

            //alterando os dados
            item.Nome = funcionario.Nome;
            item.Cpf = funcionario.Cpf;
            item.Matricula = funcionario.Matricula;
            item.DataAdmissao = funcionario.DataAdmissao;
            item.Tipo = funcionario.Tipo;
        }

        public override void Remover(Funcionario funcionario)
        {
            //buscando o funcionário pelo id
            var item = ObterPorId(funcionario.Id);

            //verificando se o funcionário não foi encontrado
            if (item == null)
                throw new Exception("Funcionário não encontrado.");

            //removendo o funcionario
            Funcionarios.Remove(item);
        }

        public override List<Funcionario> ObterTodos()
        {
            //SINTAXE LINQ
            var query = from f in Funcionarios
                        orderby f.Nome ascending
                        select f;

            return query.ToList();
        }

        public override List<Funcionario> ObterPorNome(string nome)
        {
            //SINTAXE LINQ
            var query = from f in Funcionarios
                        where f.Nome.Contains(nome)
                        orderby f.Nome ascending
                        select f;

            return query.ToList();
        }

        public override List<Funcionario> ObterPorDataAdmissao
                        (DateTime? dataMin, DateTime? dataMax)
        {
            //SINTAXE LINQ
            var query = from f in Funcionarios
                        where f.DataAdmissao >= dataMin
                           && f.DataAdmissao <= dataMax
                        orderby f.DataAdmissao ascending
                        select f;

            return query.ToList();
        }

        public override Funcionario ObterPorId(Guid id)
        {
            //SINTAXE LINQ
            var query = from f in Funcionarios
                        where f.Id == id
                        select f;

            return query.FirstOrDefault();
        }
    }
}


