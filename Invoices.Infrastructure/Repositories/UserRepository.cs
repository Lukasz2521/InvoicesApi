using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;

namespace Invoices.Infrastructure.Repositories
{
    class UserRepository : BaseRespository, IUserRepository
    {
        public Task Create(User user)
        {
            throw new NotImplementedException();
        }
    }
}
