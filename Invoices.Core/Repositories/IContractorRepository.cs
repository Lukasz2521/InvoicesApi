using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;

namespace Invoices.Core.Repositories
{
    public interface IContractorRepository
    {
        IList<Company> GetAll(int sellerId);

        bool Add(int SellerId, int ContractorId);
    }

}
