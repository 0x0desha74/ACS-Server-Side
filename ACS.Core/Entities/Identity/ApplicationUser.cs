using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS.Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsIdentityVerified { get; set; }
        public string IdentityIamgeUrl { get; set; }
    }
}
