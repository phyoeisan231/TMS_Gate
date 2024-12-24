using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataPager;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using TMS_Gate.Models;

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
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "InCheckDateTime",
                HeaderText = "In Check Date Time",
                Width = 150
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutCheckDateTime",
                HeaderText = "Out Check Date Time",
                Width = 150
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "InGatePassTime",
                HeaderText = "In GatePass Time",
                Width = 150
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutGatePassTime",
                HeaderText = "Out GatePass Time",
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
                MappingName = "InWeightDateTime",
                HeaderText = "In Weight Date Time",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OptStartDate",
                HeaderText = "Operation Start Date",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OptEndDate",
                HeaderText = "Operation End Date",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "OutWeightDateTime",
                HeaderText = "Out Weight Date Time",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "GRNNo",
                HeaderText = "GRN No",
            });
            this.sfDataGrid1.Columns.Add(new GridTextColumn()
            {
                MappingName = "GDNNo",
                HeaderText = "GDN No",
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
            this.sfDataGrid1.Style.HeaderStyle.BackColor = Color.SteelBlue;
            this.sfDataGrid1.Style.HeaderStyle.TextColor = Color.White;
            this.sfDataGrid1.Style.HeaderStyle.Font.Size = 12;
            this.sfDataGrid1.Style.HeaderStyle.Font.Bold = true;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Size = 11;
            this.sfDataGrid1.Style.AddNewRowStyle.Font.Bold = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.Style.TableSummaryRowStyle.BackColor = Color.LightSteelBlue;
            this.sfDataGrid1.Style.TableSummaryRowStyle.Font = new GridFontInfo(new Font("Arial", 13f, FontStyle.Bold));
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
                sfDataGrid1.DrawCell += SfDataGrid1_DrawCell;
            }
            else
            {
                MessageBoxAdv.Show(this, "Date values are null or status is not selected!",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.btnEnabled();
        }

        private void SfDataGrid1_DrawCell(object sender, DrawCellEventArgs e)
        {
            // Ensure we are working with the "TruckVehicleRegNo" column
            if (e.Column.MappingName == "TruckVehicleRegNo" && e.DataRow.RowData is ICD_TruckProcess rowData)
            {
                switch (rowData.Status)
                {
                    case "In(Check)":
                        e.Style.TextColor = Color.Orange;
                        break;
                    case "In":
                        e.Style.TextColor = Color.Purple;
                        break;
                    case "In(Weight)":
                        e.Style.TextColor = Color.Orchid;
                        break;
                    case "Operation":
                        e.Style.TextColor = Color.LightSkyBlue;
                        break;
                    case "Out(Weight)":
                        e.Style.TextColor = Color.Blue;
                        break;
                    case "Out(Check)":
                        e.Style.TextColor = Color.MediumSeaGreen;
                        break;
                    default:
                        e.Style.TextColor = Color.Green;
                        break;
                }           
            }
        }

        //private void SfDataGrid1_DrawCell(object sender, DrawCellEventArgs e)
        //{
        //    // Ensure we are working with the "TruckVehicleRegNo" column
        //    if (e.Column.MappingName == "TruckVehicleRegNo" && e.DataRow.RowData is ICD_TruckProcess rowData)
        //    {
        //        // Clear the default background
        //        e.Graphics.FillRectangle(new SolidBrush(e.Style.BackColor), e.Bounds);

        //        // Determine badge color based on status
        //        Color badgeColor;
        //        switch (rowData.Status)
        //        {
        //            case "In(Check)":
        //                badgeColor = Color.Orange;
        //                break;
        //            case "In":
        //                badgeColor = Color.Purple;
        //                break;
        //            case "In(Weight)":
        //                badgeColor = Color.Orchid;
        //                break;
        //            case "Operation":
        //                badgeColor = Color.LightSkyBlue;
        //                break;
        //            case "Out(Weight)":
        //                badgeColor = Color.Blue;
        //                break;
        //            case "Out(Check)":
        //                badgeColor = Color.MediumSeaGreen;
        //                break;
        //            default:
        //                badgeColor = Color.Green;
        //                break;
        //        }

        //        // Measure text size
        //        var font = e.Style.Font.GetFont() ?? new Font("Arial", 10, FontStyle.Bold);
        //        var textSize = e.Graphics.MeasureString(rowData.TruckVehicleRegNo, font);

        //        // Define padding and badge dimensions
        //        var padding = 10; // Space around the text
        //        var badgeWidth = (int)(textSize.Width + 2 * padding);
        //        var badgeHeight = (int)(textSize.Height + padding);
        //        var badgeBounds = new Rectangle(
        //            e.Bounds.X + 5, // Slight margin from the left
        //            e.Bounds.Y + (e.Bounds.Height - badgeHeight) / 2, // Center vertically
        //            badgeWidth,
        //            badgeHeight
        //        );

        //        // Draw the badge rectangle with rounded corners
        //        using (GraphicsPath path = new GraphicsPath())
        //        {
        //            float cornerRadius = 5f;
        //            path.AddArc(badgeBounds.X, badgeBounds.Y, cornerRadius, cornerRadius, 180, 90);
        //            path.AddArc(badgeBounds.X + badgeBounds.Width - cornerRadius, badgeBounds.Y, cornerRadius, cornerRadius, 270, 90);
        //            path.AddArc(badgeBounds.X + badgeBounds.Width - cornerRadius, badgeBounds.Y + badgeBounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        //            path.AddArc(badgeBounds.X, badgeBounds.Y + badgeBounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        //            path.CloseFigure();

        //            using (Brush badgeBrush = new SolidBrush(badgeColor))
        //            {
        //                e.Graphics.FillPath(badgeBrush, path);
        //            }
        //        }

        //        // Draw the truck number inside the badge
        //        var textBrush = new SolidBrush(Color.White);
        //        var textBounds = new RectangleF(
        //            badgeBounds.X + padding / 2,
        //            badgeBounds.Y + (badgeHeight - textSize.Height) / 2,
        //            textSize.Width,
        //            textSize.Height
        //        );
        //        var stringFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        //        e.Graphics.DrawString(rowData.TruckVehicleRegNo, font, textBrush, textBounds, stringFormat);

        //        // Redraw the cell border
        //        using (Pen borderPen = new Pen(Color.Gray, 1)) // Adjust the border color and thickness as needed
        //        {
        //            e.Graphics.DrawRectangle(borderPen, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
        //        }

        //        // Mark the event as handled
        //        e.Handled = true;
        //    }
        //}
      
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
            if ((sfDataGrid1.View != null && truckList != null))
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
