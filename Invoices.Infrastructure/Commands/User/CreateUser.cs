using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Infrastructure.Commands.User
{
    public class CreateUser: ICommand
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
