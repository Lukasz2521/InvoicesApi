using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;
using Invoices.Core.Repositories;
using Invoices.Core.Domain;
using AutoMapper;

namespace Invoices.Infrastructure.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public void Add(CompanyDTO company)
        {
            if(company != null)
                _companyRepository.Add(_mapper.Map<CompanyDTO, Company>(company));
        }

        public CompanyDTO Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
