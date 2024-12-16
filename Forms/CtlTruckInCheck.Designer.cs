using System;
using System.Collections.Generic;
using System.Linq;
using TMS_Gate.Model;
using TMS_Gate.Services;

namespace TMS_Gate.Forms
{
    partial class CtlTruckInCheck
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlTruckInCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.sfDateIncF = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateIncTo = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfBtnIncView = new Syncfusion.WinForms.Controls.SfButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sfBtnInc = new Syncfusion.WinForms.Controls.SfButton();
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
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "In Bound Check List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sfDateIncF
            // 
            this.sfDateIncF.DateTimeIcon = null;
            this.sfDateIncF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateIncF.Location = new System.Drawing.Point(80, 50);
            this.sfDateIncF.Margin = new System.Windows.Forms.Padding(2);
            this.sfDateIncF.Name = "sfDateIncF";
            this.sfDateIncF.Size = new System.Drawing.Size(148, 23);
            this.sfDateIncF.TabIndex = 2;
            this.sfDateIncF.ToolTipText = "";
            // 
            // sfDateIncTo
            // 
            this.sfDateIncTo.DateTimeIcon = null;
            this.sfDateIncTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateIncTo.Location = new System.Drawing.Point(304, 50);
            this.sfDateIncTo.Margin = new System.Windows.Forms.Padding(2);
            this.sfDateIncTo.Name = "sfDateIncTo";
            this.sfDateIncTo.Size = new System.Drawing.Size(143, 23);
            this.sfDateIncTo.TabIndex = 3;
            this.sfDateIncTo.ToolTipText = "";
            // 
            // sfBtnIncView
            // 
            this.sfBtnIncView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnIncView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnIncView.ForeColor = System.Drawing.Color.White;
            this.sfBtnIncView.Location = new System.Drawing.Point(480, 46);
            this.sfBtnIncView.Name = "sfBtnIncView";
            this.sfBtnIncView.Size = new System.Drawing.Size(80, 28);
            this.sfBtnIncView.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnIncView.Style.ForeColor = System.Drawing.Color.White;
            this.sfBtnIncView.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfBtnIncView.TabIndex = 4;
            this.sfBtnIncView.Text = "&View";
            this.sfBtnIncView.UseVisualStyleBackColor = false;
            this.sfBtnIncView.Click += new System.EventHandler(this.sfBtnIncView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "From :";
            // 
            // sfBtnInc
            // 
            this.sfBtnInc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnInc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnInc.ForeColor = System.Drawing.Color.White;
            this.sfBtnInc.Location = new System.Drawing.Point(578, 46);
            this.sfBtnInc.Name = "sfBtnInc";
            this.sfBtnInc.Size = new System.Drawing.Size(80, 28);
            this.sfBtnInc.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnInc.Style.ForeColor = System.Drawing.Color.White;
            this.sfBtnInc.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.sfBtnInc.TabIndex = 7;
            this.sfBtnInc.Text = "Gate In";
            this.sfBtnInc.UseVisualStyleBackColor = false;
            this.sfBtnInc.Click += new System.EventHandler(this.sfBtnIn_Click);
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.sfDataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDataGrid1.Location = new System.Drawing.Point(2, 2);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.SerializationController = null;
            this.sfDataGrid1.Size = new System.Drawing.Size(975, 126);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.sfDataGrid1);
            this.panel1.Location = new System.Drawing.Point(2, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 529);
            this.panel1.TabIndex = 8;
            // 
            // sfbtnExport
            // 
            this.sfbtnExport.BackColor = System.Drawing.Color.LightGreen;
            this.sfbtnExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfbtnExport.ForeColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Location = new System.Drawing.Point(678, 46);
            this.sfbtnExport.Name = "sfbtnExport";
            this.sfbtnExport.Size = new System.Drawing.Size(80, 28);
            this.sfbtnExport.Style.BackColor = System.Drawing.Color.LightGreen;
            this.sfbtnExport.Style.ForeColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.sfbtnExport.TabIndex = 10;
            this.sfbtnExport.Text = "Export";
            this.sfbtnExport.UseVisualStyleBackColor = false;
            this.sfbtnExport.Click += new System.EventHandler(this.sfbtnExport_Click);
            // 
            // CtlTruckInCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sfbtnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sfBtnInc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfBtnIncView);
            this.Controls.Add(this.sfDateIncTo);
            this.Controls.Add(this.sfDateIncF);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CtlTruckInCheck";
            this.Size = new System.Drawing.Size(988, 618);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void LoadData(DateTime fDate,DateTime tDate)
        {
            _apiService = new GateApiService();
            List<ICD_InBoundCheck> inCheckList = new List<ICD_InBoundCheck>();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.sfDataGrid1.DataSource = null;
            inCheckList = await _apiService.GetInBoundCheckList(yard, gate,fDate.ToString("yyyy-MM-dd"), tDate.ToString("yyyy-MM-dd"));
            if (inCheckList.Count > 0)
            {
                this.sfDataGrid1.DataSource = inCheckList;
            }
            btnEnabled();
        }
        #endregion
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateIncF;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateIncTo;
        private Syncfusion.WinForms.Controls.SfButton sfBtnIncView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton sfBtnInc;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton sfbtnExport;
    }
}
