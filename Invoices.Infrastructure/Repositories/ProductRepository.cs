using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public bool Add(int companyId)
        {
            throw new NotImplementedException();
        }

        public Product Get(int productId)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll(int companyId)
        {
            throw new NotImplementedException();
        }
    }
}
