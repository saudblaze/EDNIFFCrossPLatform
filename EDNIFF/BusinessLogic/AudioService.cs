﻿using EDNIFF.Common;
using EDNIFF.Helpers;
using EDNIFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.BusinessLogic
{
    class AudioService : BaseHardwareInfo
    {
        public void GetAudio()
        {
            try
            {
                string strtemp = GetInfoString(ConstantData.DevicePaths.Audio);

                string[] linesArr = strtemp.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                SPAudioDataType SPAudioDataType = new SPAudioDataType();

                bool blnBuiltInMicrophone = false;
                bool blnBuiltinOutput = false;

                foreach (string items in linesArr)
                {                    

                    if (items.ToString().Contains("Built-in Microphone"))
                    {
                        blnBuiltInMicrophone = true;
                        blnBuiltinOutput = false;
                        SPAudioDataType.BuiltInMicrophone = new BuiltInMicrophone();
                    }

                    if (items.ToString().Contains("Built-in Output"))
                    {
                        blnBuiltinOutput = true;
                        blnBuiltInMicrophone = false;
                        SPAudioDataType.BuiltInOutput = new BuiltInOutput();
                    }

                    //BuiltInMicrophone
                    if (blnBuiltInMicrophone == true && items.ToString().Contains("Default Input Device"))
                    {
                        SPAudioDataType.BuiltInMicrophone.DefaultInputDevice = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltInMicrophone == true && items.ToString().Contains("Input Channels"))
                    {
                        SPAudioDataType.BuiltInMicrophone.InputChannels = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltInMicrophone == true && items.ToString().Contains("Manufacturer"))
                    {
                        SPAudioDataType.BuiltInMicrophone.Manufacturer = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltInMicrophone == true && items.ToString().Contains("Current SampleRate"))
                    {
                        SPAudioDataType.BuiltInMicrophone.CurrentSampleRate = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltInMicrophone == true && items.ToString().Contains("Transport"))
                    {
                        SPAudioDataType.BuiltInMicrophone.Transport = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltInMicrophone == true && items.ToString().Contains("Input Source"))
                    {
                        SPAudioDataType.BuiltInMicrophone.InputSource = GetPropertyValue(items.ToString());
                    }


                    //BuiltInOutput
                    if (blnBuiltinOutput == true && items.ToString().Contains("Default Output Device"))
                    {
                        SPAudioDataType.BuiltInOutput.DefaultOutputDevice = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltinOutput == true && items.ToString().Contains("Default System Output Device"))
                    {
                        SPAudioDataType.BuiltInOutput.DefaultSystemOutputDevice = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltinOutput == true && items.ToString().Contains("Manufacturer"))
                    {
                        SPAudioDataType.BuiltInOutput.Manufacturer = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltinOutput == true && items.ToString().Contains("Output Channels"))
                    {
                        SPAudioDataType.BuiltInOutput.OutputChannels = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltinOutput == true && items.ToString().Contains("Current SampleRate"))
                    {
                        SPAudioDataType.BuiltInOutput.CurrentSampleRate = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltinOutput == true && items.ToString().Contains("Transport"))
                    {
                        SPAudioDataType.BuiltInOutput.Transport = GetPropertyValue(items.ToString());
                    }
                    if (blnBuiltinOutput == true && items.ToString().Contains("Output Source"))
                    {
                        SPAudioDataType.BuiltInOutput.OutputSource = GetPropertyValue(items.ToString());
                    }
                }

                MacInfo.Audio = SPAudioDataType;

            }
            catch (System.ComponentModel.Win32Exception exception)
            {

            }
        }
    }
}
