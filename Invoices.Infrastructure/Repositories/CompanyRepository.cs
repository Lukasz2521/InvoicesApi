using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;
using Dapper;
using Invoices.Infrastructure.DTO;
using System.Threading.Tasks;

namespace Invoices.Infrastructure.Repositories
{
    public class CompanyRepository : BaseRespository, ICompanyRepository
    {
        public async Task Add(Company company)
        {
           await Execute("INSERT INTO Company(Nip, CompanyName) VALUES(" +
               "@Nip, @CompanyName, @Adress, @Email, @Tel, " +
               "@Website, @Krs, @BankName, @AccountNr, @SwiftNr" +
               ");", 
               new {                 
                   Nip = company.Nip,
                   CompanyName = company.CompanyName,
                   Adress = company.Adress   ,
                   Email = company.Email,
                   Tel = company.Tel,
                   Website = company.Site,
                   Krs = company.Krs,
                   BankName = company.BankName,
                   AccountNr = company.AccountNr,
                   SwiftNr = company.SwiftNr,
               });
        }

        public async Task<Company> Get(int id)
        {
            var company = await QuerySingle<Company>("SELECT * FROM Company WHERE id = @id", new { id });

            return company;
        }
    }
}
