using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public decimal NettoPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal Vat { get; set; }

        public decimal DiscountedPriceNetto { get; set; }

        public decimal BruttoPrice { get; set; }
    }
}
