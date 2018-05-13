using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Venda
{
   public class VendaExceptionIsProdutoNull : Exception
    {
        public VendaExceptionIsProdutoNull()
        {
        }

        public VendaExceptionIsProdutoNull(string message) : base(message)
        {
        }
    }
}
