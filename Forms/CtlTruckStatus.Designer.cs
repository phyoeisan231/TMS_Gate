using System.Collections.Generic;
using System;
using TMS_Gate.Model;
using TMS_Gate.Services;
using TMS_Gate.Models;

namespace TMS_Gate.Forms
{
    partial class CtlTruckStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlTruckStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.sfDateTruckF = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateTruckTo = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfBtnTruckView = new Syncfusion.WinForms.Controls.SfButton();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label1.Text = "Truck Status Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sfDateTruckF
            // 
            this.sfDateTruckF.DateTimeIcon = null;
            this.sfDateTruckF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateTruckF.Location = new System.Drawing.Point(136, 58);
            this.sfDateTruckF.Name = "sfDateTruckF";
            this.sfDateTruckF.Size = new System.Drawing.Size(197, 28);
            this.sfDateTruckF.TabIndex = 2;
            this.sfDateTruckF.ToolTipText = "";
            // 
            // sfDateTruckTo
            // 
            this.sfDateTruckTo.DateTimeIcon = null;
            this.sfDateTruckTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateTruckTo.Location = new System.Drawing.Point(408, 58);
            this.sfDateTruckTo.Name = "sfDateTruckTo";
            this.sfDateTruckTo.Size = new System.Drawing.Size(191, 28);
            this.sfDateTruckTo.TabIndex = 3;
            this.sfDateTruckTo.ToolTipText = "";
            // 
            // sfBtnTruckView
            // 
            this.sfBtnTruckView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnTruckView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnTruckView.ForeColor = System.Drawing.Color.White;
            this.sfBtnTruckView.Location = new System.Drawing.Point(647, 51);
            this.sfBtnTruckView.Name = "sfBtnTruckView";
            this.sfBtnTruckView.Size = new System.Drawing.Size(96, 37);
            this.sfBtnTruckView.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnTruckView.Style.ForeColor = System.Drawing.Color.White;
            this.sfBtnTruckView.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfBtnTruckView.TabIndex = 4;
            this.sfBtnTruckView.Text = "&View";
            this.sfBtnTruckView.UseVisualStyleBackColor = false;
            this.sfBtnTruckView.Click += new System.EventHandler(this.sfBtnTruckView_Click);
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowEditing = false;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.AllowStandardTab = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.Location = new System.Drawing.Point(13, 12);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Padding = new System.Windows.Forms.Padding(1);
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(1291, 160);
            this.sfDataGrid1.TabIndex = 6;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "From :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "To :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sfDataGrid1);
            this.panel1.Location = new System.Drawing.Point(2, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 651);
            this.panel1.TabIndex = 9;
            // 
            // CtlTruckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfBtnTruckView);
            this.Controls.Add(this.sfDateTruckTo);
            this.Controls.Add(this.sfDateTruckF);
            this.Controls.Add(this.label1);
            this.Name = "CtlTruckStatus";
            this.Size = new System.Drawing.Size(1318, 760);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void LoadData(DateTime fDate, DateTime tDate)
        {
            _apiService = new GateApiService();
            List<ICD_TruckProcess> truckList = new List<ICD_TruckProcess>();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.sfDataGrid1.DataSource = null;
            truckList = await _apiService.GetTruckStatusReport(yard, gate, fDate.ToString("yyyy-MM-dd"), tDate.ToString("yyyy-MM-dd"));
            if (truckList.Count > 0)
            {
                this.sfDataGrid1.DataSource = truckList;
            }
            this.sfBtnTruckView.Enabled = true;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTruckF;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTruckTo;
        private Syncfusion.WinForms.Controls.SfButton sfBtnTruckView;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
