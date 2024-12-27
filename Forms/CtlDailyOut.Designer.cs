using System.Collections.Generic;
using System;
using TMS_Gate.Models;
using TMS_Gate.Services;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Data;

namespace TMS_Gate.Forms
{
    partial class CtlDailyOut
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GateApiService _apiService;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlDailyOut));
            this.label1 = new System.Windows.Forms.Label();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfbtnExport = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1318, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Out Bound Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.Location = new System.Drawing.Point(8, 7);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(1300, 458);
            this.sfDataGrid1.TabIndex = 1;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sfDataGrid1);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 684);
            this.panel1.TabIndex = 2;
            // 
            // sfbtnExport
            // 
            this.sfbtnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfbtnExport.ForeColor = System.Drawing.Color.White;
            this.sfbtnExport.Location = new System.Drawing.Point(16, 35);
            this.sfbtnExport.Margin = new System.Windows.Forms.Padding(4);
            this.sfbtnExport.Name = "sfbtnExport";
            this.sfbtnExport.Size = new System.Drawing.Size(107, 34);
            this.sfbtnExport.Style.BackColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Style.ForeColor = System.Drawing.Color.White;
            this.sfbtnExport.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfbtnExport.TabIndex = 11;
            this.sfbtnExport.Text = "Export";
            this.sfbtnExport.UseVisualStyleBackColor = false;
            this.sfbtnExport.Click += new System.EventHandler(this.sfbtnExport_Click);
            // 
            // CtlDailyOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sfbtnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "CtlDailyOut";
            this.Size = new System.Drawing.Size(1318, 760);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            Syncfusion.WinForms.DataGrid.GridTableSummaryRow gridTableSummaryRow1 = new Syncfusion.WinForms.DataGrid.GridTableSummaryRow();
            gridTableSummaryRow1.Name = "TotalCases";
            gridTableSummaryRow1.ShowSummaryInRow = true;
            gridTableSummaryRow1.Title = " Total Truck Count: {TotalTruck}";
            gridTableSummaryRow1.Position = VerticalPosition.Top;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "TotalTruck";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "{Count}";
            summaryColumn1.MappingName = "OutRegNo";

            gridTableSummaryRow1.SummaryColumns.Add(summaryColumn1);

            this.sfDataGrid1.TableSummaryRows.Add(gridTableSummaryRow1);

        }

        private async void LoadData()
        {
            _apiService = new GateApiService();
            List<ICD_OutBoundCheck> inCheckList = new List<ICD_OutBoundCheck>();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.sfDataGrid1.DataSource = null;
            inCheckList = await _apiService.GetDailyOutReport(yard, gate, DateTime.UtcNow.ToString("yyyy-MM-dd"), DateTime.UtcNow.ToString("yyyy-MM-dd"));
            if (inCheckList.Count > 0)
            {
                this.sfDataGrid1.DataSource = inCheckList;
            }
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton sfbtnExport;
    }
}
