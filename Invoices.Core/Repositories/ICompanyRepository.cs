using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using System.Threading.Tasks;

namespace Invoices.Core.Repositories
{
    public interface ICompanyRepository
    {
        Task<Company> Get(int id);

        Task Add(Company company);
    }
}
