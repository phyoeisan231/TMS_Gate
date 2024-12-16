using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Drawing;
using System.Windows.Forms;
using TMS_Gate.Model;

namespace TMS_Gate.Forms
{
    public partial class CtlTruckInCheck : UserControl
    {
        public CtlTruckInCheck()
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
                MappingName = "InPCCode",
                HeaderText = "Category",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "Customer",
                HeaderText = "Customer",
            });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn()
            {
                MappingName = "InCheckDateTime",
                HeaderText = "In Check Date Time",
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
                MappingName = "InWeightBridgeID",
                HeaderText = "In WeightBridge ID",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutWeightBridgeID",
                HeaderText = "Out WeightBridge ID",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "InRegNo",
                HeaderText = "In Check No",
            });

            ////Change the record cell back color for product name column.
            //this.sfDataGrid1.Columns["InCheckDateTime"].CellStyle.BackColor = Color.SlateGray;

            ////Change the record cell text color for product name column.
            //this.sfDataGrid1.Columns["InCheckDateTime"].CellStyle.TextColor = Color.White;

            ////Change the header cell back color for product name column.
            //this.sfDataGrid1.Columns["InCheckDateTime"].HeaderStyle.BackColor = Color.MediumSlateBlue;

            ////Change the header cell text color for product name column.
            //this.sfDataGrid1.Columns["InCheckDateTime"].HeaderStyle.TextColor = Color.White;
            //this.sfDataGrid1.Style.AddNewRowStyle.BackColor = Color.DarkCyan;
            //this.sfDataGrid1.Style.AddNewRowStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.BackColor = Color.DodgerBlue;
            this.sfDataGrid1.Style.HeaderStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 12;
            this.sfDataGrid1.Style.HeaderStyle.Font.Bold = true;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Size = 11;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Bold = true;
            this.sfDataGrid1.AllowResizingColumns = true;
        }

        private void sfBtnIncView_Click(object sender, EventArgs e)
        {
            btnDisabled();
            if (sfDateIncF.Value != null && sfDateIncTo.Value != null)
            {
                DateTime fromDate = (DateTime)sfDateIncF.Value;
                DateTime toDate = (DateTime)sfDateIncTo.Value;

                LoadData(fromDate, toDate);
            }
            else
            {
                // Handle null values appropriately
                MessageBoxAdv.Show(this, "Date values is null!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEnabled();
            }
        }


        private void sfBtnIn_Click(object sender, EventArgs e)
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
                var ctl = new CtlTruckIn() { Dock = DockStyle.Fill };
                // Add main panel and show the form
                p.Controls.Add(ctl);
                ICD_InBoundCheck inData = (ICD_InBoundCheck)sfDataGrid1.SelectedItem;
                ctl.LoadData();
                btnEnabled();
                ctl.FillInCheckData(inData.CardNo);
            }
            else
            {
                MessageBox.Show("Please select row.");
                btnEnabled();
            }
        }

        private void btnEnabled()
        {
            this.sfBtnIncView.Enabled = true;
            this.sfBtnInc.Enabled = true;
        }

        private void btnDisabled()
        {
            this.sfBtnIncView.Enabled = false;
            this.sfBtnInc.Enabled = false;
        }
    }
}
