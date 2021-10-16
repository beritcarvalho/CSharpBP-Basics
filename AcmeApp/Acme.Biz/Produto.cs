using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Produto
    {
        #region Construtores
        public Produto()
        {
            Console.WriteLine("Produto instância criada");
            this.produtoFornecedor = new Fornecedor();
        }

        public Produto(string productName,
                       int productId,
                       string description) : this()
        {
            this.ProdutoId = productId;
            this.ProdutoNome = productName;
            this.Descricao = description;

            Console.WriteLine("Produto instância tem o nome: " + ProdutoNome);
        }
        #endregion

        #region Propriedades
        private string produtoNome;

        public string ProdutoNome
        {
            get { return produtoNome; }
            set { produtoNome = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int produtoId;

        public int ProdutoId
        {
            get { return produtoId; }
            set { produtoId = value; }
        }

        private Fornecedor produtoFornecedor;

        public Fornecedor ProdutoFornecedor
        {
            get { return produtoFornecedor; }
            set { produtoFornecedor = value; }
        }

        /* se for necessario que a instacia do ProdutoFornecedor seja criado apenas quando chamamos a propriedade
         * seria necessário não saber inicialização de objeto no contrutor e a propriedade construida da forma a seguir
         * Isto esta técnica chama-se carregamento lento.   
        public Fornecedor ProdutoFornecedor
        {
            get { 
                    if (produtoFornecedor == null)
                    {
                            produtoFornecedor = new Fornecedor();
                    }
            }
                    return produtoFornecedor; }
            set { produtoFornecedor = value; }
        }
        */

        #endregion

        public string DigaOla()
        {
            //var fornecedor = new Fornecedor();
            //fornecedor.EnviaEmailBoasVindas("Mensagem enviada da classe Produto");


            var servicoEmail = new EmailService();
            var confirmacao = servicoEmail.EnviaMensagem("Novo produto",
                                                        this.produtoNome, "berit@abc.com.br");

            var resultado = LoggingService.LogAction("Dizendo Olá");
            
            return "Hello " + ProdutoNome +
                " (" + ProdutoId + "): " +
                Descricao;
        }
    }
}
