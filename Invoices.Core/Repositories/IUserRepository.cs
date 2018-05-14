using Invoices.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Core.Repositories
{
    public interface IUserRepository
    {
        Task Create(User user);
    }
}
