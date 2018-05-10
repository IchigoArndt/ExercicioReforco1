using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.Contratos
{
   public interface IProdutoRepositorio : IRepositorio<Produto>
    {
        bool Existe(Produto produto);
    }
}
