using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MySalon_Master.Models
{
    public class ApplicationUser: IdentityUser
    {
        public override string Email { get; set; }
    }
}
