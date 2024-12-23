using Syncfusion.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System;
using System.Drawing;
using System.IO;
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
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "InCheckDateTime",
                HeaderText = "In Check Date Time",
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
            this.sfDataGrid1.Style.HeaderStyle.BackColor = Color.SteelBlue;
            this.sfDataGrid1.Style.HeaderStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 12;
            this.sfDataGrid1.Style.HeaderStyle.Font.Bold = true;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Size = 11;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Bold = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.Style.TableSummaryRowStyle.BackColor = Color.LightSteelBlue;
            this.sfDataGrid1.Style.TableSummaryRowStyle.Font = new GridFontInfo(new Font("Arial", 13f, FontStyle.Bold));
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


        //private async void sfBtnIn_Click(object sender, EventArgs e)
        //{
        //    btnDisabled();
        //    if (sfDataGrid1.SelectedItem != null)
        //    {
        //        var p = this.Parent as Panel;
        //        if (p != null)
        //        {
        //            p.Controls.Remove(this);
        //        }
        //        // Initialize controls
        //        var ctl = new CtlTruckIn1() { Dock = DockStyle.Fill };
        //        // Add main panel and show the form
        //        ICD_InBoundCheck inData = (ICD_InBoundCheck)sfDataGrid1.SelectedItem;
        //        await ctl.LoadData();
        //        if (ctl.inboundList!=null && ctl.inboundList.Count > 0)
        //        {
        //            ctl.FillInCheckData(inData.CardNo);
        //            p.Controls.Add(ctl);
        //            btnEnabled();
        //        }

        //    }
        //    else
        //    {
        //        MessageBoxAdv.Show(this, "Please select row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        btnEnabled();
        //    }
        //}

        private async void sfBtnIn_Click(object sender, EventArgs e)
        {
            btnDisabled();

            if (sfDataGrid1.SelectedItem != null)
            {
                try
                {
                    var p = this.Parent as Panel;                   
                    // Initialize controls
                    var ctl = new CtlTruckIn1() { Dock = DockStyle.Fill };

                    // Get selected data
                    ICD_InBoundCheck inData = (ICD_InBoundCheck)sfDataGrid1.SelectedItem;

                    // Debug: Check selected item
                    Console.WriteLine($"Selected CardNo: {inData.CardNo}");

                    // Load data and verify
                    await ctl.LoadData();
                    if (ctl.inboundList != null && ctl.inboundList.Count > 0)
                    {
                        // Debug: Check loaded data
                        Console.WriteLine($"Loaded Data Count: {ctl.inboundList.Count}");

                        // Fill in data after loading is complete
                        ctl.FillInCheckData(inData.CardNo);

                        if (p != null)
                        {
                            p.Controls.Remove(this);
                        }
                        // Add the control to the parent panel
                        p.Controls.Add(ctl);
                        Console.WriteLine("Control added successfully.");
                        btnEnabled();
                    }
                    else
                    {
                        MessageBoxAdv.Show(this, "No data available to process!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEnabled();
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show(this, $"An error occurred: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEnabled();
                }
            }
            else
            {
                MessageBoxAdv.Show(this, "Please select a row!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEnabled();
            }
        }


        private void btnEnabled()
        {
            this.sfBtnIncView.Enabled = true;
            this.sfBtnInc.Enabled = true;
            this.sfbtnExport.Enabled = true;
        }

        private void btnDisabled()
        {
            this.sfBtnIncView.Enabled = false;
            this.sfBtnInc.Enabled = false;
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
