using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Produtos
{
    public class ProdutoOverflowStringMessage : Exception
    {
        public ProdutoOverflowStringMessage()
        {
        }

        public ProdutoOverflowStringMessage(string message) : base(message)
        {
        }

    }
}
