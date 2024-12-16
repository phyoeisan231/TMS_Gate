using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS_Gate.Forms
{
    public partial class FrmMain1 : Form
    {
        public FrmMain1()
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
            var ctl = new CtlTruckIn() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnTruckOut_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOut1() { Dock = DockStyle.Fill };

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
            var ctl = new CtlTruckOut1() { Dock = DockStyle.Fill };

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
    }
}
