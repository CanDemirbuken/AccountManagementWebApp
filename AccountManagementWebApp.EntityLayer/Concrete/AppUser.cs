﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementWebApp.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstNane { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}