using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Invoices.Infrastructure.Services;

namespace Invoices.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService; 

        public ProductController(IProductService productService)
        {
            _productService = productService;            
        }
    }
}