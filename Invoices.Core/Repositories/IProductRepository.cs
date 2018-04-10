using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;

namespace Invoices.Core.Repositories
{
    public interface IProductRepository
    {
        Product Get(int productId);

        IList<Product> GetAll(int companyId);

        bool Add(int companyId);
    }
}
