using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Core.Domain
{
    public class Contractor
    {
        public int Id { get; set; }

        public int SellerId { get; set; }

        public int ContractorId { get; set; }

    }
}
