using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Models
{
    public class Designation
    {
        public int Id { get; set; }
        public string DesignationName { get; set; }
        public string ComId { get; set; }
        public string CustomerId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
