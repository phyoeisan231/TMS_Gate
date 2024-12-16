using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Gate.Model;
using TMS_Gate.Models;

namespace TMS_Gate.Forms
{
    public partial class CtlTruckOutCheck : UserControl
    {
        public CtlTruckOutCheck()
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            InitializeComponent();
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "TruckVehicleRegNo",
                HeaderText = "Truck No",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "DriverName",
                HeaderText = "Driver Name",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "DriverLicenseNo",
                HeaderText = "Driver License No",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "DriverContactNo",
                HeaderText = "Driver Contact No",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "CardNo",
                HeaderText = "Card No",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutPCCode",
                HeaderText = "Category",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "Customer",
                HeaderText = "Customer",
            });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn()
            {
                MappingName = "OutCheckDateTime",
                HeaderText = "Out Check Date Time",
                Format = "dd/MM/yyyy hh:mm:ss",
                Width = 150
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "TruckType",
                HeaderText = "Truck Type",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "TrailerVehicleRegNo",
                HeaderText = "Trailer No",
            });

            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutWeightBridgeID",
                HeaderText = "Out WeightBridge ID",
            });
                     
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutRegNo",
                HeaderText = "Out Check No",
            });
           
            this.sfDataGrid1.Style.HeaderStyle.BackColor = Color.DodgerBlue;
            this.sfDataGrid1.Style.HeaderStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 12;
            this.sfDataGrid1.Style.HeaderStyle.Font.Bold = true;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Size = 11;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Bold = true;
            this.sfDataGrid1.AllowResizingColumns = true;
        }

        private void sfBtnOutView_Click(object sender, EventArgs e)
        {
            btnDisabled();
            if (sfDateOutcF.Value != null && sfDateOutcTo.Value != null)
            {
                DateTime fromDate = (DateTime)sfDateOutcF.Value;
                DateTime toDate = (DateTime)sfDateOutcTo.Value;

                LoadData(fromDate, toDate);
            }
            else
            {
                // Handle null values appropriately
                MessageBoxAdv.Show(this, "Date values is null!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEnabled();
            }
        }

        private void sfBtnOutc_Click(object sender, EventArgs e)
        {
            btnDisabled();
            if (sfDataGrid1.SelectedItem != null)
            {
                var p = this.Parent as Panel;
                if (p != null)
                {
                    p.Controls.Remove(this);
                }
                // Initialize controls
                var ctl = new CtlTruckOut1() { Dock = DockStyle.Fill };
                // Add main panel and show the form
                p.Controls.Add(ctl);
                ICD_OutBoundCheck outData = (ICD_OutBoundCheck)sfDataGrid1.SelectedItem;
                btnEnabled();
                ctl.LoadData();
                ctl.FillInCheckData(outData.CardNo);
            }
            else
            {
                MessageBoxAdv.Show(this, "Date values is null!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEnabled();
            }
        }

        private void btnEnabled()
        {
            this.sfBtnOutView.Enabled = true;
            this.sfBtnOutc.Enabled = true;
        }

        private void btnDisabled()
        {
            this.sfBtnOutView.Enabled = false;
            this.sfBtnOutc.Enabled = false;
        }

    }
}

