using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Provide Department Name")]
        public string DepartmentName { get; set; }
        public string Headid { get; set; }
        public string Companyid { get; set; }
        public string Clientid { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime UpdateDate { get; set; }
    }
}
