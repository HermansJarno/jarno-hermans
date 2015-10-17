namespace Yatzhee3
{
    partial class ScoreboardView
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
            this.ScoreboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreboardLabel
            // 
            this.ScoreboardLabel.Location = new System.Drawing.Point(22, 52);
            this.ScoreboardLabel.Name = "ScoreboardLabel";
            this.ScoreboardLabel.Size = new System.Drawing.Size(254, 44);
            this.ScoreboardLabel.TabIndex = 0;
            this.ScoreboardLabel.Text = "label1";
            this.ScoreboardLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ScoreboardLabel);
            this.Name = "ScoreboardView";
            this.Size = new System.Drawing.Size(337, 128);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ScoreboardLabel;
    }
}
