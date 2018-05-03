using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;
using Dapper;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Repositories
{
    public class CompanyRepository : BaseRespository, ICompanyRepository
    {
        public void Add(Company company)
        {
           Execute("INSERT INTO Company(Nip, CompanyName) VALUES(@Nip, @CompanyName);", new { Nip = company.Nip, CompanyName = company.CompanyName });
        }

        public Company Get(int id)
        {
            //Query<CompanyDTO>("SELECT * FROM Company WHERE id = @id", new { id });

            return new Company()
            {
                BankName = "Ing",
                AccountNr = "72347236427364723",
                Adress = "qwewqe",
                CompanyName = "qeweq",
                Email = "dsdsad@wp.pl",
                Id = 1,
                Krs = "4534534",
                Site = "dffsdfsd",
                Nip = "1111111111",
                Tel = "32423423",
                SwiftNr = "fdssdfsfsd"
            };
        }
    }
}
