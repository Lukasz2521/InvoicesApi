using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Invoices.Infrastructure.Repositories;
using Invoices.Core.Repositories;
using Invoices.Core.Domain;

namespace InvoicesApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public ValuesController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        // GET api/values
        [HttpGet]
        public Company Get()
        {
            Company myCompany = _companyRepository.Get(2);
            return myCompany;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
