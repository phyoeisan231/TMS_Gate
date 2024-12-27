using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TMS_Gate.Forms
{
    public partial class FrmMain : Form
    {
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private bool m_bInitSDK = false;
        private string str;
        public HCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTool.Controls.Clear();
            panelTool.Controls.Add(this.toolStrip1);

        }

        private void truckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTool.Controls.Clear();
            this.toolStrip3.Visible = true;
            panelTool.Controls.Add(this.toolStrip3);
        }

        private void toolBtnQ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolBtnTruckIn_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckIn() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void truckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruck() { Dock = DockStyle.Fill };
            //var ctl = new CtlTruckIn() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnTruckOut_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOut() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnInCheck_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckInCheck() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnOutCheck_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOutCheck() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnTruckStatus_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckStatus() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnDailyIn_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyIn() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolDailyOut_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyOut() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void truckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOut() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void inCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckInCheck() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void outCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOutCheck() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void truckStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckStatus() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void dailyInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyIn() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void dailyOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyOut() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnCamera_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            m_bInitSDK = HCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBoxAdv.Show(this, "NET_DVR_Init error!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {

                HCNetSDK.NET_DVR_SetLogToFile(3, "D:\\SdkLog\\", true);
            }

            HCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new HCNetSDK.NET_DVR_DEVICEINFO_V30();

            //string ip=ConfigurationManager.AppSettings.Get("device_ip");

            m_lUserID = HCNetSDK.NET_DVR_Login_V30(Properties.Settings.Default.device_ip, Properties.Settings.Default.device_port, Properties.Settings.Default.device_admin, Properties.Settings.Default.device_pwd, ref DeviceInfo);
            if (m_lUserID < 0)
            {
                iLastErr = HCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //µÇÂ¼Ê§°Ü£¬Êä³ö´íÎóºÅ
                MessageBoxAdv.Show(this, str, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBoxAdv.Show(this,"Login success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void checkIpCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            m_bInitSDK = HCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBoxAdv.Show(this, "NET_DVR_Init error!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {

                HCNetSDK.NET_DVR_SetLogToFile(3, "D:\\SdkLog\\", true);
            }

            HCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new HCNetSDK.NET_DVR_DEVICEINFO_V30();

            //string ip=ConfigurationManager.AppSettings.Get("device_ip");

            m_lUserID = HCNetSDK.NET_DVR_Login_V30(Properties.Settings.Default.device_ip, Properties.Settings.Default.device_port, Properties.Settings.Default.device_admin, Properties.Settings.Default.device_pwd, ref DeviceInfo);
            if (m_lUserID < 0)
            {
                iLastErr = HCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //µÇÂ¼Ê§°Ü£¬Êä³ö´íÎóºÅ
                MessageBoxAdv.Show(this, str, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBoxAdv.Show(this, "Login success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
