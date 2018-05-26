using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public int CompanyId { get; set; }
    }
}
