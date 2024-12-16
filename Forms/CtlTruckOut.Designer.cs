using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using TMS_Gate.Model;
using TMS_Gate.Models;
using TMS_Gate.Services;
using System.Linq;

namespace TMS_Gate.Forms
{
    partial class CtlTruckOut
    {
        public List<ICD_OutBoundCheck> outboundList;
        List<string> pCardList;
        ICD_OutBoundCheck outboundCheck = new ICD_OutBoundCheck();
        public static int count = BaseUrl.count;
        private GateApiService _apiService = new GateApiService();
        //private readonly IConnectivity _connectivity;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnClose = new System.Windows.Forms.Button();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.txtTrailerNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargoInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelyard = new System.Windows.Forms.Label();
            this.lblyard = new System.Windows.Forms.Label();
            this.lblgate = new System.Windows.Forms.Label();
            this.cmbcard = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(871, 645);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RealPlayWnd.Location = new System.Drawing.Point(17, 98);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(534, 541);
            this.RealPlayWnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RealPlayWnd.TabIndex = 1;
            this.RealPlayWnd.TabStop = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(346, 645);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 36);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "&Live View";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Location = new System.Drawing.Point(451, 645);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(100, 36);
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "C&apture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Card No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Truck No:";
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.Enabled = false;
            this.txtTruckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckNo.Location = new System.Drawing.Point(667, 213);
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(301, 28);
            this.txtTruckNo.TabIndex = 7;
            // 
            // txtTrailerNo
            // 
            this.txtTrailerNo.Enabled = false;
            this.txtTrailerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrailerNo.Location = new System.Drawing.Point(666, 268);
            this.txtTrailerNo.Name = "txtTrailerNo";
            this.txtTrailerNo.Size = new System.Drawing.Size(301, 28);
            this.txtTrailerNo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trailer No:";
            // 
            // txtDriver
            // 
            this.txtDriver.Enabled = false;
            this.txtDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriver.Location = new System.Drawing.Point(666, 319);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(301, 28);
            this.txtDriver.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Driver:";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(666, 380);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(301, 28);
            this.txtCategory.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category:";
            // 
            // txtCargoInfo
            // 
            this.txtCargoInfo.Enabled = false;
            this.txtCargoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoInfo.Location = new System.Drawing.Point(666, 425);
            this.txtCargoInfo.Multiline = true;
            this.txtCargoInfo.Name = "txtCargoInfo";
            this.txtCargoInfo.Size = new System.Drawing.Size(301, 114);
            this.txtCargoInfo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(556, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cargo:";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(668, 556);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(301, 28);
            this.txtArea.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Area:";
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(556, 645);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(100, 36);
            this.btnDetail.TabIndex = 18;
            this.btnDetail.Text = "&Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(661, 645);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Gate Out";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(766, 645);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "Out Bound Gate Pass Record";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(802, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Gate :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Yard :";
            // 
            // labelyard
            // 
            this.labelyard.AutoSize = true;
            this.labelyard.Location = new System.Drawing.Point(671, 113);
            this.labelyard.Name = "labelyard";
            this.labelyard.Size = new System.Drawing.Size(0, 16);
            this.labelyard.TabIndex = 25;
            // 
            // lblyard
            // 
            this.lblyard.AutoSize = true;
            this.lblyard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyard.Location = new System.Drawing.Point(660, 111);
            this.lblyard.Name = "lblyard";
            this.lblyard.Size = new System.Drawing.Size(45, 20);
            this.lblyard.TabIndex = 26;
            this.lblyard.Text = global::TMS_Gate.Properties.Settings.Default.Yard;
            this.lblyard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgate
            // 
            this.lblgate.AutoSize = true;
            this.lblgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgate.Location = new System.Drawing.Point(883, 109);
            this.lblgate.Name = "lblgate";
            this.lblgate.Size = new System.Drawing.Size(104, 20);
            this.lblgate.TabIndex = 27;
            this.lblgate.Text = global::TMS_Gate.Properties.Settings.Default.Gate;
            // 
            // cmbcard
            // 
            this.cmbcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcard.FormattingEnabled = true;
            this.cmbcard.Location = new System.Drawing.Point(668, 166);
            this.cmbcard.Name = "cmbcard";
            this.cmbcard.Size = new System.Drawing.Size(298, 30);
            this.cmbcard.TabIndex = 28;
            this.cmbcard.SelectedIndexChanged += new System.EventHandler(this.cmbcard_SelectedIndexChanged);
            // 
            // CtlTruckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbcard);
            this.Controls.Add(this.lblgate);
            this.Controls.Add(this.lblyard);
            this.Controls.Add(this.labelyard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCargoInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrailerNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTruckNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.RealPlayWnd);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CtlTruckOut";
            this.Size = new System.Drawing.Size(1093, 750);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public async void LoadData()
        {
            outboundList = new List<ICD_OutBoundCheck>();
            List<ICD_OutBoundCheck> outCheckList = new List<ICD_OutBoundCheck>();
            string yard = Properties.Settings.Default.Yard;
            string gate = Properties.Settings.Default.Gate;
            this.cmbcard.DataSource = null;
            outCheckList = await _apiService.GetOutBoundCheckCardList(yard, gate);
            if (outCheckList.Count > 0)
            {
                outboundList = outCheckList;
                pCardList = new List<string>();
                pCardList = outCheckList.Select(x => x.CardNo).ToList();
                this.cmbcard.DataSource = pCardList;
            }
        }

        private void ComboBoxCard_TextChanged(object sender, EventArgs e)
        {
            if (pCardList != null)
            {
                if (!string.IsNullOrEmpty(cmbcard.Text))
                {
                    string filterText = cmbcard.Text.ToLower();

                    // Filter the list based on user input
                    var filteredItems = pCardList
                        .Where(item => item.ToLower().Contains(filterText))
                        .ToList();

                    // Update ComboBox items
                    cmbcard.DataSource = new BindingSource(filteredItems, null);

                    // Move the caret to the end of the text
                    cmbcard.SelectionStart = cmbcard.Text.Length;
                }
                else
                {
                    cmbcard.DataSource = pCardList;
                }
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
            cmbcard.SelectedItem = null;
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                m_lRealHandle = -1;
            }

            RealPlayWnd.Image = null;
            fileUpload = null;
            outboundCheck = null;
        }
        public void FillInCheckData(string cardNo)
        {
            outboundCheck = outboundList.Find(x => x.CardNo == cardNo);
            if (outboundCheck != null)
            {
                txtTruckNo.Text = outboundCheck.TruckVehicleRegNo;
                txtCategory.Text = outboundCheck.OutPCCode;
                txtCargoInfo.Text = outboundCheck.OutCargoInfo;
                txtDriver.Text = outboundCheck.DriverName;
                txtTrailerNo.Text = outboundCheck.TrailerVehicleRegNo;
                txtArea.Text = outboundCheck.AreaID;
            }          
        }

        private async Task<ResponseMessage> SaveGateOutData()
        {
            ResponseMessage msg = new ResponseMessage();
            ICD_OutBoundCheck outCheck = new ICD_OutBoundCheck();
            if (cmbcard.SelectedItem.ToString() != null)
            {
                outCheck.CardNo = cmbcard.SelectedItem.ToString();
                outCheck = outboundList.Find(x => x.CardNo == outCheck.CardNo);
                outCheck.UploadPhoto = fileUpload;
                msg = await _apiService.SaveGateOut(outCheck);
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

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox RealPlayWnd;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.TextBox txtTrailerNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargoInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
     
        private System.Windows.Forms.Label labelyard;
        private System.Windows.Forms.Label lblyard;
        private System.Windows.Forms.Label lblgate;
        private System.Windows.Forms.ComboBox cmbcard;
    }

}
