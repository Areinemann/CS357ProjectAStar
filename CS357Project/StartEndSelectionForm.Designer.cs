﻿namespace CS357Project
{
    partial class StartEndSelectionForm
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
            this.labStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labStart
            // 
            this.labStart.AutoSize = true;
            this.labStart.Location = new System.Drawing.Point(13, 13);
            this.labStart.Name = "labStart";
            this.labStart.Size = new System.Drawing.Size(127, 17);
            this.labStart.TabIndex = 0;
            this.labStart.Text = "Choose Start State";
            // 
            // StartEndSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 401);
            this.Controls.Add(this.labStart);
            this.Name = "StartEndSelectionForm";
            this.Text = "StartEndSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStart;
    }
}