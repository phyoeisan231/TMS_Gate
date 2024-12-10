namespace TMS_Gate.Forms
{
    partial class CtlDetailPanel
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
            this.dinpanel1 = new System.Windows.Forms.Panel();
            this.dinpanel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dinpanel1
            // 
            this.dinpanel1.Location = new System.Drawing.Point(17, 3);
            this.dinpanel1.Name = "dinpanel1";
            this.dinpanel1.Size = new System.Drawing.Size(507, 1332);
            this.dinpanel1.TabIndex = 0;
            // 
            // dinpanel2
            // 
            this.dinpanel2.Location = new System.Drawing.Point(559, 3);
            this.dinpanel2.Name = "dinpanel2";
            this.dinpanel2.Size = new System.Drawing.Size(569, 1332);
            this.dinpanel2.TabIndex = 1;
            this.dinpanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.dinpanel2_Paint);
            // 
            // CtlDetailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dinpanel2);
            this.Controls.Add(this.dinpanel1);
            this.Name = "CtlDetailPanel";
            this.Size = new System.Drawing.Size(1151, 1332);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel dinpanel1;
        public System.Windows.Forms.Panel dinpanel2;
    }
}
