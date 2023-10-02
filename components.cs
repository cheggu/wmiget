using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;
using System.Windows.Forms;


namespace Hardware
{
    class components
    {
        public struct Info
        {
            public List<string> Data;
            public List<ManagementObject> ObjectCount;
        }

        public Info GetCpuInfo()
        {
            //List<string> info = new List<string> { };
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };


            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection mbsList = mos.Get();

            foreach (ManagementObject mo in mbsList)
            {
                info.Data.Add(mo["Description"]?.ToString()); //description
                info.Data.Add(mo["ProcessorId"]?.ToString()); //part number?
                info.Data.Add(mo["DeviceID"]?.ToString()); //device id?
                info.Data.Add(mo["Name"]?.ToString()); //name
                info.Data.Add(mo["SerialNumber"]?.ToString()); //sn
                info.Data.Add(mo["InstallDate"]?.ToString()); //install date
                info.Data.Add(mo["Manufacturer"]?.ToString()); //manuf
                info.Data.Add(mo["PartNumber"]?.ToString()); //part number?
                info.Data.Add(mo["PNPDeviceID"]?.ToString()); //advanced part id
                info.Data.Add(mo["Status"]?.ToString()); //status
                info.Data.Add(mo["SystemName"]?.ToString()); //system name
                info.Data.Add(mo["UniqueId"]?.ToString()); //unique id
                info.Data.Add(mo["Version"]?.ToString()); //version
                info.Data.Add(mo["VirtualizationFirmwareEnabled"]?.ToString()); //virtualization enabled?
                info.Data.Add(mo["MaxClockSpeed"]?.ToString()); //max clock speed

                info.ObjectCount.Add(mo);
            }



            //foreach (string item in info)
            //{
            //    MessageBox.Show(item);
            //}

            mos.Dispose();
            mbsList.Dispose();
            return info;
        }

        public Info GetRamInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectCollection moc = mos.Get();
            //MessageBox.Show(moc.Count.ToString());
            foreach (ManagementObject mo in moc)
            {
                info.Data.Add(mo["Capacity"].ToString()); //Capacity
                info.Data.Add(mo["ConfiguredClockSpeed"].ToString()); //ConfiguredClockSpeed
                info.Data.Add(mo["Description"].ToString()); //Description;
                info.Data.Add(mo["FormFactor"].ToString()); //FormFactor;
                //info.Add(mo["InstallDate"].ToString()); //InstallDate
                info.Data.Add(mo["Manufacturer"].ToString()); //Manufacturer
                //info.Add(mo["Model"].ToString()); //Model
                info.Data.Add(mo["Name"].ToString()); //Name
                info.Data.Add(mo["PartNumber"].ToString()); //PartNumber
                info.Data.Add(mo["SerialNumber"].ToString()); //SerialNumber
                info.Data.Add(mo["Speed"].ToString()); //Speed
                info.Data.Add(mo["Caption"].ToString()); //Caption
                //info.Add(mo["Status"].ToString()); //Status
                info.Data.Add(mo["Tag"].ToString()); //Tag
                //info.Add(mo["Version"].ToString()); //Version

                info.ObjectCount.Add(mo);
            }

            mos.Dispose();
            moc.Dispose();

            return info;
        }



        public Info GetHddInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                if (mo["Model"].ToString().Contains("SSD"))
                {
                    continue;
                }
                else
                {
                    info.Data.Add(mo["MediaType"]?.ToString()); //Caption
                    info.Data.Add(mo["Description"]?.ToString()); //Description;
                    info.Data.Add(mo["DeviceID"]?.ToString()); //DeviceID;
                    info.Data.Add(mo["Manufacturer"]?.ToString()); //Manufacturer
                    info.Data.Add(mo["Model"]?.ToString()); //Model
                    info.Data.Add(mo["Name"]?.ToString()); //Name
                    info.Data.Add(mo["PNPDeviceID"]?.ToString()); //PNPDeviceID
                    info.Data.Add(mo["SerialNumber"]?.ToString()); //SerialNumber
                    info.Data.Add(mo["Size"]?.ToString()); //Size
                    info.Data.Add(mo["Status"]?.ToString()); //Status
                    info.Data.Add(mo["SystemName"]?.ToString()); //SystemName
                    info.Data.Add(mo["BytesPerSector"]?.ToString()); //BytesPerSector

                    info.ObjectCount.Add(mo);
                } 
            }

            mos.Dispose();
            moc.Dispose();

            return info;
        }

        public Info GetSsdInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                if (mo["Model"].ToString().Contains("SSD"))
                {
                    info.Data.Add(mo["Caption"]?.ToString()); //Caption
                    info.Data.Add(mo["Description"]?.ToString()); //Description;
                    info.Data.Add(mo["DeviceID"]?.ToString()); //DeviceID;
                    info.Data.Add(mo["Manufacturer"]?.ToString()); //Manufacturer
                    info.Data.Add(mo["Model"]?.ToString()); //Model
                    info.Data.Add(mo["Name"]?.ToString()); //Name
                    info.Data.Add(mo["PNPDeviceID"]?.ToString()); //PNPDeviceID
                    info.Data.Add(mo["SerialNumber"]?.ToString()); //SerialNumber
                    info.Data.Add(mo["Size"]?.ToString()); //Size
                    info.Data.Add(mo["Status"]?.ToString()); //Status
                    info.Data.Add(mo["SystemName"]?.ToString()); //SystemName
                    info.Data.Add(mo["BytesPerSector"]?.ToString()); //BytesPerSector

                    info.ObjectCount.Add(mo);
                }
                else
                {
                    continue;
                }
            }

            mos.Dispose();
            moc.Dispose();

            return info;
        }

        public Info GetGpuInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                info.Data.Add(mo["AdapterRAM"]?.ToString()); //AdapterRAM
                info.Data.Add(mo["Caption"]?.ToString()); //Caption
                info.Data.Add(mo["CurrentRefreshRate"]?.ToString()); //CurrentRefreshRate
                info.Data.Add(("X" + mo["CurrentHorizontalResolution"]?.ToString() + "Y" + mo["CurrentVerticalResolution"]?.ToString())); //Resolution
                info.Data.Add(mo["Description"]?.ToString()); //Description
                info.Data.Add(mo["DeviceID"]?.ToString()); //DeviceID
                info.Data.Add(mo["DriverVersion"]?.ToString()); //DriverVersion
                info.Data.Add(mo["Name"]?.ToString()); //Name
                info.Data.Add(mo["PNPDeviceID"]?.ToString()); //PNPDeviceID
                info.Data.Add(mo["SystemName"]?.ToString()); //SystemName
                info.Data.Add(mo["VideoArchitecture"]?.ToString()); //VideoArchitecture
                info.Data.Add(mo["VideoMemoryType"]?.ToString()); //VideoMemoryType
                info.Data.Add(mo["MaxRefreshRate"]?.ToString()); //MaxRefreshRate
                info.Data.Add(mo["VideoProcessor"]?.ToString()); //VideoProcessor

                info.ObjectCount.Add(mo);
            }

            mos.Dispose();
            moc.Dispose();

            return info;
        }

        public Info GetMbInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                info.Data.Add(mo["Caption"]?.ToString()); //Caption
                info.Data.Add(mo["Description"]?.ToString()); //Description
                info.Data.Add(mo["Manufacturer"]?.ToString()); //Manufacturer
                info.Data.Add(mo["Name"]?.ToString()); //Name
                info.Data.Add(mo["SerialNumber"]?.ToString()); //SerialNumber
                info.Data.Add(mo["Version"]?.ToString()); //Version
                //
                info.Data.Add(mo["InstallDate"]?.ToString()); //InstallDate
                info.Data.Add(mo["Model"]?.ToString()); //Model
                info.Data.Add(mo["OtherIdentifyingInfo"]?.ToString()); //OtherIdentifyingInfo
                info.Data.Add(mo["PartNumber"]?.ToString()); //PartNumber
                info.Data.Add(mo["SKU"]?.ToString()); //SKU



                info.ObjectCount.Add(mo);
            }
            mos.Dispose();
            moc.Dispose();

            return info;
        }

        public Info GetNetAdaptInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                //info.Data.Add(mo["AdapterType"].ToString()); //AdapterType
                info.Data.Add(mo["Caption"]?.ToString()); //Caption
                info.Data.Add(mo["Description"]?.ToString()); //Description
                info.Data.Add(mo["DeviceID"]?.ToString()); //DeviceID
                info.Data.Add(mo["GUID"]?.ToString()); //GUID
                info.Data.Add(mo["MACAddress"]?.ToString()); //MACAddress
                info.Data.Add(mo["Manufacturer"]?.ToString()); //Manufacturer
                info.Data.Add(mo["MaxSpeed"]?.ToString()); //MaxSpeed
                info.Data.Add(mo["Name"]?.ToString()); //Name
                info.Data.Add(mo["PermanentAddress"]?.ToString()); //PermanentAddress
                info.Data.Add(mo["PNPDeviceID"]?.ToString()); //PNPDeviceID
                info.Data.Add(mo["ProductName"]?.ToString()); //ProductName
                info.Data.Add(mo["ServiceName"]?.ToString()); //ServiceName
                info.Data.Add(mo["Speed"]?.ToString()); //Speed
                info.Data.Add(mo["SystemName"]?.ToString()); //SystemName


                info.ObjectCount.Add(mo);
            }

            return info;
        }

        public Info GetMonitorInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                info.Data.Add(mo["Caption"]?.ToString()); //Caption
                info.Data.Add(mo["Description"]?.ToString()); //Description
                info.Data.Add(mo["DeviceID"]?.ToString()); //DeviceID
                info.Data.Add(mo["DisplayType"]?.ToString()); //DisplayType
                info.Data.Add(mo["MonitorManufacturer"]?.ToString()); //MonitorManufacturer
                info.Data.Add(mo["MonitorType"]?.ToString()); //MonitorType
                info.Data.Add(mo["Name"]?.ToString()); //Name
                info.Data.Add("X" + mo["PixelsPerXLogicalInch"]?.ToString() + "Y" + mo["PixelsPerYLogicalInch"]?.ToString()); //Dimensions
                info.Data.Add(mo["PNPDeviceID"]?.ToString()); //PNPDeviceID
                info.Data.Add(mo["ScreenHeight"]?.ToString()); //ScreenHeight
                info.Data.Add(mo["ScreenWidth"]?.ToString()); //ScreenWidth
                info.Data.Add(mo["SystemName"]?.ToString()); //SystemName

                info.ObjectCount.Add(mo);
             }


            return info;
        }

        public Info GetBiosInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                info.Data.Add(mo["BuildNumber"]?.ToString()); //BuildNumber
                info.Data.Add(mo["Caption"]?.ToString()); //Caption
                info.Data.Add(mo["Description"]?.ToString()); //Description
                info.Data.Add(mo["IdentificationCode"]?.ToString()); //IdentificationCode
                info.Data.Add(mo["InstallDate"]?.ToString()); //InstallDate
                info.Data.Add(mo["Manufacturer"]?.ToString()); //Manufacturer
                info.Data.Add(mo["Name"]?.ToString()); //Name
                info.Data.Add(mo["OtherTargetOS"]?.ToString()); //OtherTargetOS
                info.Data.Add(mo["SerialNumber"]?.ToString()); //SerialNumber
                info.Data.Add(mo["SMBIOSBIOSVersion"]?.ToString()); //SMBIOSBIOSVersion
                info.Data.Add(mo["SoftwareElementID"]?.ToString()); //SoftwareElementID
                info.Data.Add(mo["Version"]?.ToString()); //Version

                info.ObjectCount.Add(mo);
            }

            return info;
        }

        public Info GetOsInfo()
        {
            Info info = new Info();

            info.Data = new List<string> { };
            info.ObjectCount = new List<ManagementObject> { };

            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem ");
            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject mo in moc)
            {
                info.Data.Add(mo["BootDevice"]?.ToString()); //BootDevice
                info.Data.Add(mo["BuildNumber"]?.ToString()); //BuildNumber
                info.Data.Add(mo["Caption"]?.ToString()); //Caption
                //info.Data.Add(mo["CurrentTimeZone"]?.ToString()); //CurrentTimeZone
                //info.Data.Add(mo["InstallDate"]?.ToString()); //InstallDate
                //info.Data.Add(mo["Description"]?.ToString()); //Description
                //info.Data.Add(mo["InstallDate"]?.ToString()); //InstallDate
                info.Data.Add(mo["Manufacturer"]?.ToString()); //Manufacturer
                info.Data.Add(mo["Name"]?.ToString()); //Name
                info.Data.Add(mo["PlusProductID"]?.ToString()); //PlusProductID
                info.Data.Add(mo["SerialNumber"]?.ToString()); //SerialNumber
                info.Data.Add(mo["Version"]?.ToString()); //Version
                info.Data.Add(mo["WindowsDirectory"]?.ToString()); //WindowsDirectory

                info.ObjectCount.Add(mo);
            }

            return info;
        }
    }
}
