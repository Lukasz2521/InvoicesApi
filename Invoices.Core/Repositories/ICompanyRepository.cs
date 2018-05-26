using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using System.Threading.Tasks;

namespace Invoices.Core.Repositories
{
    public interface ICompanyRepository
    {
        Task<Company> GetAsync(int id);

        Task AddAsync(Company company);
    }
}
