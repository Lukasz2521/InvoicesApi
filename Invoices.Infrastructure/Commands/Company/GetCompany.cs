using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Infrastructure.Commands.Company
{
    public class GetCompany: ICommand
    {
        public string CompanyName { get; set; }

        public string Nip { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public string Site { get; set; }

        public string Krs { get; set; }

        public string BankName { get; set; }

        public string AccountNr { get; set; }

        public string SwiftNr { get; set; }
    }
}
