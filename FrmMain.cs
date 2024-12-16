using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Gate.Forms;

namespace TMS_Gate
{
	public partial class FrmMain : Form
	{

        public FrmMain()
		{
			InitializeComponent();
		}

		private void btnTruckPass_Click(object sender, EventArgs e)
		{
            panelMain.Controls.Clear();
            var ctl =new CtlTruckIn() { Dock = DockStyle.Fill };
			
			panelMain.Controls.Add(ctl);
		}

		private void BtnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			panelMain.Controls.Clear();
            var ctl = new CtlTruckInCheck() { Dock = DockStyle.Fill };

			panelMain.Controls.Add(ctl);
		}

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOutCheck() { Dock = DockStyle.Fill };
            panelMain.Controls.Add(ctl);
        }

        private void btnTruckOut_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckOut() { Dock = DockStyle.Fill };

            panelMain.Controls.Add(ctl);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlTruckStatus() { Dock = DockStyle.Fill };
            panelMain.Controls.Add(ctl);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyIn() { Dock = DockStyle.Fill };
            panelMain.Controls.Add(ctl);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var ctl = new CtlDailyOut() { Dock = DockStyle.Fill };
            panelMain.Controls.Add(ctl);
        }

    }
}
