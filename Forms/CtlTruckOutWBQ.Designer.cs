using TMS_Gate.Model;
using TMS_Gate.Models;

namespace TMS_Gate.Forms
{
    partial class CtlTruckOutWBQ
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOutWb = new System.Windows.Forms.Label();
            this.lblInWb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutWb
            // 
            this.lblOutWb.AutoSize = true;
            this.lblOutWb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutWb.Location = new System.Drawing.Point(239, 15);
            this.lblOutWb.Name = "lblOutWb";
            this.lblOutWb.Size = new System.Drawing.Size(59, 20);
            this.lblOutWb.TabIndex = 9;
            this.lblOutWb.Text = "label4";
            // 
            // lblInWb
            // 
            this.lblInWb.AutoSize = true;
            this.lblInWb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInWb.Location = new System.Drawing.Point(296, 111);
            this.lblInWb.Name = "lblInWb";
            this.lblInWb.Size = new System.Drawing.Size(0, 20);
            this.lblInWb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Out Weight Bridge ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Weight Bridge Queue";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOutWb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 740);
            this.panel1.TabIndex = 10;
            // 
            // CtlTruckOutWBQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInWb);
            this.Controls.Add(this.label1);
            this.Name = "CtlTruckOutWBQ";
            this.Size = new System.Drawing.Size(660, 1332);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void FillData(ICD_OutBoundCheck outData)
        {
            lblOutWb.Text = outData.OutWeightBridgeID;
        }
        #endregion

        private System.Windows.Forms.Label lblOutWb;
        private System.Windows.Forms.Label lblInWb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
