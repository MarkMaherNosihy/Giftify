﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftify.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName{ get; set; }
        [Required]
        public string LastName { get; set; }
        public string? StreetAddress { get; set; }
        public string? City{ get; set; }
        public string? Governorate { get; set; }
        public string? PostalCode { get; set; }

    }
}
