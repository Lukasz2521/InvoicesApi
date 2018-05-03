using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Services
{
    public interface ICompanyService
    {
       CompanyDTO Get(int id);

       void Add(CompanyDTO company);
    }
}
