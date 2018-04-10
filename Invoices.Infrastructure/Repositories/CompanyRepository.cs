using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;

namespace Invoices.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public Company Get(int id)
        {
            return new Company()
            {
                BankName = "Ing",
                AccountNr = "72347236427364723",
                Adress = "qwewqe",
                CompanyName = "qeweq",
                Email = "dsdsad@wp.pl",
                Id = 1,
                Krs = "4534534",
                Site = "dffsdfsd"
            };
        }
    }
}
