﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Domain.Models
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role {get; set }


    }
}
