using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Core.Domain
{
    public class Invoice
    {
        public int Id { get; set; }

        public int SellerId { get; set; }

        public int RecipientId { get; set; }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfIssue { get; set; }

        public DateTime SellDate { get; set; }

        public DateTime EndDate { get; set; }

        public string PlaceOfIssue { get; set; }
    }
}
