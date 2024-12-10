using TMS_Gate.Model;

namespace TMS_Gate.Forms
{
    partial class CtlTruckInWBQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInWb = new System.Windows.Forms.Label();
            this.lblOutWb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight Bridge Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "In Weight Bridge ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Out Weight Bridge ID :";
            // 
            // lblInWb
            // 
            this.lblInWb.AutoSize = true;
            this.lblInWb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInWb.Location = new System.Drawing.Point(269, 90);
            this.lblInWb.Name = "lblInWb";
            this.lblInWb.Size = new System.Drawing.Size(59, 20);
            this.lblInWb.TabIndex = 3;
            this.lblInWb.Text = "label4";
            // 
            // lblOutWb
            // 
            this.lblOutWb.AutoSize = true;
            this.lblOutWb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutWb.Location = new System.Drawing.Point(269, 166);
            this.lblOutWb.Name = "lblOutWb";
            this.lblOutWb.Size = new System.Drawing.Size(59, 20);
            this.lblOutWb.TabIndex = 4;
            this.lblOutWb.Text = "label4";
            // 
            // CtlTruckInWBQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOutWb);
            this.Controls.Add(this.lblInWb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CtlTruckInWBQ";
            this.Size = new System.Drawing.Size(496, 1332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void FillData(ICD_InBoundCheck inData)
        {
            lblInWb.Text = inData.InWeightBridgeID;
            lblOutWb.Text = inData.OutWeightBridgeID;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInWb;
        private System.Windows.Forms.Label lblOutWb;
    }
}
