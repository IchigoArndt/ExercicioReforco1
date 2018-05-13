using ExercicioReforco1.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco.Common
{
    public static partial class ObjectMotherProduto
    {
        public static Produto GetValidProduto()
        {
            Produto produto = new Produto();
            produto.Id = 1;
            produto.Disponivel = true;
            produto.Nome = "Batom Vermelho";
            produto.PrecoCusto = 2.50m;
            produto.PrecoVenda = 5.0m;
            produto.DataFabricacao = DateTime.Now;
            produto.DataVencimento = DateTime.Now.AddMonths(1);
            return produto;
        }
        public static Produto GetInvalidDateProduto()
        {
            Produto produto = new Produto();
            produto.Id = 1;
            produto.Disponivel = true;
            produto.Nome = "Batom Vermelho";
            produto.PrecoCusto = 2.50m;
            produto.PrecoVenda = 5.0m;
            produto.DataFabricacao = DateTime.Now;
            produto.DataVencimento = DateTime.Now.AddMonths(-1);
            return produto;
        }
        public static Produto GetInvalidPriceProduto()
        {
            Produto produto = new Produto();
            produto.Id = 1;
            produto.Disponivel = true;
            produto.Nome = "Batom Vermelho";
            produto.PrecoCusto = 2.50m;
            produto.PrecoVenda = 2.50m;
            produto.DataFabricacao = DateTime.Now;
            produto.DataVencimento = DateTime.Now.AddMonths(-1);
            return produto;
        }
        public static Produto GetInvalidPriceOverflowProduto()
        {
            Produto produto = new Produto();
            produto.Id = 1;
            produto.Disponivel = true;
            produto.Nome = "Batom Vermelho";
            produto.PrecoCusto = 2.50m;
            produto.PrecoVenda = 1.50m;
            produto.DataFabricacao = DateTime.Now;
            produto.DataVencimento = DateTime.Now.AddMonths(-1);
            return produto;
        }
        public static Produto GetInvalidMessageProduto()
        {
            Produto produto = new Produto();
            produto.Id = 1;
            produto.Disponivel = true;
            produto.Nome = "";
            produto.PrecoCusto = 2.50m;
            produto.PrecoVenda = 3.50m;
            produto.DataFabricacao = DateTime.Now;
            produto.DataVencimento = DateTime.Now.AddMonths(-1);
            return produto;
        }
        public static Produto GetInvalidMessageOverflowProduto()
        {
            Produto produto = new Produto();
            produto.Id = 1;
            produto.Disponivel = true;
            produto.Nome = "Batom Vermelho Batom Vermelho Batom Vermelho Batom Vermelho Batom Vermelho Batom Vermelho Batom Vermelho Batom Vermelho Batom Vermelho";
            produto.PrecoCusto = 2.50m;
            produto.PrecoVenda = 3.50m;
            produto.DataFabricacao = DateTime.Now;
            produto.DataVencimento = DateTime.Now.AddMonths(-1);
            return produto;
        }
    }
}
