using Invoices.Core.Domain;
using Invoices.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Infrastructure.Services
{
    public interface IUserService
    {
        Task CreateAsync(UserDTO user);

        Task<UserDTO> AuthenticateAsync(string username, string password);
    }
}
