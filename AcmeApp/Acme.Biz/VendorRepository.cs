﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        public Fornecedor Retrieve(int vendorId)
        {
            // Create the instance of the Fornecedor class
            Fornecedor vendor = new Fornecedor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.FornecedorId = 1;
                vendor.NomeEmpresa = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public bool Save(Fornecedor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
