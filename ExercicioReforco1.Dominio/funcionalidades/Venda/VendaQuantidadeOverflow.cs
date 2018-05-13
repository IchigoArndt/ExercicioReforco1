using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Venda
{
   public class VendaQuantidadeOverflow : Exception
    {
        public VendaQuantidadeOverflow()
        {
        }

        public VendaQuantidadeOverflow(string message) : base(message)
        {
        }
    }
}
