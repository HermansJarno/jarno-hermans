using System.Collections.Generic;
using System.Drawing;

namespace Yatzhee3
{
    partial class Yahtzee
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
            this.GroteWerpKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroteWerpKnop
            // 
            this.GroteWerpKnop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroteWerpKnop.Location = new System.Drawing.Point(33, 265);
            this.GroteWerpKnop.Name = "GroteWerpKnop";
            this.GroteWerpKnop.Size = new System.Drawing.Size(220, 59);
            this.GroteWerpKnop.TabIndex = 0;
            this.GroteWerpKnop.Text = "Werp";
            this.GroteWerpKnop.UseVisualStyleBackColor = true;
            this.GroteWerpKnop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 346);
            this.Controls.Add(this.GroteWerpKnop);
            this.Name = "Yahtzee";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Yahtzee_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button GroteWerpKnop;
    }
}

