using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages the vendors from whom we purchase our inventory.
    /// </summary>
    public class Fornecedor 
    {
        public int FornecedorId { get; set; }
        public string NomeEmpresa { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Sends an email to welcome a new vendor.
        /// </summary>
        /// <returns></returns>
        public string EnviaEmailBoasVindas(string mensagem)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.NomeEmpresa).Trim();
            var confirmation = emailService.EnviaMensagem(subject,
                                                        mensagem, 
                                                        this.Email);
            return confirmation;
        }
    }
}
