﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Gate
{
    public class CommonData
    {
        public static string ApiUrl = "https://192.168.1.174:45456";
        public static int count = 0;
        public static List<string> truckStatuslist = new List<string> { "In(Check)", "In", "Out(Check)", "Out" };
    }
}