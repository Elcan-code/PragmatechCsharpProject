﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Entities
{
    public class User
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
