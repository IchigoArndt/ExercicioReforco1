using ExercicioReforco.Common.Utils;
using ExercicioReforco1.Dominio.funcionalidades.Venda;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReforco.DomainTest.Features.Produto
{
    [TestFixture]
    public class VendaTest
    {
        [Test]
        public void CreateVendaValid()
        {
            Venda venda = ObjectMotherVenda.getValidVenda();
            venda.Id = 1;
            venda.valida();
            venda.Id.Should().Be(1);
        }
        [Test]
        public void CreateVendaInvalidProduto()
        {
            Venda venda = ObjectMotherVenda.getInvalidProduto();
            Action act  = venda.valida;
            act.Should().Throw<VendaExceptionIsProdutoNull>();
        }
        [Test]
        public void CreateVendaInvalidNomeCliente()
        {
            Venda venda = ObjectMotherVenda.getInvalidMessage();
            Action act = venda.valida;
            act.Should().Throw<VendaIsNullOrEmptyNome>();
        }
        [Test]
        public void CreateVendaInvalidOverflowNomeCliente()
        {
            Venda venda = ObjectMotherVenda.getInvalidMessageOverflow();
            Action act = venda.valida;
            act.Should().Throw<VendaIsNullOrEmptyNome>();
        }
        [Test]
        public void CreateVendaInvalidOverflowQuantidade()
        {
            Venda venda = ObjectMotherVenda.getInValidQuantidadeOverflow();
            Action act = venda.valida;
            act.Should().Throw<VendaQuantidadeOverflow>();
        }
    }
}
