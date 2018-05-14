using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Invoices.Infrastructure.Commands.User;

namespace Invoices.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        public UserController()
        {

        }

        public IActionResult Register([FromBody]CreateUser)
        {
            
        }
    }
}