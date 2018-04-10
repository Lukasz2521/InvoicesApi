using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;

namespace Invoices.Infrastructure.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        public bool Add(int SellerId, int ContractorId)
        {
            throw new NotImplementedException();
        }

        public IList<Company> GetAll(int sellerId)
        {
            throw new NotImplementedException();
        }
    }
}
