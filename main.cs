using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Hardware
{
    public partial class frm_main : Form
    {
        components cmp = new components();
        private string[] info = { };
        frm_splash s = new frm_splash();
        private int pagenumber = 0;
        public int PAGE
        {
            get { return pagenumber; }
            set { pagenumber = value; }
        }
        List<string> lines = new List<string> { };

        public List<Control> CONTROLS = new List<Control> { };
        public List<Control> CAPTIONS = new List<Control> { };

        private void frm_main_Load(object sender, EventArgs e)
        {
            s.ShowDialog();
            if (s.isLoaded == true)
            {
                this.Enabled = true;
                
            }
            else
            {
                this.Enabled = false;
            }

            //god fuck this
            CONTROLS.Add(textBox1);
            CONTROLS.Add(textBox2);
            CONTROLS.Add(textBox3);
            CONTROLS.Add(textBox4);
            CONTROLS.Add(textBox5);
            CONTROLS.Add(textBox6);
            CONTROLS.Add(textBox7);
            CONTROLS.Add(textBox8);
            CONTROLS.Add(textBox9);
            CONTROLS.Add(textBox10);
            CONTROLS.Add(textBox11);
            CONTROLS.Add(textBox12);
            CONTROLS.Add(textBox13);
            CONTROLS.Add(textBox14);
            CONTROLS.Add(textBox15);
            CONTROLS.Add(textBox30);
            CONTROLS.Add(textBox29);
            CONTROLS.Add(textBox28);
            CONTROLS.Add(textBox27);
            CONTROLS.Add(textBox26);
            CONTROLS.Add(textBox25);
            CONTROLS.Add(textBox24);
            CONTROLS.Add(textBox23);
            CONTROLS.Add(textBox22);
            CONTROLS.Add(textBox21);
            CONTROLS.Add(textBox20);
            CONTROLS.Add(textBox19);
            CONTROLS.Add(textBox18);
            CONTROLS.Add(textBox17);
            CONTROLS.Add(textBox16);
            CONTROLS.Add(textBox45);
            CONTROLS.Add(textBox44);
            CONTROLS.Add(textBox43);
            CONTROLS.Add(textBox42);
            CONTROLS.Add(textBox41);
            CONTROLS.Add(textBox40);
            CONTROLS.Add(textBox39);
            CONTROLS.Add(textBox38);
            CONTROLS.Add(textBox37);
            CONTROLS.Add(textBox36);
            CONTROLS.Add(textBox35);
            CONTROLS.Add(textBox34);
            CONTROLS.Add(textBox33);
            CONTROLS.Add(textBox32);
            CONTROLS.Add(textBox31);

            CAPTIONS.Add(lbl1);
            CAPTIONS.Add(lbl2);
            CAPTIONS.Add(lbl3);
            CAPTIONS.Add(lbl4);
            CAPTIONS.Add(lbl5);
            CAPTIONS.Add(lbl6);
            CAPTIONS.Add(lbl7);
            CAPTIONS.Add(lbl8);
            CAPTIONS.Add(lbl9);
            CAPTIONS.Add(lbl10);
            CAPTIONS.Add(lbl11);
            CAPTIONS.Add(lbl12);
            CAPTIONS.Add(lbl13);
            CAPTIONS.Add(lbl14);
            CAPTIONS.Add(lbl15);
            CAPTIONS.Add(lbl16);
            CAPTIONS.Add(lbl17);
            CAPTIONS.Add(lbl18);
            CAPTIONS.Add(lbl19);
            CAPTIONS.Add(lbl20);
            CAPTIONS.Add(lbl21);
            CAPTIONS.Add(lbl22);
            CAPTIONS.Add(lbl23);
            CAPTIONS.Add(lbl24);
            CAPTIONS.Add(lbl25);
            CAPTIONS.Add(lbl26);
            CAPTIONS.Add(lbl27);
            CAPTIONS.Add(lbl28);
            CAPTIONS.Add(lbl29);
            CAPTIONS.Add(lbl30);
            CAPTIONS.Add(lbl31);
            CAPTIONS.Add(lbl32);
            CAPTIONS.Add(lbl33);
            CAPTIONS.Add(lbl34);
            CAPTIONS.Add(lbl35);
            CAPTIONS.Add(lbl36);
            CAPTIONS.Add(lbl37);
            CAPTIONS.Add(lbl38);
            CAPTIONS.Add(lbl39);
            CAPTIONS.Add(lbl40);
            CAPTIONS.Add(lbl41);
            CAPTIONS.Add(lbl42);
            CAPTIONS.Add(lbl43);
            CAPTIONS.Add(lbl44);
            CAPTIONS.Add(lbl45);

            grp_info.Text = "System Information";
        }

        public void ClearAllControls()
        {
            foreach (Control ctrl in grp_info.Controls)
            {
                if (ctrl.Text.Length > 0)
                {
                    ctrl.Text = "\0";
                }
                if (ctrl.Text.Length == 0)
                {
                    ctrl.Visible = false;
                }
            }
        }

        public void PopulateText(List<string> lst)
        {
            int length = lst.Count() - 1;

            for (int i = 0; i <= length; i++)
            {
                if (i == 45)
                {
                    break;
                }
                else
                {
                    CONTROLS[i].Text = lst[i]?.ToString();
                    CONTROLS[i].Visible = true;
                }
            }

        }

        public void PopulateCaption(List<string> lst)
        {
            int length = lst.Count() - 1;

            for (int i = 0; i <= length; i++)
            {
                if (i == 45)
                {
                    break;
                }
                else
                {
                    CAPTIONS[i].Text = lst[i].ToString();
                    CAPTIONS[i].Visible = true;
                }
            }

        }

        public void CheckForEmpty()
        {
            foreach (Control ctrl in grp_info.Controls)
            {
                if (ctrl.Text.Length == 0)
                {
                    ctrl.Text = "Error";
                    ctrl.Visible = true;
                }
            }
        }

        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.CPU);
            PopulateCaption(s.cpudesc);
            PAGE = 1;
            grp_info.Text = "System Information";
        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.RAM);
            PopulateCaption(s.ramdesc);
            PAGE = 2;
            grp_info.Text = "System Information";
        }

        private void btn_hdd_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.HDD);
            PopulateCaption(s.hdddesc);
            PAGE = 3;
            grp_info.Text = "System Information";
        }

        private void btn_sdd_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.SSD);
            PopulateCaption(s.ssddesc);
            PAGE = 4;
            grp_info.Text = "System Information";
        }

        private void btn_gpu_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.GPU);
            PopulateCaption(s.gpudesc);
            PAGE = 5;
            grp_info.Text = "System Information";
        }

        private void btn_motherboard_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.MB);
            PopulateCaption(s.mbdesc);
            PAGE = 6;
            grp_info.Text = "System Information";
        }

        private void btn_netadapt_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.NETADAPT);
            PopulateCaption(s.netadaptdesc);
            PAGE = 7;
            grp_info.Text = "System Information  |  You may need to export to see all results";
        }

        private void btn_monitor_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.MONITOR);
            PopulateCaption(s.monitordesc);
            PAGE = 8;
            grp_info.Text = "System Information  |  This may not show accurate results";
        }

        private void btn_bios_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.BIOS);
            PopulateCaption(s.biosdesc);
            PAGE = 9;
            grp_info.Text = "System Information";
        }

        private void btn_os_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            PopulateText(s.OS);
            PopulateCaption(s.osdesc);
            PAGE = 10;
            grp_info.Text = "System Information";
        }

        public void Export(int page)
        {
            string dir = Directory.GetCurrentDirectory().ToString();

            switch (page)
            {
                case 1:
                    for (int i = 0; i < s.cpudesc.Count(); i++)
                    {
                        lines.Add(s.cpudesc[i]?.ToString() + ": " + s.CPU[i]?.ToString());
                    }
                    break;
                case 2:
                    for (int i = 0; i < s.ramdesc.Count(); i++)
                    {
                        lines.Add(s.ramdesc[i]?.ToString() + ": " + s.RAM[i]?.ToString());
                    }
                    break;
                case 3:
                    for (int i = 0; i < s.hdddesc.Count(); i++)
                    {
                        lines.Add(s.hdddesc[i]?.ToString() + ": " + s.HDD[i]?.ToString());
                    }
                    break;
                case 4:
                    for (int i = 0; i < s.ssddesc.Count(); i++)
                    {
                        lines.Add(s.ssddesc[i]?.ToString() + ": " + s.SSD[i]?.ToString());
                    }
                    break;
                case 5:
                    for (int i = 0; i < s.gpudesc.Count(); i++)
                    {
                        lines.Add(s.gpudesc[i]?.ToString() + ": " + s.GPU[i]?.ToString());
                    }
                    break;
                case 6:
                    for (int i = 0; i < s.mbdesc.Count(); i++)
                    {
                        lines.Add(s.mbdesc[i]?.ToString() + ": " + s.MB[i]?.ToString());
                    }
                    break;
                case 7:
                    for (int i = 0; i < s.netadaptdesc.Count(); i++)
                    {
                        lines.Add(s.netadaptdesc[i]?.ToString() + ": " + s.NETADAPT[i]?.ToString());
                    }
                    break;
                case 8:
                    for (int i = 0; i < s.monitordesc.Count(); i++)
                    {
                        lines.Add(s.monitordesc[i]?.ToString() + ": " + s.MONITOR[i]?.ToString());
                    }
                    break;
                case 9:
                    for (int i = 0; i < s.biosdesc.Count(); i++)
                    {
                        lines.Add(s.biosdesc[i]?.ToString() + ": " + s.BIOS[i]?.ToString());
                    }
                    break;
                case 10:
                    for (int i = 0; i < s.osdesc.Count(); i++)
                    {
                        lines.Add(s.osdesc[i]?.ToString() + ": " + s.OS[i]?.ToString());
                    }
                    break;
            }

            File.WriteAllLines(@dir + "\\exportedsysinfo.txt", lines);
            if (page == 0)
            {
                MessageBox.Show("Empty file written to " + dir + "\\exportedsysinfo.txt\nTry viewing a system component first using the buttons!", "Empty File Written");
            }
            else
            {
                MessageBox.Show("File written to " + dir + "\\exportedsysinfo.txt", "File Written");
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Export(PAGE);
        }
    }
}
