using Invoices.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Infrastructure.Services
{
    interface IUserService
    {
        Task Create(UserDTO user);
    }
}
