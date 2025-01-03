﻿namespace TMS_Gate.Models
{
    public class ICD_TruckProcess
    {
        public int InRegNo { get; set; } 
        public string InPCCode { get; set; }//Category//mandatory
        public string InType { get; set; }//FCL,LCL
        public string InCargoType { get; set; }//Laden,MT
        public string InCargoInfo { get; set; }
        public string InCheckDateTime { get; set; }
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
        public string GroupName { get; set; }
        public string OutCheckDateTime { get; set; }
        public string OutGatePassTime { get; set; }
        public string InGatePassTime { get; set; }     
        public string InWeightDateTime { get; set; }
        public string OutWeightDateTime { get; set; }
        public string JobDept { get; set; }
        public string JobCode { get; set; }
        public string JobType { get; set; }
        public string BlNo { get; set; }
        public int? GRNNo { get; set; }
        public int? GDNNo { get; set; }
        public int? PropNo { get; set; }
        public string OptStartDate { get; set; }//OperationStart
        public string OptEndDate { get; set; }
    }
}
