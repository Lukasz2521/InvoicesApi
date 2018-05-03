using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;

namespace Invoices.Core.Repositories
{
    public interface ICompanyRepository
    {
        Company Get(int id);

        void Add(Company company);
    }
}
