using ExercicioReforco1.Dominio.funcionalidades.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco.Common.Utils
{
    public static partial class ObjectMotherVenda
    {
        public static Venda getValidVenda()
        {
            Venda venda = new Venda();
            venda.Id = 1;
            venda.NomeCliente = "Qualquer um";
            venda.Quantidade = 10;
            venda._produto = ObjectMotherProduto.GetValidProduto();
            venda.Lucro = venda.CalcularLucro();
            return venda;
        }
        public static Venda getInvalidProduto()
        {
            Venda venda = new Venda();
            venda.Id = 1;
            venda.Lucro = 10.0m;
            venda.NomeCliente = "Qualquer um";
            venda.Quantidade = 10;
            venda._produto = null;
            return venda;
        }
        public static Venda getInvalidMessage()
        {
            Venda venda = new Venda();
            venda.Id = 1;
            venda.Lucro = 10.0m;
            venda.NomeCliente = "";
            venda.Quantidade = 10;
            venda._produto = ObjectMotherProduto.GetValidProduto();
            return venda;
        }
        public static Venda getInvalidMessageOverflow()
        {
            Venda venda = new Venda();
            venda.Id = 1;
            venda.Lucro = 10.0m;
            venda.NomeCliente = "Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um Qualquer um";
            venda.Quantidade = 10;
            venda._produto = ObjectMotherProduto.GetValidProduto();
            return venda;
        }
        public static Venda getInValidQuantidadeNull()
        {
            Venda venda = new Venda();
            venda.Id = 1;
            venda.Lucro = 10.0m;
            venda.NomeCliente = "Qualquer um";
            venda.Quantidade = 0;
            venda._produto = ObjectMotherProduto.GetValidProduto();
            return venda;
        }
        public static Venda getInValidQuantidadeOverflow()
        {
            Venda venda = new Venda();
            venda.Id = 1;
            venda.Lucro = 10.0m;
            venda.NomeCliente = "Qualquer um";
            venda.Quantidade = 1000;
            venda._produto = ObjectMotherProduto.GetValidProduto();
            return venda;
        }
    }

}
