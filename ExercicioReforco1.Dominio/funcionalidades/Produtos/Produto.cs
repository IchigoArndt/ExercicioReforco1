using ExercicioReforco1.Dominio.funcionalidades.Produtos;
using ExercicioReforco1.Dominio.Ultils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco1.Dominio
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public Decimal PrecoVenda { get; set; }
        public Decimal PrecoCusto { get; set; }
        public bool Disponivel { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataVencimento { get; set; }

        public override void valida()
        {
            if(string.IsNullOrEmpty(Nome))
                throw new Exception("Nome não pode ficar vazio");
            if (Nome.Length <= 4 || Nome.Length > 30)
                throw new ProdutoOverflowStringMessage("O nome deve ter entre 4 e 30 carateres");
            if (PrecoCusto >= PrecoVenda)
                throw new ProdutoIncorrectPriceException("O preço de custo não pode ser nem menor e " +
                                                         "nem igual ao de venda");
            if (DataVencimento < DataFabricacao)
                throw new ProdutoDataIncorrectException("A data de validade deve-se ser maior que a data de fabricação");
        }
    }
}
