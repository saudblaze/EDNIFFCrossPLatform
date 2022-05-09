using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;
using static EDNIFF.Models.DeviceProps;

namespace EDNIFF.BusinessLogic
{
    abstract class BaseHardwareInfo
    {
        List<HardwareDevice> GetHardwareInfo(string query, string scope = "ROOT\\CIMV2")
        {
            List<HardwareDevice> hardwares = new List<HardwareDevice>();
            
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                if (searcher.Get() == null || searcher.Get().Count == 0)
                {
                    string myString = query.Remove(query.IndexOf("where Status='Ok'"), "where Status='Ok'".Length);
                    searcher = new ManagementObjectSearcher(scope, myString);
                }
                foreach (ManagementObject share in searcher.Get())
                {
                    HardwareDevice hrd = new HardwareDevice();
                    try
                    {
                        if (share["Name"] != null)
                            hrd.Name = share["Name"].ToString().Trim();
                        else
                            hrd.Name = share.ToString().Trim();
                    }
                    catch
                    {
                        hrd.Name = share.ToString().Trim();
                    }
                    foreach (PropertyData PC in share.Properties)
                    {
                        HardwareProperty property = new HardwareProperty();
                        property.Name = PC.Name;

                        //if(PC.Type==CimType.Object || PC.Type==CimType.Reference)
                        //{
                        //    var da = PC.Value;
                        //}
                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;
                                    //property.isValueArray = true;
                                    //property.ValueArray = str;
                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + "&";

                                    property.Value = str2.Trim('&');
                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;
                                    //property.isValueArray = true;
                                    //string[] tstr2 = new string[shortData.Length];
                                    string tstr2 = "";
                                    for (int i = 0; i < shortData.Length; i++)
                                    {
                                        tstr2 += shortData[i].ToString() + "&";
                                        //tstr2[i]= shortData[i].ToString();
                                    }
                                    property.Value = tstr2.Trim('&');
                                    //property.ValueArray = tstr2;
                                    break;

                                default:
                                    property.Value = PC.Value.ToString().Trim();
                                    break;
                            }
                        }

                        hrd.Properties.Add(property);
                    }
                    hardwares.Add(hrd);
                }
            }
            catch (Exception exp)
            {

            }
            return hardwares;
        }


        protected List<HardwareDevice> GetDevices(string DevicePath)
        {
            DevicePath = "select * from " + DevicePath;
            return GetHardwareInfo(DevicePath);
        }

        protected List<HardwareDevice> GetDevicesByScope(string DevicePath, string scope)
        {
            DevicePath = "select * from " + DevicePath;
            return GetHardwareInfo(DevicePath, scope);
        }
        protected List<HardwareDevice> GetDevicesByQuery(string Query)
        {
            //DevicePath = "select * from " + DevicePath;
            return GetHardwareInfo(Query);
        }
        protected List<HardwareDevice> GetDevicesWMI(string DevicePath)
        {
            DevicePath = "select * from " + DevicePath;
            return GetHardwareInfo(DevicePath, "ROOT\\WMI");
        }
        protected string GetDevicePropertyValue(HardwareDevice device, object propertyName)
        {
            var prop = device.Properties.FirstOrDefault(x => x.Name.ToLower() == propertyName.ToString().ToLower());
            if (prop == null || prop.Value == null)
                return string.Empty;
            else
                return prop.Value.Trim();
        }

        protected string GetDevicePropertyFormFactorValue(HardwareDevice device,object propertyName)
        {
            var prop = device.Properties.FirstOrDefault(x => x.Name.ToLower() == propertyName.ToString().ToLower());
            if (prop == null || prop.Value == null)
                return string.Empty;

            FormFactor reslt = (FormFactor) Convert.ToInt32(prop.Value);
            return reslt.ToString();
        }

        protected string GetDevicePropertyKeyValue(HardwareDevice device, DeviceNames deviceName, object propertyName)
        {
            var prop = device.Properties.FirstOrDefault(x => x.Name == propertyName.ToString());
            if (prop == null)
                return string.Empty;

            ///var reslt = tempDbContext.DataBase.GetMasterKeyValue(deviceName, prop.Name, prop.Value);
            ///return reslt;
            ///remember to uncomment
            return "";
        }


        public Device GetEmptyDevice(ConstantData.Categories category, ConstantData.DeviceNames deviceName, DeviceStatus deviceStatus = DeviceStatus.NotPresent)
        {
            Device device = new Device
            {
                Category = category,
                DeviceName = deviceName,
                deviceStatus = deviceStatus,
                validation = false
            };
            return device;
        }
        #region --code only for usb testing--

        protected HardwareDevice GetDeviceInfoForUSB(string deviceId)
        {
            string query = $"select * from Win32_pnpEntity where DeviceId='{deviceId}'";
            return GetHardwareInfoForUSB(query);
        }
        public HardwareDevice GetHardwareInfoForUSB(string query, string scope = "ROOT\\CIMV2")
        {

            HardwareDevice hrd = new HardwareDevice();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query.Replace("\\", "\\\\"));
            try
            {

                foreach (ManagementObject share in searcher.Get())
                {
                    var mparams = share.GetMethodParameters("GetDeviceProperties");
                    mparams["devicePropertyKeys"] = new string[] { "DEVPKEY_Device_LocationInfo", 
                        "DEVPKEY_Device_BusReportedDeviceDesc" };
                    //,"DEVPKEY_Device_BiosDeviceName" };//, "BusReportedDeviceDesc", "BiosDeviceName" };
                    InvokeMethodOptions moptions = new InvokeMethodOptions();
                    moptions.Context = new ManagementNamedValueCollection();
                    var outParams = share.InvokeMethod("GetDeviceProperties", mparams, moptions);
                    var demo = outParams.GetPropertyValue("deviceProperties");
                    ManagementBaseObject[] ob = demo as ManagementBaseObject[];
                    if (ob != null)
                    {
                        foreach (var item2 in ob)
                        {
                            if (item2.Properties.Count > 4)
                            {
                                var propname = item2.GetPropertyValue("KeyName");
                                var propval = item2.GetPropertyValue("Data").ToString();
                                hrd.Properties.Add(new HardwareProperty { Name = propname.ToString(), Value = propval.ToString() });
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {

            }
            return hrd;
        }

        #endregion
        //List<HardwareDevice> GetHardwareInfo(string Key)
        //{
        //    List<HardwareDevice> hardwares = new List<HardwareDevice>();
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
        //    try
        //    {
        //        foreach (ManagementObject share in searcher.Get())
        //        {
        //            HardwareDevice hrd = new HardwareDevice();
        //            try
        //            {
        //                if (share["Name"] != null)
        //                    hrd.Name = share["Name"].ToString();
        //                else
        //                    hrd.Name = share.ToString();

        //                if (share["Manufacturer"] != null)
        //                    hrd.Manufacturer = share["Manufacturer"].ToString();
        //                if (share["PNPClass"] != null)
        //                    hrd.PNPClass = share["PNPClass"].ToString();
        //                if (share["PNPDeviceId"] != null)
        //                    hrd.PNPDeviceId = share["PNPDeviceId"].ToString();
        //                if (share["Present"] != null)
        //                    hrd.Present = (bool)share["Present"];
        //                if (share["Status"] != null)
        //                    hrd.Status = share["Status"].ToString();
        //                if (share["Caption"] != null)
        //                    hrd.Caption = share["Caption"].ToString();
        //                if (share["Description"] != null)
        //                    hrd.Description = share["Description"].ToString();
        //                if (share["DeviceId"] != null)
        //                    hrd.DeviceId = share["DeviceId"].ToString();
        //                if (share["HardwareId"] != null)
        //                    hrd.HardwareId = share["HardwareId"].ToString();
        //            }
        //            catch
        //            {
        //                hrd.Name = share.ToString();
        //            }
        //            //if (share.Properties.Count <= 0)
        //            //{
        //            //    //MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            //    return;
        //            //}
        //            foreach (PropertyData PC in share.Properties)
        //            {
        //                HardwareProperty property = new HardwareProperty();
        //                property.Name = PC.Name;

        //                if (PC.Value != null && PC.Value.ToString() != "")
        //                {
        //                    switch (PC.Value.GetType().ToString())
        //                    {
        //                        case "System.String[]":
        //                            string[] str = (string[])PC.Value;

        //                            string str2 = "";
        //                            foreach (string st in str)
        //                                str2 += st + "&";

        //                            property.Value = str2.Trim('&');
        //                            break;
        //                        case "System.UInt16[]":
        //                            ushort[] shortData = (ushort[])PC.Value;
        //                            string tstr2 = "";
        //                            foreach (ushort st in shortData)
        //                                tstr2 += st.ToString() + "&";

        //                            property.Value = tstr2.Trim('&');
        //                            break;

        //                        default:
        //                            property.Value = PC.Value.ToString();
        //                            break;
        //                    }
        //                }

        //                hrd.Properties.Add(property);
        //            }
        //            hardwares.Add(hrd);
        //        }
        //    }
        //    catch (Exception exp)
        //    {

        //    }
        //    return hardwares;
        //}
    }
}
