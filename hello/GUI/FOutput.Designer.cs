namespace hello.GUI
{
    partial class FOutput
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 43);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "KET QUA";
            // 
            // txtKq
            // 
            this.txtKq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKq.Location = new System.Drawing.Point(229, 166);
            this.txtKq.Name = "txtKq";
            this.txtKq.Padding = new System.Windows.Forms.Padding(1);
            this.txtKq.Size = new System.Drawing.Size(344, 146);
            this.txtKq.TabIndex = 1;
            this.txtKq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label1);
            this.Name = "FOutput";
            this.Text = "FOutput";
            this.Load += new System.EventHandler(this.FOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label txtKq;
    }
}