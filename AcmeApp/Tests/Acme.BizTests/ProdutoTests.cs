using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProdutoTests
    {
        [TestMethod()]
        public void DigaOlaTest()
        {
            //Arrange
            var produtoAtual = new Produto();
            produtoAtual.ProdutoNome = "Notebook";
            produtoAtual.ProdutoId = 1;
            produtoAtual.Descricao = "Notebook Acer Aspire 5";
            produtoAtual.ProdutoFornecedor.NomeEmpresa = "ABC Corp";
            var expected = "Hello Notebook (1): Notebook Acer Aspire 5";

            //Act
            var actual = produtoAtual.DigaOla();

            //Assert    
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHelloTest_Contrutor_Parametrizado()
        {
            //Arrange
            var currentProduct = new Produto("Notebook",
                                              1,
                                             "Notebook Acer Aspire 5");
                
            var expected = "Hello Notebook (1): Notebook Acer Aspire 5";

            //Act
            var actual = currentProduct.DigaOla();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHelloTest_InicializacaoObjeto()
        {
            //Arrange
            var currentProduct = new Produto
            {
                ProdutoNome = "Notebook",
                ProdutoId = 1,
                Descricao = "Notebook Acer Aspire 5"
            };

            var expected = "Hello Notebook (1): Notebook Acer Aspire 5";

            //Act
            var actual = currentProduct.DigaOla();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}