namespace Yatzhee3
{
    partial class TeerlingView
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
            this.TeerlingLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TeerlingLabel
            // 
            this.TeerlingLabel.BackColor = System.Drawing.Color.White;
            this.TeerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeerlingLabel.Location = new System.Drawing.Point(19, 18);
            this.TeerlingLabel.Name = "TeerlingLabel";
            this.TeerlingLabel.Size = new System.Drawing.Size(201, 115);
            this.TeerlingLabel.TabIndex = 0;
            this.TeerlingLabel.Text = "label1";
            this.TeerlingLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TeerlingLabel);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(281, 168);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TeerlingLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
