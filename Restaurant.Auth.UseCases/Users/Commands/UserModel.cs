﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Auth.UseCases.Users.Commands
{
    public class UserModel
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}