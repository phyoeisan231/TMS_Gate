using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Gate.Models
{
    public class ICD_OutBoundCheck
    {
        public int OutRegNo { get; set; }//mandatory
        public string OutYardID { get; set; }//mandatory
        public string OutGateID { get; set; }//mandatory
        public string OutPCCode { get; set; }//Category//mandatory
        public string OutType { get; set; }//FCL,LCL
        public string OutCargoType { get; set; }//Laden,MT
        public string OutCargoInfo { get; set; }
        public string OutCheckDateTime { get; set; }
        public string AreaID { get; set; }
        public string TruckType { get; set; }
        public string TruckVehicleRegNo { get; set; }
        public string TrailerVehicleRegNo { get; set; }
        public string DriverLicenseNo { get; set; }
        public string DriverContactNo { get; set; }
        public string DriverName { get; set; }
        public string CardNo { get; set; }
        public string TransporterID { get; set; }
        public string TransporterName { get; set; }
        public string Customer { get; set; }
        public string InWeightBridgeID { get; set; }
        public string OutWeightBridgeID { get; set; }
        public IFormFile UploadPhoto { get; set; }
        public int InRegNo { get; set; }//mandatory
    }
}
