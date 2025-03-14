﻿using Acme.Biz;

namespace Acme.Wpf.ViewModels
{
    public class VendorDetailViewModel
    {
        public Fornecedor currentVendor { get; set; }

        VendorRepository vendorRepository = new VendorRepository();

        public VendorDetailViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            currentVendor = vendorRepository.Retrieve(1);
        }
    }
}
