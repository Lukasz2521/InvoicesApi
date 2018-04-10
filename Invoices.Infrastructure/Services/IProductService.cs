using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Services
{
    public interface IProductService
    {
        ProductDTO Get(int productId);

        IList<ProductDTO> GetAll(int companyId);

        bool Add(int companyId);
    }
}
