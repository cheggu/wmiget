using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware
{
    public partial class frm_splash : Form
    {
        components cmp = new components();

        private bool loaded = false;
        private List<string> cpu;
        public List<string> CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }

        public List<string> cpudesc = new List<string> { };
        public List<string> ramdesc = new List<string> { };
        public List<string> hdddesc = new List<string> { };
        public List<string> ssddesc = new List<string> { };
        public List<string> gpudesc = new List<string> { };
        public List<string> mbdesc = new List<string> { };
        public List<string> netadaptdesc = new List<string> { };
        public List<string> monitordesc = new List<string> { };
        public List<string> biosdesc = new List<string> { };
        public List<string> osdesc = new List<string> { };

        private List<string> ram;
        public List<string> RAM
        {
            get { return ram; }
            set { ram = value; }
        }


        private List<string> hdd;
        public List<string> HDD
        {
            get { return hdd; }
            set { hdd = value; }
        }
        private List<string> ssd;
        public List<string> SSD
        {
            get { return ssd; }
            set { ssd = value; }
        }
        private List<string> gpu;
        public List<string> GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }
        private List<string> mb;
        public List<string> MB
        {
            get { return mb; }
            set { mb = value; }
        }
        private List<string> netadapt;
        public List<string> NETADAPT
        {
            get { return netadapt; }
            set { netadapt = value; }
        }
        private List<string> monitor;
        public List<string> MONITOR
        {
            get { return monitor; }
            set { monitor = value; }
        }
        private List<string> bios;
        public List<string> BIOS
        {
            get { return bios; }
            set { bios = value; }
        }
        private List<string> os;
        public List<string> OS
        {
            get { return os; }
            set { os = value; }
        }


        public bool isLoaded
        {
            get { return loaded; }
            set { loaded = value; }
        }

        public frm_splash()
        {
            InitializeComponent();
        }

        public void frm_splash_Load(object sender, EventArgs e)
        {
            this.Show();
            isLoaded = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
            lbldone.Visible = false;



            
            CPU = cmp.GetCpuInfo().Data;
            lbl1.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            RAM = cmp.GetRamInfo().Data;

            lbl2.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            HDD = cmp.GetHddInfo().Data;

            lbl3.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            SSD = cmp.GetSsdInfo().Data;

            lbl4.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            GPU = cmp.GetGpuInfo().Data;

            lbl5.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            MB = cmp.GetMbInfo().Data;

            lbl6.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            NETADAPT = cmp.GetNetAdaptInfo().Data;

            lbl7.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            MONITOR = cmp.GetMonitorInfo().Data;

            lbl8.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            BIOS = cmp.GetBiosInfo().Data;

            lbl9.Visible = true;
            progress.PerformStep();
            Thread.Sleep(100);

            OS = cmp.GetOsInfo().Data;

            lbl10.Visible = true;
            progress.PerformStep();

            //done loading
            lbldone.Visible = true;

            GenerateCaptions();

            isLoaded = true;
            timer.Enabled = true;
            timer.Start();

        }

        public void GenerateCaptions()
        {
            //cpu
            
            cpudesc.Add("Description");
            cpudesc.Add("Part Number");
            cpudesc.Add("Device ID");
            cpudesc.Add("Name");
            cpudesc.Add("SerialNumber");
            cpudesc.Add("Install Date");
            cpudesc.Add("Manufacturer");
            cpudesc.Add("Part Number");
            cpudesc.Add("PNPDeviceID");
            cpudesc.Add("Status");
            cpudesc.Add("System Name");
            cpudesc.Add("Unique ID");
            cpudesc.Add("Version");
            cpudesc.Add("Virtualization Firmware Enabled");
            cpudesc.Add("Max Clock Speed");

            //ram
            List<ManagementObject> RAMCOUNT = cmp.GetRamInfo().ObjectCount;
            ramdesc.Add("Capacity");
            ramdesc.Add("ConfiguredClockSpeed");
            ramdesc.Add("Description");
            ramdesc.Add("FormFactor");
            ramdesc.Add("Manufacturer");
            ramdesc.Add("Name");
            ramdesc.Add("PartNumber");
            ramdesc.Add("SerialNumber");
            ramdesc.Add("Speed");
            ramdesc.Add("Caption");
            ramdesc.Add("Tag");
            if (RAMCOUNT.Count > 1)
            {
                for (int stick = 2; stick <= RAMCOUNT.Count(); stick++)
                {
                    ramdesc.Add("Capacity " + stick.ToString());
                    ramdesc.Add("ConfiguredClockSpeed " + stick.ToString());
                    ramdesc.Add("Description " + stick.ToString());
                    ramdesc.Add("FormFactor " + stick.ToString());
                    ramdesc.Add("Manufacturer " + stick.ToString());
                    ramdesc.Add("Name " + stick.ToString());
                    ramdesc.Add("PartNumber " + stick.ToString());
                    ramdesc.Add("SerialNumber " + stick.ToString());
                    ramdesc.Add("Speed " + stick.ToString());
                    ramdesc.Add("Caption " + stick.ToString());
                    ramdesc.Add("Tag " + stick.ToString());
                }

            }
            //hdd
            List<ManagementObject> HDDCOUNT = cmp.GetHddInfo().ObjectCount;
            hdddesc.Add("Caption");
            hdddesc.Add("Description");
            hdddesc.Add("DeviceID");
            hdddesc.Add("Manufacturer");
            hdddesc.Add("Model");
            hdddesc.Add("Name");
            hdddesc.Add("PNPDeviceID");
            hdddesc.Add("SerialNumber");
            hdddesc.Add("Size");
            hdddesc.Add("Status");
            hdddesc.Add("SystemName");
            hdddesc.Add("BytesPerSector");
            //MessageBox.Show(HDDCOUNT.Count.ToString());
            if (HDDCOUNT.Count > 1)
            {
                for (int disk = 2; disk <= HDDCOUNT.Count(); disk++)
                {
                    hdddesc.Add("Capacity " + disk.ToString());
                    hdddesc.Add("Description " + disk.ToString());
                    hdddesc.Add("DeviceID " + disk.ToString());
                    hdddesc.Add("Manufacturer " + disk.ToString());
                    hdddesc.Add("Model " + disk.ToString());
                    hdddesc.Add("Name " + disk.ToString());
                    hdddesc.Add("PNPDeviceID " + disk.ToString());
                    hdddesc.Add("SerialNumber " + disk.ToString());
                    hdddesc.Add("Size " + disk.ToString());
                    hdddesc.Add("Status " + disk.ToString());
                    hdddesc.Add("SystemName " + disk.ToString());
                    hdddesc.Add("BytesPerSector " + disk.ToString());
                }

            }

            //ssd
            List<ManagementObject> SSDCOUNT = cmp.GetHddInfo().ObjectCount;
            ssddesc.Add("Caption");
            ssddesc.Add("Description");
            ssddesc.Add("DeviceID");
            ssddesc.Add("Manufacturer");
            ssddesc.Add("Model");
            ssddesc.Add("Name");
            ssddesc.Add("PNPDeviceID");
            ssddesc.Add("SerialNumber");
            ssddesc.Add("Size");
            ssddesc.Add("Status");
            ssddesc.Add("SystemName");
            ssddesc.Add("BytesPerSector");
            //MessageBox.Show(SSDCOUNT.Count.ToString());
            if (HDDCOUNT.Count > 1)
            {
                for (int ssd = 2; ssd <= SSDCOUNT.Count(); ssd++)
                {
                    ssddesc.Add("Capacity " + ssd.ToString());
                    ssddesc.Add("Description " + ssd.ToString());
                    ssddesc.Add("DeviceID " + ssd.ToString());
                    ssddesc.Add("Manufacturer " + ssd.ToString());
                    ssddesc.Add("Model " + ssd.ToString());
                    ssddesc.Add("Name " + ssd.ToString());
                    ssddesc.Add("PNPDeviceID " + ssd.ToString());
                    ssddesc.Add("SerialNumber " + ssd.ToString());
                    ssddesc.Add("Size " + ssd.ToString());
                    ssddesc.Add("Status " + ssd.ToString());
                    ssddesc.Add("SystemName " + ssd.ToString());
                    ssddesc.Add("BytesPerSector " + ssd.ToString());
                }

            }
            //gpu
            List<ManagementObject> GPUCOUNT = cmp.GetGpuInfo().ObjectCount;
            gpudesc.Add("AdapterRAM");
            gpudesc.Add("Caption");
            gpudesc.Add("CurrentRefreshRate");
            gpudesc.Add("Resolution");
            gpudesc.Add("Description");
            gpudesc.Add("DeviceID");
            gpudesc.Add("DriverVersion");
            gpudesc.Add("Name");
            gpudesc.Add("PNPDeviceID");
            gpudesc.Add("SystemName");
            gpudesc.Add("VideoArchitecture");
            gpudesc.Add("VideoMemoryType");
            gpudesc.Add("MaxRefreshRate");
            gpudesc.Add("VideoProcessor");
            if (GPUCOUNT.Count > 1)
            {
                for (int gpu = 2; gpu <= SSDCOUNT.Count(); gpu++)
                {
                    gpudesc.Add("AdapterRAM " + gpu.ToString());
                    gpudesc.Add("Caption " + gpu.ToString());
                    gpudesc.Add("CurrentRefreshRate " + gpu.ToString());
                    gpudesc.Add("Resolution " + gpu.ToString());
                    gpudesc.Add("Description " + gpu.ToString());
                    gpudesc.Add("DeviceID " + gpu.ToString());
                    gpudesc.Add("DriverVersion " + gpu.ToString());
                    gpudesc.Add("Name " + gpu.ToString());
                    gpudesc.Add("PNPDeviceID " + gpu.ToString());
                    gpudesc.Add("SystemName " + gpu.ToString());
                    gpudesc.Add("VideoArchitecture " + gpu.ToString());
                    gpudesc.Add("VideoMemoryType " + gpu.ToString());
                    gpudesc.Add("MaxRefreshRate " + gpu.ToString());
                    gpudesc.Add("VideoProcessor " + gpu.ToString());
                }

            }
            //mb
            mbdesc.Add("Caption");
            mbdesc.Add("Description");
            mbdesc.Add("Manufacturer");
            mbdesc.Add("Name");
            mbdesc.Add("SerialNumber");
            mbdesc.Add("Version");
            mbdesc.Add("InstallDate");
            mbdesc.Add("Model");
            mbdesc.Add("OtherIdentifyingInfo");
            mbdesc.Add("PartNumber");
            mbdesc.Add("SKU");

            //netadapt
            List<ManagementObject> NETCOUNT = cmp.GetNetAdaptInfo().ObjectCount;
            netadaptdesc.Add("Caption");
            netadaptdesc.Add("Description");
            netadaptdesc.Add("DeviceID");
            netadaptdesc.Add("GUID");
            netadaptdesc.Add("MACAddress");
            netadaptdesc.Add("Manufacturer");
            netadaptdesc.Add("MaxSpeed");
            netadaptdesc.Add("Name");
            netadaptdesc.Add("PermanentAddress");
            netadaptdesc.Add("PNPDeviceID");
            netadaptdesc.Add("ProductName");
            netadaptdesc.Add("ServiceName");
            netadaptdesc.Add("Speed");
            netadaptdesc.Add("SystemName");
            if (NETCOUNT.Count > 1)
            {
                for (int net = 2; net <= NETCOUNT.Count(); net++)
                {
                    netadaptdesc.Add("Caption " + net.ToString());
                    netadaptdesc.Add("Description " + net.ToString());
                    netadaptdesc.Add("DeviceID " + net.ToString());
                    netadaptdesc.Add("GUID " + net.ToString());
                    netadaptdesc.Add("MACAddress " + net.ToString());
                    netadaptdesc.Add("MaxSpeed " + net.ToString());
                    netadaptdesc.Add("Name " + net.ToString());
                    netadaptdesc.Add("PermanentAddress " + net.ToString());
                    netadaptdesc.Add("PNPDeviceID " + net.ToString());
                    netadaptdesc.Add("ProductName " + net.ToString());
                    netadaptdesc.Add("ServiceName " + net.ToString());
                    netadaptdesc.Add("Speed " + net.ToString());
                    netadaptdesc.Add("SystemName " + net.ToString());
                }

            }

            //monitor
            List<ManagementObject> MONITORCOUNT = cmp.GetMonitorInfo().ObjectCount;
            monitordesc.Add("Caption");
            monitordesc.Add("Description");
            monitordesc.Add("DeviceID");
            monitordesc.Add("DisplayType");
            monitordesc.Add("MonitorManufacturer");
            monitordesc.Add("MonitorType");
            monitordesc.Add("Name");
            monitordesc.Add("Dimensions");
            monitordesc.Add("PNPDeviceID");
            monitordesc.Add("ScreenHeight");
            monitordesc.Add("ScreenWidth");
            monitordesc.Add("SystemName");
            if (MONITORCOUNT.Count > 1)
            {
                for (int mon = 2; mon <= MONITORCOUNT.Count(); mon++)
                {
                    monitordesc.Add("Caption " + mon.ToString());
                    monitordesc.Add("Description " + mon.ToString());
                    monitordesc.Add("DeviceID " + mon.ToString());
                    monitordesc.Add("DisplayType " + mon.ToString());
                    monitordesc.Add("MonitorManufacturer " + mon.ToString());
                    monitordesc.Add("MonitorType " + mon.ToString());
                    monitordesc.Add("Name " + mon.ToString());
                    monitordesc.Add("Dimensions " + mon.ToString());
                    monitordesc.Add("ScreenHeight " + mon.ToString());
                    monitordesc.Add("ScreenWidth " + mon.ToString());
                    monitordesc.Add("ProductName " + mon.ToString());
                    monitordesc.Add("SystemName " + mon.ToString());
                }

            }


            //bios
            List<ManagementObject> BIOSCOUNT = cmp.GetOsInfo().ObjectCount;

            biosdesc.Add("BuildNumber");
            biosdesc.Add("Caption");
            biosdesc.Add("Description");
            biosdesc.Add("IdentificationCode");
            biosdesc.Add("InstallDate");
            biosdesc.Add("Manufacturer");
            biosdesc.Add("Name");
            biosdesc.Add("OtherTargetOS");
            biosdesc.Add("SerialNumber");
            biosdesc.Add("SMBIOSBIOSVersion");
            biosdesc.Add("SoftwareElementID");
            biosdesc.Add("Version");
            if (BIOSCOUNT.Count > 1)
            {
                for (int bi = 2; bi <= MONITORCOUNT.Count(); bi++)
                {
                    biosdesc.Add("BuildNumber " + bi.ToString());
                    biosdesc.Add("Caption " + bi.ToString());
                    biosdesc.Add("Description " + bi.ToString());
                    biosdesc.Add("IdentificationCode " + bi.ToString());
                    biosdesc.Add("InstallDate " + bi.ToString());
                    biosdesc.Add("Manufacturer " + bi.ToString());
                    biosdesc.Add("Name " + bi.ToString());
                    biosdesc.Add("OtherTargetOS " + bi.ToString());
                    biosdesc.Add("SerialNumber " + bi.ToString());
                    biosdesc.Add("SMBIOSBIOSVersion " + bi.ToString());
                    biosdesc.Add("SoftwareElementID " + bi.ToString());
                    biosdesc.Add("Version " + bi.ToString());
                }

            }
            //os
            osdesc.Add("BootDevice");
            osdesc.Add("BuildNumber");
            osdesc.Add("Caption");
            //osdesc.Add("CurrentTimeZone");
            //osdesc.Add("InstallDate");
            osdesc.Add("Manufacturer");
            osdesc.Add("Name");
            osdesc.Add("PlusProductID");
            osdesc.Add("SerialNumber");
            osdesc.Add("Version");
            osdesc.Add("WindowsDirectory");

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void lbl8_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl9_Click(object sender, EventArgs e)
        {

        }

        private void lbl10_Click(object sender, EventArgs e)
        {

        }

        private void lbldone_Click(object sender, EventArgs e)
        {

        }
    }
}
