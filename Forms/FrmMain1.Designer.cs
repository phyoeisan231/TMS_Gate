using System.Linq;

namespace TMS_Gate.Forms
{
    partial class FrmMain1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIpCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truckStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTool = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnQ = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolBtnTruckIn = new System.Windows.Forms.ToolStripButton();
            this.toolBtnTruckOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnInCheck = new System.Windows.Forms.ToolStripButton();
            this.toolBtnOutCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnTruckStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnDailyIn = new System.Windows.Forms.ToolStripButton();
            this.toolDailyOut = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.truckToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.laborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1318, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.checkIpCameraToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 32);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.delete;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.document_edit;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // checkIpCameraToolStripMenuItem
            // 
            this.checkIpCameraToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.check;
            this.checkIpCameraToolStripMenuItem.Name = "checkIpCameraToolStripMenuItem";
            this.checkIpCameraToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.checkIpCameraToolStripMenuItem.Text = "Check Ip Camera";
            // 
            // truckToolStripMenuItem
            // 
            this.truckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.truckInToolStripMenuItem,
            this.truckOutToolStripMenuItem,
            this.inCheckToolStripMenuItem,
            this.outCheckToolStripMenuItem,
            this.truckStatusToolStripMenuItem,
            this.dailyInToolStripMenuItem,
            this.dailyOutToolStripMenuItem});
            this.truckToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckToolStripMenuItem.Name = "truckToolStripMenuItem";
            this.truckToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.truckToolStripMenuItem.Text = "Truck";
            this.truckToolStripMenuItem.Click += new System.EventHandler(this.truckToolStripMenuItem_Click);
            // 
            // truckInToolStripMenuItem
            // 
            this.truckInToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.nav_up_blue;
            this.truckInToolStripMenuItem.Name = "truckInToolStripMenuItem";
            this.truckInToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.truckInToolStripMenuItem.Text = "Truck(In)";
            this.truckInToolStripMenuItem.Click += new System.EventHandler(this.truckInToolStripMenuItem_Click);
            // 
            // truckOutToolStripMenuItem
            // 
            this.truckOutToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.nav_down_blue;
            this.truckOutToolStripMenuItem.Name = "truckOutToolStripMenuItem";
            this.truckOutToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.truckOutToolStripMenuItem.Text = "Truck(Out)";
            this.truckOutToolStripMenuItem.Click += new System.EventHandler(this.truckOutToolStripMenuItem_Click);
            // 
            // inCheckToolStripMenuItem
            // 
            this.inCheckToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.document;
            this.inCheckToolStripMenuItem.Name = "inCheckToolStripMenuItem";
            this.inCheckToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.inCheckToolStripMenuItem.Text = "In Check";
            this.inCheckToolStripMenuItem.Click += new System.EventHandler(this.inCheckToolStripMenuItem_Click);
            // 
            // outCheckToolStripMenuItem
            // 
            this.outCheckToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.document;
            this.outCheckToolStripMenuItem.Name = "outCheckToolStripMenuItem";
            this.outCheckToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.outCheckToolStripMenuItem.Text = "Out Check";
            this.outCheckToolStripMenuItem.Click += new System.EventHandler(this.outCheckToolStripMenuItem_Click);
            // 
            // truckStatusToolStripMenuItem
            // 
            this.truckStatusToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.document;
            this.truckStatusToolStripMenuItem.Name = "truckStatusToolStripMenuItem";
            this.truckStatusToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.truckStatusToolStripMenuItem.Text = "Truck Status";
            this.truckStatusToolStripMenuItem.Click += new System.EventHandler(this.truckStatusToolStripMenuItem_Click);
            // 
            // dailyInToolStripMenuItem
            // 
            this.dailyInToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.document;
            this.dailyInToolStripMenuItem.Name = "dailyInToolStripMenuItem";
            this.dailyInToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.dailyInToolStripMenuItem.Text = "Daily In";
            this.dailyInToolStripMenuItem.Click += new System.EventHandler(this.dailyInToolStripMenuItem_Click);
            // 
            // dailyOutToolStripMenuItem
            // 
            this.dailyOutToolStripMenuItem.Image = global::TMS_Gate.Properties.Resources.document;
            this.dailyOutToolStripMenuItem.Name = "dailyOutToolStripMenuItem";
            this.dailyOutToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.dailyOutToolStripMenuItem.Text = "Daily Out";
            this.dailyOutToolStripMenuItem.Click += new System.EventHandler(this.dailyOutToolStripMenuItem_Click);
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // laborToolStripMenuItem
            // 
            this.laborToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborToolStripMenuItem.Name = "laborToolStripMenuItem";
            this.laborToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.laborToolStripMenuItem.Text = "Labor";
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.toolStrip1);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 36);
            this.panelTool.Margin = new System.Windows.Forms.Padding(4);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(1318, 51);
            this.panelTool.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnQ,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1318, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnQ
            // 
            this.toolBtnQ.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnQ.Image = global::TMS_Gate.Properties.Resources.delete;
            this.toolBtnQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnQ.Name = "toolBtnQ";
            this.toolBtnQ.Size = new System.Drawing.Size(53, 49);
            this.toolBtnQ.Text = "Quit";
            this.toolBtnQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnQ.Click += new System.EventHandler(this.toolBtnQ_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = global::TMS_Gate.Properties.Resources.document_edit;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(165, 49);
            this.toolStripButton4.Text = "Change Password";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = global::TMS_Gate.Properties.Resources.check;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(158, 49);
            this.toolStripButton5.Text = "Check Ip Camera";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnTruckIn,
            this.toolBtnTruckOut,
            this.toolStripSeparator1,
            this.toolBtnInCheck,
            this.toolBtnOutCheck,
            this.toolStripSeparator2,
            this.toolBtnTruckStatus,
            this.toolStripSeparator3,
            this.toolBtnDailyIn,
            this.toolDailyOut});
            this.toolStrip3.Location = new System.Drawing.Point(0, 118);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1790, 65);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.Visible = false;
            // 
            // toolBtnTruckIn
            // 
            this.toolBtnTruckIn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnTruckIn.Image = global::TMS_Gate.Properties.Resources.nav_up_blue;
            this.toolBtnTruckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnTruckIn.Name = "toolBtnTruckIn";
            this.toolBtnTruckIn.Size = new System.Drawing.Size(85, 62);
            this.toolBtnTruckIn.Text = "Truck In";
            this.toolBtnTruckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnTruckIn.Click += new System.EventHandler(this.toolBtnTruckIn_Click);
            // 
            // toolBtnTruckOut
            // 
            this.toolBtnTruckOut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnTruckOut.Image = global::TMS_Gate.Properties.Resources.nav_down_blue;
            this.toolBtnTruckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnTruckOut.Name = "toolBtnTruckOut";
            this.toolBtnTruckOut.Size = new System.Drawing.Size(100, 62);
            this.toolBtnTruckOut.Text = "Truck Out";
            this.toolBtnTruckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnTruckOut.Click += new System.EventHandler(this.toolBtnTruckOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 65);
            // 
            // toolBtnInCheck
            // 
            this.toolBtnInCheck.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnInCheck.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolBtnInCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnInCheck.Name = "toolBtnInCheck";
            this.toolBtnInCheck.Size = new System.Drawing.Size(89, 62);
            this.toolBtnInCheck.Text = "In Check";
            this.toolBtnInCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnInCheck.Click += new System.EventHandler(this.toolBtnInCheck_Click);
            // 
            // toolBtnOutCheck
            // 
            this.toolBtnOutCheck.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnOutCheck.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolBtnOutCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOutCheck.Name = "toolBtnOutCheck";
            this.toolBtnOutCheck.Size = new System.Drawing.Size(104, 62);
            this.toolBtnOutCheck.Text = "Out Check";
            this.toolBtnOutCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnOutCheck.Click += new System.EventHandler(this.toolBtnOutCheck_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 65);
            // 
            // toolBtnTruckStatus
            // 
            this.toolBtnTruckStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnTruckStatus.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolBtnTruckStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnTruckStatus.Name = "toolBtnTruckStatus";
            this.toolBtnTruckStatus.Size = new System.Drawing.Size(121, 62);
            this.toolBtnTruckStatus.Text = "Truck Status";
            this.toolBtnTruckStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnTruckStatus.Click += new System.EventHandler(this.toolBtnTruckStatus_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 65);
            // 
            // toolBtnDailyIn
            // 
            this.toolBtnDailyIn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnDailyIn.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolBtnDailyIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDailyIn.Name = "toolBtnDailyIn";
            this.toolBtnDailyIn.Size = new System.Drawing.Size(81, 62);
            this.toolBtnDailyIn.Text = "Daily In";
            this.toolBtnDailyIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnDailyIn.Click += new System.EventHandler(this.toolBtnDailyIn_Click);
            // 
            // toolDailyOut
            // 
            this.toolDailyOut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDailyOut.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolDailyOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDailyOut.Name = "toolDailyOut";
            this.toolDailyOut.Size = new System.Drawing.Size(96, 62);
            this.toolDailyOut.Text = "Daily Out";
            this.toolDailyOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolDailyOut.Click += new System.EventHandler(this.toolDailyOut_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.pictureHome);
            this.panelMain.Location = new System.Drawing.Point(0, 93);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1318, 957);
            this.panelMain.TabIndex = 3;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureHome.Image = global::TMS_Gate.Properties.Resources.rglhome;
            this.pictureHome.Location = new System.Drawing.Point(34, 26);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(1259, 796);
            this.pictureHome.TabIndex = 0;
            this.pictureHome.TabStop = false;
            // 
            // FrmMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 1055);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain1";
            this.Text = "RGL Terminal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkIpCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laborToolStripMenuItem;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnQ;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolBtnTruckIn;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolBtnTruckOut;
        private System.Windows.Forms.ToolStripButton toolBtnInCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnOutCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnTruckStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolBtnDailyIn;
        private System.Windows.Forms.ToolStripButton toolDailyOut;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.PictureBox pictureHome;
    }
}