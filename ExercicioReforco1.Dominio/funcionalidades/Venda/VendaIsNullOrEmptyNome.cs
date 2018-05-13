using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Venda
{
   public class VendaIsNullOrEmptyNome : Exception
    {
        public VendaIsNullOrEmptyNome()
        {
        }

        public VendaIsNullOrEmptyNome(string message) : base(message)
        {
        }
    }
}
