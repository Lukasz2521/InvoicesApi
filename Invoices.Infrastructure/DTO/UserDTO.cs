using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Infrastructure.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int CompanyId { get; set; }
    }
}
