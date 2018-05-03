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
    //[Produces("application/json")]
    //[Route("[controller]")]

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
        public void Post([FromBody]CreateCompany company)
        {
            _companyService.Add(_mapper.Map<CreateCompany, CompanyDTO>(company));
        }
    }
}