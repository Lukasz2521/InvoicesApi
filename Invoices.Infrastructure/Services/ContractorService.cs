using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Services
{
    public sealed class ContractorService : IContractorService
    {
        public bool Add(int SellerId, int ContractorId)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDTO> GetAll(int sellerId)
        {
            throw new NotImplementedException();
        }
    }
}
