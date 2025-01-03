﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Gate.Models;
using TMS_Gate.Services;

namespace TMS_Gate.Forms
{
    partial class CtlTruckIn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public List<ICD_InBoundCheck> inboundList;
        List<string> pCardList;
        ICD_InBoundCheck inboundCheck = new ICD_InBoundCheck();
        private GateApiService _apiService = new GateApiService();
        public static int count = CommonData.count;
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCapture = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDetail = new Syncfusion.WinForms.Controls.SfButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sfComboBoxCard = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCargoInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrailerNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgate = new System.Windows.Forms.Label();
            this.lblyard = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPreview = new Syncfusion.WinForms.Controls.SfButton();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(301, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "In Bound Gate Pass Record";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCapture);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.RealPlayWnd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 707);
            this.panel1.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(1008, 472);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 40);
            this.btnClose.Style.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Style.ForeColor = System.Drawing.Color.White;
            this.btnClose.Style.Image = global::TMS_Gate.Properties.Resources.delete1;
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(245, 474);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(96, 40);
            this.btnCapture.Style.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapture.Style.ForeColor = System.Drawing.Color.White;
            this.btnCapture.TabIndex = 44;
            this.btnCapture.Text = "C&apture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClear.Location = new System.Drawing.Point(874, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 40);
            this.btnClear.Style.BackColor = System.Drawing.Color.Red;
            this.btnClear.Style.ForeColor = System.Drawing.Color.White;
            this.btnClear.Style.Image = global::TMS_Gate.Properties.Resources.refresh;
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSave.Location = new System.Drawing.Point(729, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 40);
            this.btnSave.Style.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Style.ForeColor = System.Drawing.Color.White;
            this.btnSave.Style.Image = global::TMS_Gate.Properties.Resources.document_check;
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "&Gate In";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDetail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDetail.Location = new System.Drawing.Point(584, 474);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(129, 40);
            this.btnDetail.Style.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDetail.Style.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Style.Image = global::TMS_Gate.Properties.Resources.document_text;
            this.btnDetail.TabIndex = 40;
            this.btnDetail.Text = "&Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.sfComboBoxCard);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCargoInfo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDriver);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTrailerNo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTruckNo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblgate);
            this.panel2.Controls.Add(this.lblyard);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(533, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 408);
            this.panel2.TabIndex = 39;
            // 
            // sfComboBoxCard
            // 
            this.sfComboBoxCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sfComboBoxCard.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.sfComboBoxCard.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxCard.Location = new System.Drawing.Point(204, 60);
            this.sfComboBoxCard.Name = "sfComboBoxCard";
            this.sfComboBoxCard.Size = new System.Drawing.Size(368, 31);
            this.sfComboBoxCard.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxCard.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxCard.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBoxCard.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBoxCard.TabIndex = 1;
            this.sfComboBoxCard.TabStop = false;
            this.sfComboBoxCard.SelectedIndexChanged += new System.EventHandler(this.sfComboBoxCard_SelectedIndexChanged);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(204, 450);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(368, 30);
            this.txtArea.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Area:";
            // 
            // txtCargoInfo
            // 
            this.txtCargoInfo.Enabled = false;
            this.txtCargoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoInfo.Location = new System.Drawing.Point(204, 319);
            this.txtCargoInfo.Multiline = true;
            this.txtCargoInfo.Name = "txtCargoInfo";
            this.txtCargoInfo.Size = new System.Drawing.Size(368, 50);
            this.txtCargoInfo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cargo:";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(204, 274);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(368, 30);
            this.txtCategory.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Category:";
            // 
            // txtDriver
            // 
            this.txtDriver.Enabled = false;
            this.txtDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriver.Location = new System.Drawing.Point(204, 214);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(368, 30);
            this.txtDriver.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Driver:";
            // 
            // txtTrailerNo
            // 
            this.txtTrailerNo.Enabled = false;
            this.txtTrailerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrailerNo.Location = new System.Drawing.Point(204, 162);
            this.txtTrailerNo.Name = "txtTrailerNo";
            this.txtTrailerNo.Size = new System.Drawing.Size(368, 30);
            this.txtTrailerNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Trailer No:";
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.Enabled = false;
            this.txtTruckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckNo.Location = new System.Drawing.Point(204, 107);
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(368, 30);
            this.txtTruckNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Truck No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Card No:";
            // 
            // lblgate
            // 
            this.lblgate.AutoSize = true;
            this.lblgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgate.Location = new System.Drawing.Point(460, 15);
            this.lblgate.Name = "lblgate";
            this.lblgate.Size = new System.Drawing.Size(115, 25);
            this.lblgate.TabIndex = 30;
            this.lblgate.Text = global::TMS_Gate.Properties.Settings.Default.Gate;
            // 
            // lblyard
            // 
            this.lblyard.AutoSize = true;
            this.lblyard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyard.Location = new System.Drawing.Point(218, 16);
            this.lblyard.Name = "lblyard";
            this.lblyard.Size = new System.Drawing.Size(56, 25);
            this.lblyard.TabIndex = 29;
            this.lblyard.Text = global::TMS_Gate.Properties.Settings.Default.Yard;
            this.lblyard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Gate :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Yard :";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPreview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(100, 474);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(124, 40);
            this.btnPreview.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPreview.TabIndex = 45;
            this.btnPreview.Text = "&Live View";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RealPlayWnd.Location = new System.Drawing.Point(6, 57);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(521, 409);
            this.RealPlayWnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RealPlayWnd.TabIndex = 38;
            this.RealPlayWnd.TabStop = false;
            // 
            // CtlTruckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CtlTruckIn";
            this.Size = new System.Drawing.Size(1300, 707);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.ResumeLayout(false);

        }
        public async Task LoadData()
        {
            inboundList = new List<ICD_InBoundCheck>();
            List<ICD_InBoundCheck> inCheckList = new List<ICD_InBoundCheck>();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.sfComboBoxCard.DataSource = null;
            inCheckList = await _apiService.GetInBoundCheckCardList(yard, gate);
            if (inCheckList.Count > 0)
            {
                inboundList = inCheckList;
                pCardList = new List<string>();
                pCardList = inCheckList.Select(x => x.CardNo).ToList();
                this.sfComboBoxCard.DataSource = pCardList;
            }
        }



        private void ClearData()
        {
            txtTruckNo.Text = "";
            txtCategory.Text = "";
            txtCargoInfo.Text = "";
            txtDriver.Text = "";
            txtTrailerNo.Text = "";
            txtArea.Text = "";
            sfComboBoxCard.SelectedItem = null;
            if (m_lRealHandle >= 0)
            {
                HCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                m_lRealHandle = -1;
            }

            RealPlayWnd.Image = null;
            fileUpload = null;
            inboundCheck = null;
        }
        public void FillInCheckData(string cardNo)
        {
            inboundCheck = inboundList.Find(x => x.CardNo == cardNo);
            if (inboundCheck != null)
            {
                sfComboBoxCard.SelectedItem = inboundCheck.CardNo;
                txtTruckNo.Text = inboundCheck.TruckVehicleRegNo;
                txtCategory.Text = inboundCheck.InPCCode;
                txtCargoInfo.Text = inboundCheck.InCargoInfo;
                txtDriver.Text = inboundCheck.DriverName;
                txtTrailerNo.Text = inboundCheck.TrailerVehicleRegNo;
                txtArea.Text = inboundCheck.AreaID;
            }

        }

        private async Task<ResponseMessage> SaveGateInData()
        {
            ResponseMessage msg = new ResponseMessage();
            ICD_InBoundCheck inCheck = new ICD_InBoundCheck();
            if (sfComboBoxCard.SelectedItem != null)
            {
                inCheck.CardNo = sfComboBoxCard.SelectedItem.ToString();
                inCheck = inboundList.Find(x => x.CardNo == inCheck.CardNo);
                inCheck.UploadPhoto = fileUpload;
                if (Networking.IsInternetConnected())
                {
                    msg = await _apiService.SaveGateIn(inCheck);
                }
                else
                {
                    msg = DataAccess.AddGateInData(inCheck.CardNo);
                    //MessageBoxAdv.Show(this, "Please check the internet!", "Gate In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return msg;
                }
                if (msg.Status == true)
                {
                    LoadData();
                    ClearData();
                }

                return msg;
            }
            return msg;
        }
        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnCapture;
        private Syncfusion.WinForms.Controls.SfButton btnClear;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private Syncfusion.WinForms.Controls.SfButton btnDetail;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBoxCard;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCargoInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrailerNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgate;
        private System.Windows.Forms.Label lblyard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Syncfusion.WinForms.Controls.SfButton btnPreview;
        private System.Windows.Forms.PictureBox RealPlayWnd;
    }
}
