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
    public class FornecedorTests
    {
        [TestMethod()]
        public void EnviaEmailBoasVindas_EmpresaValida_Success()
        {
            // Arrange
            var vendor = new Fornecedor();
            vendor.NomeEmpresa = "ABC Corp";
            var expected = "Message sent: Hello ABC Corp";

            // Act
            var actual = vendor.EnviaEmailBoasVindas("Test Message");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EnviaEmailBoasVindas_EmpresaVazio_Success()
        {
            // Arrange
            var vendor = new Fornecedor();
            vendor.NomeEmpresa = "";
            var expected = "Message sent: Hello";

            // Act
            var actual = vendor.EnviaEmailBoasVindas("Test Message");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EnviaEmailBoas_EmpresaNull_Success()
        {
            // Arrange
            var vendor = new Fornecedor();
            vendor.NomeEmpresa = null;
            var expected = "Message sent: Hello";

            // Act
            var actual = vendor.EnviaEmailBoasVindas("Test Message");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}