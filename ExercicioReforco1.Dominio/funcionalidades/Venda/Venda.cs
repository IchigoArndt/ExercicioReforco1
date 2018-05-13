using ExercicioReforco1.Dominio.Ultils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio.funcionalidades.Venda
{
   public  class Venda : Entidade
    {
       public Produto _produto { get; set; }
       public string NomeCliente { get; set; }
       public int Quantidade { get; set; }
       public decimal Lucro { get; set; }
       
        public override void valida()
        {
            if (_produto == null)
                throw new VendaExceptionIsProdutoNull("O produto não pode ficar vazio");

            if (string.IsNullOrEmpty(NomeCliente))
                throw new VendaIsNullOrEmptyNome("O nome do cliente não pode ficar vazio");

            if (NomeCliente.Length < 4 || NomeCliente.Length > 30)
                throw new VendaIsNullOrEmptyNome("O nome do Cliente não pode ser menor que 4 ou maior que 30");

            if (Quantidade == 0 || Quantidade > 100)
                throw new VendaQuantidadeOverflow("A quantidade não pode ser 0 ou maior que 100");
        }

        public decimal CalcularLucro()
        {
            return this.Quantidade * this._produto.PrecoVenda;
        }

    }
}
