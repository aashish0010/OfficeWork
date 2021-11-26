using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Models
{
    public class UserRoles : IdentityRole
    {
        public string UserId { get; set; }
        public string RoleName { get; set; }
    }
}
