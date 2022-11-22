﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BNS_Final.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }

    }
}
