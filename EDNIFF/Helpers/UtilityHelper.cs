using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Helpers
{
    class UtilityHelper
    {
        //public enum ConversionUnit
        //{
        //    Size,
        //    SpeedBits,
        //    SpeedHtz
        //}
        //public static string GetSizeInKbMbGb(object NoOfbytes, ConversionUnit conversion)// bool isSpeed = false)
        //{
        //    double total = 0;
        //    string unit = "";

        //    switch (conversion)
        //    {
        //        case ConversionUnit.Size:
        //            unit = "B";
        //            break;
        //        case ConversionUnit.SpeedBits:
        //            unit = "bps";
        //            break;
        //        case ConversionUnit.SpeedHtz:
        //            unit = "Hz";
        //            break;
        //    }
        //    double divder = conversion == ConversionUnit.Size ? 1024 : 1000;
        //    double.TryParse(NoOfbytes.ToString(), out total);
        //    total = total / divder;
        //    if (total >= divder)
        //    {
        //        total = total / divder;
        //        if (total >= divder)
        //        {
        //            total = total / divder;

        //            return total.ToString() + " G" + unit;
        //            //return Math.Ceiling(total).ToString() + " G" + unit;
        //            //return Math.Round(total, 0).ToString() + " GB";
        //        }
        //        else
        //        {
        //            return total.ToString() + " M" + unit;
        //            //return Math.Ceiling(total).ToString() + " M" + unit;
        //            //return Math.Round(total, 0).ToString() + " MB";
        //        }
        //    }
        //    else
        //    {
        //        return total.ToString() + " K" + unit;
        //        //return Math.Ceiling(total).ToString() + " K" + unit;
        //        //return Math.Round(total, 0).ToString() + " KB";
        //    }
        //}
        public static string GetDataSize(object NoOfbytes)
        {
            if (NoOfbytes.ToString() == "" || NoOfbytes.ToString() == "0")
                return string.Empty;

            return GetSize(NoOfbytes, 1024) + "B";
        }
        public static string GetDataSizeHDD(object NoOfbytes)
        {
            if (NoOfbytes.ToString() == "" || NoOfbytes.ToString() == "0")
                return string.Empty;
            return GetSize(NoOfbytes, 1000) + "B";
        }
        public static string GetNetworkSpeed(object NoOfBits)
        {
            return GetSize(NoOfBits, 1000) + "bps";
        }
        public static string GetProcessingSpeed(object NoOfMHz)
        {
            //return GetSize(NoOfMHz, 1000, 2) + "Hz";
            double total;
            double.TryParse(NoOfMHz.ToString(), out total);
            total = total / 1000;
            return Math.Round(total, 1).ToString() + " GHz";
        }
        static string GetSize(object value, double divder)//, int level = 0)
        {
            double total;
            double.TryParse(value.ToString(), out total);
            //if (level == 1)
            //    total = total * divder;
            //else if (level == 2)
            //    total = total * divder * divder;
            //else if (level == 3)
            //    total = total * divder * divder * divder;

            total = total / divder;
            if (total >= divder)
            {
                total = total / divder;
                if (total >= divder)
                {
                    total = total / divder;
                    return Math.Round(total, 0).ToString() + " G";
                }
                else
                {
                    return Math.Round(total, 0).ToString() + " M";
                }
            }
            else
            {
                return Math.Round(total, 0).ToString() + " K";
            }
        }

        public static string GetDataFromIntString(string intString)
        {
            string manu = string.Empty;
            var str = intString.Split('&');
            foreach (var item in str)
            {
                int n;
                int.TryParse(item, out n);
                if (n > 0)
                    manu += Convert.ToChar(n);
            }
            return manu.Trim();
        }
    }
}
