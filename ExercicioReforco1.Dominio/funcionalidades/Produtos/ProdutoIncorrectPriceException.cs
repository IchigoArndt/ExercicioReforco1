using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Produtos
{
   public class ProdutoIncorrectPriceException : Exception
    {
        public ProdutoIncorrectPriceException()
        {
        }

        public ProdutoIncorrectPriceException(string message) : base(message)
        {
        }
    }
}
