using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Gate.Model
{
    public class PCard
    {
        public string CardNo { get; set; }
        public string YardID { get; set; }
        public string GroupName { get; set; }
        public Boolean Active { get; set; }
        public Boolean IsUse { get; set; }
        public string VehicleRegNo { get; set; }
        public DateTime CardIssueDate { get; set; }
        public DateTime CardReturnDate { get; set; }
    }
}
