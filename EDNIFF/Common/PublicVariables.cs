using EDNIFF.APIModels;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public class PublicVariables
    {
        public static string Username { get; set; }
        public static string WebApiURL { get; set; }
        //public const string WebApiURL = "http://192.168.2.14:91/api";
        //public const string WebApiURL = "https://localhost:44346/api";
        public static AuthDetails authDetails { get; set; }
        public static bool TestPerformed { get; set; }
        public static double RAMSize { get; set; }
        public static List<SystemPort> PortData { get; set; }
        public static List<HDDSmartInfo> HDDSmartInfo { get; set; }
        public static string noofPorts { get; set; }
    }
}
