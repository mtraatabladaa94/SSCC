﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    public class SaleImportEntity
    {

        public string SaleCode { get; set; }

        public DateTime SaleDate { get; set; }

        public string CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal ProductQuantity { get; set; }

        public decimal ProductIVA { get; set; }

        public decimal SaleTotal { get; set; }

    }
}
