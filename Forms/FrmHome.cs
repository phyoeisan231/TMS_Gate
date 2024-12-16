using Syncfusion.Windows.Forms.Tools;
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
    public partial class FrmHome : RibbonForm
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void toolBtnIn_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckIn() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolBtnOut_Click(object sender, EventArgs e)
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

        private void toolBtnDailyOut_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyOut() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolbtnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
