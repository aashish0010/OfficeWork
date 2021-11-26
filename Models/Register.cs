using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Models
{
    public class Register :IdentityUser
    {
        public string Device_id { get; set; }

        public string DateOfBirth { get; set; }
        public string Contact { get; set; }

        public string BloodGroup { get; set; }
        public string UserType { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string First_name { get; set; }
        public string Middle_name { get; set; }
        public string Last_name { get; set; }
        public string NickName { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Designation { get; set; }
        public string DesignationDate { get; set; }
        public string Company_id { get; set; }
        public string Department { get; set; }
        public string Branch { get; set; }

        public string Fb { get; set; }
        public string Linkedin { get; set; }
        public string Image { get; set; }
        public string City { get; set; }

        public DateTime UpdateDate { get; set; }
        public DateTime Addeddate { get; set; } = DateTime.Now;

        public DateTime EntrollDate { get; set; }
        
    }
}
