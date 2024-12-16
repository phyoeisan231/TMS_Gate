using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Gate.Models
{
    public class ICD_TruckProcess
    {
        public int InRegNo { get; set; } 
        public string InPCCode { get; set; }//Category//mandatory
        public string InType { get; set; }//FCL,LCL
        public string InCargoType { get; set; }//Laden,MT
        public string InCargoInfo { get; set; }
        public DateTime? InCheckDateTime { get; set; }
        public string AreaID { get; set; }
        public string TruckType { get; set; }
        public string TruckVehicleRegNo { get; set; }
        public string TrailerVehicleRegNo { get; set; }
        public string DriverLicenseNo { get; set; }
        public string DriverContactNo { get; set; }
        public string DriverName { get; set; }
        public string CardNo { get; set; }
        public string Status { get; set; }
        public string Customer { get; set; }
        public string InWeightBridgeID { get; set; }
        public string OutWeightBridgeID { get; set; }
        public int? OutRegNo { get; set; } 
        public string OutPCCode { get; set; }//Category//mandatory
        public string OutType { get; set; }
        public string OutCargoType { get; set; }
        public string OutCargoInfo { get; set; }
        public DateTime? OutCheckDateTime { get; set; }
    }
}
