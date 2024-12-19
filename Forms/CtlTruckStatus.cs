using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TMS_Gate.Forms
{
    public partial class CtlTruckStatus : UserControl
    {
        public string status=String.Empty;
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
            this.sfDataGrid1.Style.HeaderStyle.BackColor = Color.SteelBlue;
            this.sfDataGrid1.Style.HeaderStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 12;
            this.sfDataGrid1.Style.HeaderStyle.Font.Bold = true;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Size = 11;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Bold = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfComboBoxStatus.DataSource = CommonData.truckStatuslist;
        }

        private void sfBtnTruckView_Click(object sender, EventArgs e)
        {
            this.btnDisabled();

            if (sfDateTruckF.Value != null && sfDateTruckTo.Value != null && sfComboBoxStatus.CheckedItems != null)
            {
                DateTime fromDate = (DateTime)sfDateTruckF.Value;
                DateTime toDate = (DateTime)sfDateTruckTo.Value;

                // Retrieve the selected items as a list of strings
                List<string> selectedStatuses = sfComboBoxStatus.CheckedItems
                    .Cast<string>()
                    .ToList();

                // Format the selected statuses for use
                string formattedStatuses = FormatParams(selectedStatuses);
                LoadData(fromDate, toDate, formattedStatuses);
            }
            else
            {
                MessageBoxAdv.Show(this, "Date values are null or status is not selected!",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.btnEnabled();
        }

        public static string FormatParams(List<string> paramArray)
        {
            return string.Join(",", paramArray.Select(item => $"'{item}'"));
        }

        private void btnEnabled()
        {
            this.sfBtnTruckView.Enabled = true;
            this.sfbtnExport.Enabled = true;
        }

        private void btnDisabled()
        {
            this.sfBtnTruckView.Enabled = false;
            this.sfbtnExport.Enabled = false;
        }

        private void sfbtnExport_Click(object sender, EventArgs e)
        {
            this.btnDisabled();

            if (sfDataGrid1.View != null)
            {
                var options = new ExcelExportingOptions
                {
                    ExcelVersion = ExcelVersion.Excel2013
                };
                var excelEngine = this.sfDataGrid1.ExportToExcel(sfDataGrid1.View, options);
                var workBook = excelEngine.Excel.Workbooks[0];

                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx",
                    FilterIndex = 2
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream stream = saveFileDialog.OpenFile())
                        {
                            switch (saveFileDialog.FilterIndex)
                            {
                                case 1:
                                    workBook.Version = ExcelVersion.Excel97to2003;
                                    break;
                                case 2:
                                    workBook.Version = ExcelVersion.Excel2010;
                                    break;
                                case 3:
                                    workBook.Version = ExcelVersion.Excel2013;
                                    break;
                            }
                            workBook.SaveAs(stream);
                        }

                        if (MessageBox.Show("Do you want to view the workbook?", "Export Successful",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(saveFileDialog.FileName);
                        }
                    }
                }
            }
            else
            {
                MessageBoxAdv.Show(this, "No Data!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEnabled();
            }
            btnEnabled();
        }

        
    }
}
