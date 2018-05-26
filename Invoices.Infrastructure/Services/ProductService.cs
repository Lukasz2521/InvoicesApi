using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;
using AutoMapper;

namespace Invoices.Infrastructure.Services
{
    sealed class ProductService : IProductService
    {
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public bool Add(int companyId)
        {
            throw new NotImplementedException();
        }

        public ProductDTO Get(int productId)
        {
            throw new NotImplementedException();
        }

        public IList<ProductDTO> GetAll(int companyId)
        {
            throw new NotImplementedException();
        }
    }
}
