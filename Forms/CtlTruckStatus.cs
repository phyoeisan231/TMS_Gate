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

namespace TMS_Gate.Forms
{
    public partial class CtlTruckStatus : UserControl
    {
        public CtlTruckStatus()
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
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutRegNo",
                HeaderText = "Out Check No",
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

        private void sfBtnTruckView_Click(object sender, EventArgs e)
        {
            this.sfBtnTruckView.Enabled = false;
            if (sfDateTruckF.Value != null && sfDateTruckTo.Value != null)
            {
                DateTime fromDate = (DateTime)sfDateTruckF.Value;
                DateTime toDate = (DateTime)sfDateTruckTo.Value;
                LoadData(fromDate, toDate);
            }
            else
            {
                MessageBoxAdv.Show(this, "Date values is null!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.sfBtnTruckView.Enabled = true;
            }
        }
    }
}
