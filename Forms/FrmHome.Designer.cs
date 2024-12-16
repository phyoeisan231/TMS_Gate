using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;

namespace TMS_Gate.Forms
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem homeTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem truckTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem visitorTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem labourTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx currentViewToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx messagesToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx layoutToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx peopleToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx windowToolStripEx;

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
            this.components = new System.ComponentModel.Container();
            this.gridBagLayout1 = new Syncfusion.Windows.Forms.Tools.GridBagLayout(this.components);
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.homeTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolbtnquit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnPass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnCamera = new System.Windows.Forms.ToolStripButton();
            this.truckTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolBtnIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnInCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnOutCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnTruckStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnDailyIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnDailyOut = new System.Windows.Forms.ToolStripButton();
            this.visitorTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.labourTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.currentViewToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.messagesToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.layoutToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.peopleToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.windowToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.homeTabItem.Panel.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.truckTabItem.Panel.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.labourTabItem.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(homeTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(truckTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(visitorTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(labourTabItem);
            this.ribbonControlAdv1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAdv1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.truckTabItem;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1701, 159);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ribbonControlAdv1.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            // 
            // homeTabItem
            // 
            this.homeTabItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTabItem.Name = "homeTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.homeTabItem.Panel.Controls.Add(this.toolStripEx1);
            this.homeTabItem.Panel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.homeTabItem.Panel.Name = "ribbonPanel1";
            this.homeTabItem.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 37, 0);
            this.homeTabItem.Panel.ScrollPosition = 0;
            this.homeTabItem.Panel.TabIndex = 2;
            this.homeTabItem.Panel.Text = "File";
            this.homeTabItem.Position = 0;
            this.homeTabItem.Size = new System.Drawing.Size(61, 41);
            this.homeTabItem.Text = "File";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnquit,
            this.toolStripSeparator1,
            this.toolBtnPass,
            this.toolStripSeparator2,
            this.toolBtnCamera});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx1.Size = new System.Drawing.Size(383, 137);
            this.toolStripEx1.TabIndex = 0;
            // 
            // toolbtnquit
            // 
            this.toolbtnquit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbtnquit.Image = global::TMS_Gate.Properties.Resources.delete;
            this.toolbtnquit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnquit.Name = "toolbtnquit";
            this.toolbtnquit.Size = new System.Drawing.Size(49, 115);
            this.toolbtnquit.Text = "Quit";
            this.toolbtnquit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolbtnquit.Click += new System.EventHandler(this.toolbtnquit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 213);
            // 
            // toolBtnPass
            // 
            this.toolBtnPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnPass.Image = global::TMS_Gate.Properties.Resources.document_edit;
            this.toolBtnPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPass.Name = "toolBtnPass";
            this.toolBtnPass.Size = new System.Drawing.Size(154, 115);
            this.toolBtnPass.Text = "Change Password";
            this.toolBtnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 213);
            // 
            // toolBtnCamera
            // 
            this.toolBtnCamera.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnCamera.Image = global::TMS_Gate.Properties.Resources.check;
            this.toolBtnCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCamera.Name = "toolBtnCamera";
            this.toolBtnCamera.Size = new System.Drawing.Size(149, 115);
            this.toolBtnCamera.Text = "Check Ip Camera";
            this.toolBtnCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // truckTabItem
            // 
            this.truckTabItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckTabItem.Name = "truckTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.truckTabItem.Panel.Controls.Add(this.toolStripEx2);
            this.truckTabItem.Panel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.truckTabItem.Panel.Name = "ribbonPanel2";
            this.truckTabItem.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 37, 0);
            this.truckTabItem.Panel.ScrollPosition = 0;
            this.truckTabItem.Panel.TabIndex = 3;
            this.truckTabItem.Panel.Text = "Truck";
            this.truckTabItem.Position = 1;
            this.truckTabItem.Size = new System.Drawing.Size(79, 41);
            this.truckTabItem.Text = "Truck";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnIn,
            this.toolStripSeparator3,
            this.toolBtnOut,
            this.toolStripSeparator4,
            this.toolBtnInCheck,
            this.toolStripSeparator5,
            this.toolBtnOutCheck,
            this.toolStripSeparator6,
            this.toolBtnTruckStatus,
            this.toolStripSeparator7,
            this.toolBtnDailyIn,
            this.toolStripSeparator8,
            this.toolBtnDailyOut});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx2.Size = new System.Drawing.Size(697, 68);
            this.toolStripEx2.TabIndex = 0;
            // 
            // toolBtnIn
            // 
            this.toolBtnIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnIn.Image = global::TMS_Gate.Properties.Resources.nav_up_blue;
            this.toolBtnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnIn.Name = "toolBtnIn";
            this.toolBtnIn.Size = new System.Drawing.Size(85, 46);
            this.toolBtnIn.Text = "Truck(In)";
            this.toolBtnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnIn.Click += new System.EventHandler(this.toolBtnIn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // toolBtnOut
            // 
            this.toolBtnOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnOut.Image = global::TMS_Gate.Properties.Resources.nav_down_blue;
            this.toolBtnOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOut.Name = "toolBtnOut";
            this.toolBtnOut.Size = new System.Drawing.Size(100, 46);
            this.toolBtnOut.Text = "Truck(Out)";
            this.toolBtnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnOut.Click += new System.EventHandler(this.toolBtnOut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 49);
            // 
            // toolBtnInCheck
            // 
            this.toolBtnInCheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnInCheck.Image = global::TMS_Gate.Properties.Resources.document1;
            this.toolBtnInCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnInCheck.Name = "toolBtnInCheck";
            this.toolBtnInCheck.Size = new System.Drawing.Size(82, 46);
            this.toolBtnInCheck.Text = "In Check";
            this.toolBtnInCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnInCheck.Click += new System.EventHandler(this.toolBtnInCheck_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 49);
            // 
            // toolBtnOutCheck
            // 
            this.toolBtnOutCheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnOutCheck.Image = global::TMS_Gate.Properties.Resources.document1;
            this.toolBtnOutCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOutCheck.Name = "toolBtnOutCheck";
            this.toolBtnOutCheck.Size = new System.Drawing.Size(97, 46);
            this.toolBtnOutCheck.Text = "Out Check";
            this.toolBtnOutCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnOutCheck.Click += new System.EventHandler(this.toolBtnOutCheck_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 49);
            // 
            // toolBtnTruckStatus
            // 
            this.toolBtnTruckStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnTruckStatus.Image = global::TMS_Gate.Properties.Resources.document1;
            this.toolBtnTruckStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnTruckStatus.Name = "toolBtnTruckStatus";
            this.toolBtnTruckStatus.Size = new System.Drawing.Size(113, 46);
            this.toolBtnTruckStatus.Text = "Truck Status";
            this.toolBtnTruckStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnTruckStatus.Click += new System.EventHandler(this.toolBtnTruckStatus_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 49);
            // 
            // toolBtnDailyIn
            // 
            this.toolBtnDailyIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnDailyIn.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolBtnDailyIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDailyIn.Name = "toolBtnDailyIn";
            this.toolBtnDailyIn.Size = new System.Drawing.Size(75, 46);
            this.toolBtnDailyIn.Text = "Daily In";
            this.toolBtnDailyIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnDailyIn.Click += new System.EventHandler(this.toolBtnDailyIn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 49);
            // 
            // toolBtnDailyOut
            // 
            this.toolBtnDailyOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBtnDailyOut.Image = global::TMS_Gate.Properties.Resources.document;
            this.toolBtnDailyOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDailyOut.Name = "toolBtnDailyOut";
            this.toolBtnDailyOut.Size = new System.Drawing.Size(90, 46);
            this.toolBtnDailyOut.Text = "Daily Out";
            this.toolBtnDailyOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnDailyOut.Click += new System.EventHandler(this.toolBtnDailyOut_Click);
            // 
            // visitorTabItem
            // 
            this.visitorTabItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorTabItem.Name = "visitorTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel3
            // 
            this.visitorTabItem.Panel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.visitorTabItem.Panel.Name = "ribbonPanel3";
            this.visitorTabItem.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 37, 0);
            this.visitorTabItem.Panel.ScrollPosition = 0;
            this.visitorTabItem.Panel.TabIndex = 4;
            this.visitorTabItem.Panel.Text = "Visitor";
            this.visitorTabItem.Position = 2;
            this.visitorTabItem.Size = new System.Drawing.Size(87, 41);
            this.visitorTabItem.Text = "Visitor";
            // 
            // labourTabItem
            // 
            this.labourTabItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labourTabItem.Name = "labourTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel4
            // 
            this.labourTabItem.Panel.Controls.Add(this.currentViewToolStripEx);
            this.labourTabItem.Panel.Controls.Add(this.messagesToolStripEx);
            this.labourTabItem.Panel.Controls.Add(this.layoutToolStripEx);
            this.labourTabItem.Panel.Controls.Add(this.peopleToolStripEx);
            this.labourTabItem.Panel.Controls.Add(this.windowToolStripEx);
            this.labourTabItem.Panel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labourTabItem.Panel.Name = "ribbonPanel4";
            this.labourTabItem.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 37, 0);
            this.labourTabItem.Panel.ScrollPosition = 0;
            this.labourTabItem.Panel.TabIndex = 5;
            this.labourTabItem.Panel.Text = "Labour";
            this.labourTabItem.Position = 3;
            this.labourTabItem.Size = new System.Drawing.Size(91, 41);
            this.labourTabItem.Text = "Labour";
            // 
            // currentViewToolStripEx
            // 
            this.currentViewToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.currentViewToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewToolStripEx.Image = null;
            this.currentViewToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.currentViewToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.currentViewToolStripEx.Name = "currentViewToolStripEx";
            this.currentViewToolStripEx.Office12Mode = false;
            this.currentViewToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.currentViewToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentViewToolStripEx.Size = new System.Drawing.Size(125, 115);
            this.currentViewToolStripEx.TabIndex = 0;
            this.currentViewToolStripEx.Text = "Current View";
            // 
            // messagesToolStripEx
            // 
            this.messagesToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.messagesToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.messagesToolStripEx.Image = null;
            this.messagesToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.messagesToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.messagesToolStripEx.Name = "messagesToolStripEx";
            this.messagesToolStripEx.Office12Mode = false;
            this.messagesToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.messagesToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messagesToolStripEx.Size = new System.Drawing.Size(125, 115);
            this.messagesToolStripEx.TabIndex = 1;
            this.messagesToolStripEx.Text = "Messages";
            // 
            // layoutToolStripEx
            // 
            this.layoutToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.layoutToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.layoutToolStripEx.Image = null;
            this.layoutToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.layoutToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.layoutToolStripEx.Name = "layoutToolStripEx";
            this.layoutToolStripEx.Office12Mode = false;
            this.layoutToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.layoutToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.layoutToolStripEx.Size = new System.Drawing.Size(125, 115);
            this.layoutToolStripEx.TabIndex = 2;
            this.layoutToolStripEx.Text = "Layout";
            // 
            // peopleToolStripEx
            // 
            this.peopleToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.peopleToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.peopleToolStripEx.Image = null;
            this.peopleToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.peopleToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.peopleToolStripEx.Name = "peopleToolStripEx";
            this.peopleToolStripEx.Office12Mode = false;
            this.peopleToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.peopleToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peopleToolStripEx.Size = new System.Drawing.Size(125, 115);
            this.peopleToolStripEx.TabIndex = 3;
            this.peopleToolStripEx.Text = "People";
            // 
            // windowToolStripEx
            // 
            this.windowToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.windowToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.windowToolStripEx.Image = null;
            this.windowToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.windowToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.windowToolStripEx.Name = "windowToolStripEx";
            this.windowToolStripEx.Office12Mode = false;
            this.windowToolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.windowToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowToolStripEx.Size = new System.Drawing.Size(125, 115);
            this.windowToolStripEx.TabIndex = 4;
            this.windowToolStripEx.Text = "Window";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(3, 161);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1574, 939);
            this.panelMain.TabIndex = 1;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 1102);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmHome";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "    RGL Terminal";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.homeTabItem.Panel.ResumeLayout(false);
            this.homeTabItem.Panel.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.truckTabItem.Panel.ResumeLayout(false);
            this.truckTabItem.Panel.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.labourTabItem.Panel.ResumeLayout(false);
            this.labourTabItem.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GridBagLayout gridBagLayout1;
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private ToolStripEx toolStripEx1;
        private ToolStripButton toolbtnquit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolBtnPass;
        private ToolStripButton toolBtnCamera;
        private ToolStripEx toolStripEx2;
        private ToolStripButton toolBtnIn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolBtnOut;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolBtnInCheck;
        private ToolStripButton toolBtnOutCheck;
        private ToolStripButton toolBtnTruckStatus;
        private ToolStripButton toolBtnDailyIn;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolBtnDailyOut;
        private Panel panelMain;
    }
}