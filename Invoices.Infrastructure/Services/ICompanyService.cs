﻿using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;
using System.Threading.Tasks;

namespace Invoices.Infrastructure.Services
{
    public interface ICompanyService
    {
        Task<CompanyDTO> Get(int id);

        Task Add(CompanyDTO company);
    }
}
