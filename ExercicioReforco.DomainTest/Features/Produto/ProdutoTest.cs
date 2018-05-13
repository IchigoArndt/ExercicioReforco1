using System;
using ExercicioReforco.Common;
using ExercicioReforco1.Dominio;
using ExercicioReforco1.Dominio.funcionalidades.Produtos;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ExercicioReforco.DomainTest
{
    [TestFixture]
    public class ProdutoTest
    {
        [Test]
        public void createProdutoValid()
        {
            Produto produto = ObjectMotherProduto.GetValidProduto();
            produto.valida();
            produto.Id.Should().Be(1);
        }
        [Test]
        public void createProdutoInValidMessage()
        {
            Produto produto = ObjectMotherProduto.GetInvalidMessageProduto();
            Action act = produto.valida;
            act.Should().Throw<Exception>();
        }
        [Test]
        public void createProdutoInValidMessageOverflow()
        {
            Produto produto = ObjectMotherProduto.GetInvalidMessageOverflowProduto();
            Action act = produto.valida;
            act.Should().Throw<ProdutoOverflowStringMessage>();
        }
        [Test]
        public void createProdutoInValidDate()
        {
            Produto produto = ObjectMotherProduto.GetInvalidDateProduto();
            Action act = produto.valida;
            act.Should().Throw<ProdutoDataIncorrectException>();
        }
        [Test]
        public void createProdutoInValidIncorretPrice()
        {
            Produto produto = ObjectMotherProduto.GetInvalidPriceProduto();
            Action act = produto.valida;
            act.Should().Throw<ProdutoIncorrectPriceException>();
        }
    }
}
