﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Auth.Contracts
{
    public sealed record UserDto(Guid id, string email, string name, DateTime registrationDT);
}