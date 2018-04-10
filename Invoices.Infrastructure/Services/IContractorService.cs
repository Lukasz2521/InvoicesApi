using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Services
{
    public interface IContractorService
    {
        IList<CompanyDTO> GetAll(int sellerId);

        bool Add(int SellerId, int ContractorId);
    }
}
