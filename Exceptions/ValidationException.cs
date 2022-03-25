using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_csharp.Exceptions
{
    /// <summary>
    /// Classe de exceção customizada para erros de validação do projeto
    /// </summary>
    public class ValidationException : Exception
    {
        //atributo
        private readonly string _mensagem;


        //método construtor -> ctor + 2x[tab]
        public ValidationException(string mensagem)
        {
            _mensagem = mensagem;
        }

        //sobrescrita do método Message da classe Exception
        public override string Message
            => $"Ocorreu um erro de validação: {_mensagem}";
    }

}
