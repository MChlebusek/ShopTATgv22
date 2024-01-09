using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class ApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string City { get; set; }
    }
}
