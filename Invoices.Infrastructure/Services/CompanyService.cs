using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Invoices.Infrastructure.DTO;
using Invoices.Core.Repositories;
using Invoices.Core.Domain;
using AutoMapper;

namespace Invoices.Infrastructure.Services
{
    public sealed class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(CompanyDTO company)
        {
            if(company != null)
                await _companyRepository.AddAsync(_mapper.Map<CompanyDTO, Company>(company));
        }

        public async Task<CompanyDTO> GetAsync(int id)
        {
            var company = await _companyRepository.GetAsync(id); 

            return _mapper.Map<Company, CompanyDTO>(company);
        }
    }
}
