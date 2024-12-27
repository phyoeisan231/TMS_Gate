using System.Collections.Generic;
using System;
using TMS_Gate.Services;
using TMS_Gate.Models;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.Data;

namespace TMS_Gate.Forms
{
    partial class CtlTruckStatus
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GateApiService _apiService;
        private List<ICD_TruckProcess> truckList = new List<ICD_TruckProcess>();

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlTruckStatus));
            Syncfusion.WinForms.DataGrid.GridTableSummaryRow gridTableSummaryRow1 = new Syncfusion.WinForms.DataGrid.GridTableSummaryRow();
            Syncfusion.WinForms.DataGrid.GridSummaryColumn gridSummaryColumn1 = new Syncfusion.WinForms.DataGrid.GridSummaryColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sfDateTruckF = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateTruckTo = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfBtnTruckView = new Syncfusion.WinForms.Controls.SfButton();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sfbtnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.label4 = new System.Windows.Forms.Label();
            this.sfComboBoxStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.sfDateTruckF.Location = new System.Drawing.Point(101, 51);
            this.sfDateTruckF.Name = "sfDateTruckF";
            this.sfDateTruckF.Size = new System.Drawing.Size(197, 35);
            this.sfDateTruckF.TabIndex = 2;
            this.sfDateTruckF.ToolTipText = "";
            // 
            // sfDateTruckTo
            // 
            this.sfDateTruckTo.DateTimeIcon = null;
            this.sfDateTruckTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateTruckTo.Location = new System.Drawing.Point(361, 51);
            this.sfDateTruckTo.Name = "sfDateTruckTo";
            this.sfDateTruckTo.Size = new System.Drawing.Size(191, 35);
            this.sfDateTruckTo.TabIndex = 3;
            this.sfDateTruckTo.ToolTipText = "";
            // 
            // sfBtnTruckView
            // 
            this.sfBtnTruckView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sfBtnTruckView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtnTruckView.ForeColor = System.Drawing.Color.White;
            this.sfBtnTruckView.Location = new System.Drawing.Point(880, 49);
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
            this.sfDataGrid1.AllowDrop = true;
            this.sfDataGrid1.AllowEditing = false;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.AllowStandardTab = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 3);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Padding = new System.Windows.Forms.Padding(1);
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(1292, 434);
            this.sfDataGrid1.SummaryCalculationMode = Syncfusion.Data.CalculationMode.OnDemandGroupSummary;
            this.sfDataGrid1.TabIndex = 6;
            gridTableSummaryRow1.Name = "TotalCases";
            gridTableSummaryRow1.Position = Syncfusion.WinForms.DataGrid.Enums.VerticalPosition.Top;
            gridSummaryColumn1.Format = "{Count}";
            gridSummaryColumn1.MappingName = "InRegNo";
            gridSummaryColumn1.Name = "TotalTruck";
            gridSummaryColumn1.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate;
            gridTableSummaryRow1.SummaryColumns.Add(gridSummaryColumn1);
            gridTableSummaryRow1.Title = " Total Truck Count: {TotalTruck}";
            this.sfDataGrid1.TableSummaryRows.Add(gridTableSummaryRow1);
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "From :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "To :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sfDataGrid1);
            this.panel1.Location = new System.Drawing.Point(2, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 651);
            this.panel1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(670, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Out";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Out(Check)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Out(Weight)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Opt End";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Green;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.Control;
            this.button15.Location = new System.Drawing.Point(641, 442);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(23, 18);
            this.button15.TabIndex = 25;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(540, 442);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(23, 18);
            this.button14.TabIndex = 24;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Blue;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(434, 442);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(23, 18);
            this.button13.TabIndex = 23;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DodgerBlue;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(339, 442);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(23, 18);
            this.button12.TabIndex = 22;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Opt Start";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(250, 443);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(23, 18);
            this.button11.TabIndex = 20;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "In(Weight)";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(158, 443);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(23, 18);
            this.button10.TabIndex = 18;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "In";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Orchid;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(108, 443);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 18);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "In(Check)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(10, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 18);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sfbtnExport
            // 
            this.sfbtnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfbtnExport.ForeColor = System.Drawing.Color.White;
            this.sfbtnExport.Location = new System.Drawing.Point(989, 49);
            this.sfbtnExport.Margin = new System.Windows.Forms.Padding(4);
            this.sfbtnExport.Name = "sfbtnExport";
            this.sfbtnExport.Size = new System.Drawing.Size(96, 37);
            this.sfbtnExport.Style.BackColor = System.Drawing.Color.ForestGreen;
            this.sfbtnExport.Style.ForeColor = System.Drawing.Color.White;
            this.sfbtnExport.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.sfbtnExport.TabIndex = 11;
            this.sfbtnExport.Text = "Export";
            this.sfbtnExport.UseVisualStyleBackColor = false;
            this.sfbtnExport.Click += new System.EventHandler(this.sfbtnExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status :";
            // 
            // sfComboBoxStatus
            // 
            this.sfComboBoxStatus.AllowSelectAll = true;
            this.sfComboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.sfComboBoxStatus.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            this.sfComboBoxStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxStatus.Location = new System.Drawing.Point(662, 55);
            this.sfComboBoxStatus.Name = "sfComboBoxStatus";
            this.sfComboBoxStatus.ShowToolTip = true;
            this.sfComboBoxStatus.Size = new System.Drawing.Size(144, 31);
            this.sfComboBoxStatus.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxStatus.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBoxStatus.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxStatus.TabIndex = 3;
            this.sfComboBoxStatus.TabStop = false;
            // 
            // CtlTruckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sfComboBoxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sfbtnExport);
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void LoadData(DateTime fDate, DateTime tDate,string status)
        {
            _apiService = new GateApiService();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.sfDataGrid1.DataSource = null;
            truckList = await _apiService.GetTruckStatusReport(yard, gate, fDate.ToString("yyyy-MM-dd"), tDate.ToString("yyyy-MM-dd"), status);
            if (truckList.Count > 0)
            {
                this.sfDataGrid1.DataSource = truckList;
            }
            this.sfBtnTruckView.Enabled = true;
            this.sfDataGrid1.Refresh();
        }

        //private  void InitailizeGridData()
        //{
        //    //InitializeComponent();
        //    if (truckList.Count > 0)
        //    {
        //        this.sfDataPager1.PageSize = 10;
        //        this.sfDataPager1.DataSource = truckList;
        //        if (this.sfDataPager1.PagedSource != null)
        //        {
        //            try
        //            {
        //                sfDataGrid1.DataSource = sfDataPager1.PagedSource;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}");
        //            }

        //        }
        //    }
        //    this.sfDataGrid1.Refresh();
        //}

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTruckF;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTruckTo;
        private Syncfusion.WinForms.Controls.SfButton sfBtnTruckView;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton sfbtnExport;
        private System.Windows.Forms.Label label4;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBoxStatus;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Button button1;
        private Label label7;
        private Button button10;
        private Label label6;
        private Button button9;
        private Label label5;
        private Label label8;
        private Button button11;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
    }
}
