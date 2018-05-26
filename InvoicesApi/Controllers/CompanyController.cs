using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Invoices.Infrastructure.DTO;
using Invoices.Infrastructure.Services;
using Invoices.Infrastructure.Commands.Company;
using AutoMapper;

namespace Invoices.Api.Controllers
{
    [Route("company/[action]")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public CompanyController(ICompanyService companyService, IMapper mapper, IConfiguration configuration)
        {
            _companyService = companyService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("company/add")]
        public async Task Post([FromBody]CreateCompany company)
        {
            await _companyService.AddAsync( _mapper.Map<CreateCompany, CompanyDTO>(company));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var company = await _companyService.GetAsync(id);
            if (company == null)                                                                                                 
                return NotFound();

            return Ok(_mapper.Map<CompanyDTO, GetCompany>(company)); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //var company = _mapper.Map<CompanyDTO, GetCompany>(_companyService.Get(id));
            //if (company == null)
            //    return NotFound();

            return NoContent();
        }
    }
}