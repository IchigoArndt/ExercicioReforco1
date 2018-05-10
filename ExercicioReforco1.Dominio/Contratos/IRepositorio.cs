using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.Contratos
{
   public interface IRepositorio<T>
    {
        T Adicionar(T entidade);
        T Atualizar(T entidade);
        IList<T> ObterTodosItens();
        void Excluir(int id);
    }
}
