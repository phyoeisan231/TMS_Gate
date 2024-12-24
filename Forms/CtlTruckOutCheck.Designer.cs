using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using TMS_Gate.Model;
using TMS_Gate.Models;
using TMS_Gate.Services;
using Syncfusion.Data;

namespace TMS_Gate.Forms
{
    partial class CtlTruckOutCheck
    {
        /// <summary> 
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;
        public List<ICD_InBoundCheck> inboundList;
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
            Syncfusion.WinForms.DataGrid.GridTableSummaryRow gridTableSummaryRow1 = new Syncfusion.WinForms.DataGrid.GridTableSummaryRow();
            Syncfusion.WinForms.DataGrid.GridSummaryColumn gridSummaryColumn1 = new Syncfusion.WinForms.DataGrid.GridSummaryColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlTruckOutCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDateOutcF = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateOutcTo = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sfBtnOutView = new Syncfusion.WinForms.Controls.SfButton();
            this.sfBtnOutc = new Syncfusion.WinForms.Controls.SfButton();
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
            this.label1.Size = new System.Drawing.Size(1318, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Out Bound Check List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDataGrid1.Location = new System.Drawing.Point(9, 3);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(1291, 499);
            this.sfDataGrid1.TabIndex = 2;
            gridTableSummaryRow1.Name = "TotalCases";
            gridTableSummaryRow1.Position = Syncfusion.WinForms.DataGrid.Enums.VerticalPosition.Top;
            gridSummaryColumn1.Format = "{Count}";
            gridSummaryColumn1.MappingName = "OutRegNo";
            gridSummaryColumn1.Name = "TotalTruck";
            gridSummaryColumn1.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate;
            gridTableSummaryRow1.SummaryColumns.Add(gridSummaryColumn1);
            gridTableSummaryRow1.Title = " Total Truck Count: {TotalTruck}";
            this.sfDataGrid1.TableSummaryRows.Add(gridTableSummaryRow1);
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // sfDateOutcF
            // 
            this.sfDateOutcF.DateTimeIcon = null;
            this.sfDateOutcF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateOutcF.Location = new System.Drawing.Point(95, 61);
            this.sfDateOutcF.Name = "sfDateOutcF";
            this.sfDateOutcF.Size = new System.Drawing.Size(188, 28);
            this.sfDateOutcF.TabIndex = 4;
            this.sfDateOutcF.ToolTipText = "";
            // 
            // sfDateOutcTo
            // 
            this.sfDateOutcTo.DateTimeIcon = null;
            this.sfDateOutcTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateOutcTo.Location = new System.Drawing.Point(401, 62);
            this.sfDateOutcTo.Name = "sfDateOutcTo";
            this.sfDateOutcTo.Size = new System.Drawing.Size(177, 28);
            this.sfDateOutcTo.TabIndex = 5;
            this.sfDateOutcTo.ToolTipText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "From :";
            // 
            // sfBtnOutView
            // 
            this.sfBtnOutView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnOutView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnOutView.ForeColor = System.Drawing.Color.White;
            this.sfBtnOutView.Location = new System.Drawing.Point(608, 60);
            this.sfBtnOutView.Name = "sfBtnOutView";
            this.sfBtnOutView.Size = new System.Drawing.Size(107, 34);
            this.sfBtnOutView.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnOutView.Style.ForeColor = System.Drawing.Color.White;
            this.sfBtnOutView.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfBtnOutView.TabIndex = 8;
            this.sfBtnOutView.Text = "&View";
            this.sfBtnOutView.UseVisualStyleBackColor = false;
            this.sfBtnOutView.Click += new System.EventHandler(this.sfBtnOutView_Click);
            // 
            // sfBtnOutc
            // 
            this.sfBtnOutc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnOutc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnOutc.ForeColor = System.Drawing.Color.White;
            this.sfBtnOutc.Location = new System.Drawing.Point(736, 60);
            this.sfBtnOutc.Name = "sfBtnOutc";
            this.sfBtnOutc.Size = new System.Drawing.Size(130, 34);
            this.sfBtnOutc.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnOutc.Style.ForeColor = System.Drawing.Color.White;
            this.sfBtnOutc.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.sfBtnOutc.TabIndex = 9;
            this.sfBtnOutc.Text = "&Truck Out";
            this.sfBtnOutc.UseVisualStyleBackColor = false;
            this.sfBtnOutc.Click += new System.EventHandler(this.sfBtnOutc_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sfDataGrid1);
            this.panel1.Location = new System.Drawing.Point(2, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 651);
            this.panel1.TabIndex = 10;
            // 
            // sfbtnExport
            // 
            this.sfbtnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfbtnExport.ForeColor = System.Drawing.Color.White;
            this.sfbtnExport.Location = new System.Drawing.Point(888, 60);
            this.sfbtnExport.Margin = new System.Windows.Forms.Padding(4);
            this.sfbtnExport.Name = "sfbtnExport";
            this.sfbtnExport.Size = new System.Drawing.Size(107, 34);
            this.sfbtnExport.Style.BackColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Style.ForeColor = System.Drawing.Color.White;
            this.sfbtnExport.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.sfbtnExport.TabIndex = 11;
            this.sfbtnExport.Text = "&Export";
            this.sfbtnExport.UseVisualStyleBackColor = false;
            this.sfbtnExport.Click += new System.EventHandler(this.sfbtnExport_Click);
            // 
            // CtlTruckOutCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sfbtnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sfBtnOutc);
            this.Controls.Add(this.sfBtnOutView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfDateOutcTo);
            this.Controls.Add(this.sfDateOutcF);
            this.Controls.Add(this.label1);
            this.Name = "CtlTruckOutCheck";
            this.Size = new System.Drawing.Size(1318, 760);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void LoadData(DateTime fDate, DateTime tDate)
        {
            _apiService = new GateApiService();
            List<ICD_OutBoundCheck> outCheckList = new List<ICD_OutBoundCheck>();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.sfDataGrid1.DataSource = null;
            outCheckList = await _apiService.GetOutBoundCheckList(yard, gate, fDate.ToString("yyyy-MM-dd"), tDate.ToString("yyyy-MM-dd"));
            if (outCheckList.Count > 0)
            {
                this.sfDataGrid1.DataSource = outCheckList;
            }
            btnEnabled();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateOutcF;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateOutcTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton sfBtnOutView;
        private Syncfusion.WinForms.Controls.SfButton sfBtnOutc;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton sfbtnExport;
    }
}
