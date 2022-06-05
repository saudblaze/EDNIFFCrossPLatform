using EDNIFF.APIModels;
using EDNIFF.Common;
using EDNIFF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EDNIFF.Helpers.ConstantData;

namespace EDNIFF.BusinessLogic
{
    public class TestServices
    {
        public async Task<int> SaveMethod(MainSaveMethodParam obj)
        {
            try
            {
                var dict = new Dictionary<string, object>();
                foreach (ReportProps prop in Enum.GetValues(typeof(ReportProps)))
                {
                    switch (prop)
                    {
                        case ReportProps.KeyboardLng:
                            dict.Add(prop.ToString(), KeyboardLanguage);
                            break;
                        case ReportProps.MADEIN:
                            dict.Add(prop.ToString(), Madein);
                            break;
                        case ReportProps.COA:
                            dict.Add(prop.ToString(), OSCOA);
                            break;
                        case ReportProps.ObservNotes:
                            dict.Add(prop.ToString(), ObservationComment);
                            break;
                        case ReportProps.UnitId:
                            dict.Add(prop.ToString(), UnitId);
                            break;
                        case ReportProps.Grade:
                            dict.Add(prop.ToString(), Grade);
                            break;
                        case ReportProps.BatteryBackup:
                            if (!string.IsNullOrEmpty(batterybackupresult))
                                dict.Add(prop.ToString(), batterybackupresult);
                            break;
                        //case ReportProps.RAM:
                        //    dict.Add(prop.ToString(), UtilityHelper.GetDataSize(PublicVariables.RAMSize));
                        //    break;

                        case ReportProps.PartNumber:
                            dict.Add(prop.ToString(), PartNumber);
                            break;
                        case ReportProps.RAM:
                            dict.Add(prop.ToString(), RamSize);
                            break;
                        case ReportProps.StorageType:
                            dict.Add(prop.ToString(), DiskType);
                            break;
                        case ReportProps.StorageSize:
                            dict.Add(prop.ToString(), DiskSize);
                            break;

                        case ReportProps.Resolution:
                            dict.Add(prop.ToString(), VideoRes);
                            break;
                        case ReportProps.DisplaySize:
                            dict.Add(prop.ToString(), LCDSize);
                            break;

                        //case ReportProps.StorageHealth:
                        //    dict.Add(prop.ToString(), UtilityHelper.GetDataSize(PublicVariables.RAMSize));
                        //    break;
                        default:
                            dict.Add(prop.ToString(), system.getPropertyValue(result, prop));
                            break;
                    }

                }

                dict.Add("NoOfPorts", PublicVariables.noofPorts);



                //HttpAPIRequests httpRequest = new HttpAPIRequests();
                //var response = await httpRequest.PostRequest<AuthDetails>(obj.Username.Trim(), obj.Password);
                //if (response.hasError)
                //{
                    
                //}
                //else
                //{
                //}


                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }


            
        }
    }
}
