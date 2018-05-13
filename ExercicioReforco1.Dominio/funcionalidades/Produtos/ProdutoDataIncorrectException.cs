using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Produtos
{
    public class ProdutoDataIncorrectException : Exception
    {
        public ProdutoDataIncorrectException()
        {
        }

        public ProdutoDataIncorrectException(string message) : base(message)
        {
        }
    }
}
