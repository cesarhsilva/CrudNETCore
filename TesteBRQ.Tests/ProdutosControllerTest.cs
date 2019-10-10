using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TesteBRQ.API.Controllers;
using TesteBRQ.Domain.Entities;
using TesteBRQ.Infra.Data.Context;

namespace TesteBRQ.Tests
{
    [TestClass]
    public class ProdutosControllerTest
    {
        [TestMethod]
        public void GetProdutosTest()
        {
            var mockSet = new Mock<DbSet<Produto>>();
            var mockContext = new Mock<TesteBRQContext>();
            mockContext.Setup(m => m.Produtos).Returns(mockSet.Object);
            
            ProdutosController produtosController = new ProdutosController(mockContext.Object);
            produtosController.GetProdutos();


        }
    }
}
