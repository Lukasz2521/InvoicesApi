using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Invoices.Core.Domain;
using Invoices.Core.Repositories;

namespace Invoices.Infrastructure.Repositories
{
    public class UserRepository : BaseRespository, IUserRepository
    {
        public async Task CreateAsync(User user)
        {
            await Execute("INSERT INTO Users(Username, PasswordHash, PasswordSalt) VALUES(@Username, @PasswordHash, @PasswordSalt)",
            new
            {
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt
            });
        }

        public async Task<User> GetAsync(string username)
        {
            var user = await QuerySingle<User>("SELECT * FROM Users WHERE Username = @Username", new { Username = username });

            return user;
        }
    }
}
