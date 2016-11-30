namespace CS357Project
{
    partial class Form1
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
            this.labStates = new System.Windows.Forms.Label();
            this.labAlfa = new System.Windows.Forms.Label();
            this.tbStates = new System.Windows.Forms.TextBox();
            this.tbAlfa = new System.Windows.Forms.TextBox();
            this.butNextStage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labStates
            // 
            this.labStates.AutoSize = true;
            this.labStates.Location = new System.Drawing.Point(28, 43);
            this.labStates.Name = "labStates";
            this.labStates.Size = new System.Drawing.Size(401, 17);
            this.labStates.TabIndex = 0;
            this.labStates.Text = "Enter the set of states, with each state separated by a comma.";
            // 
            // labAlfa
            // 
            this.labAlfa.AutoSize = true;
            this.labAlfa.Location = new System.Drawing.Point(28, 88);
            this.labAlfa.Name = "labAlfa";
            this.labAlfa.Size = new System.Drawing.Size(484, 17);
            this.labAlfa.TabIndex = 1;
            this.labAlfa.Text = "Enter the alphabet for the NFA, with each character separated by a comma.";
            // 
            // tbStates
            // 
            this.tbStates.Location = new System.Drawing.Point(31, 63);
            this.tbStates.Name = "tbStates";
            this.tbStates.Size = new System.Drawing.Size(481, 22);
            this.tbStates.TabIndex = 4;
            // 
            // tbAlfa
            // 
            this.tbAlfa.Location = new System.Drawing.Point(31, 109);
            this.tbAlfa.Name = "tbAlfa";
            this.tbAlfa.Size = new System.Drawing.Size(481, 22);
            this.tbAlfa.TabIndex = 5;
            // 
            // butNextStage
            // 
            this.butNextStage.Location = new System.Drawing.Point(31, 161);
            this.butNextStage.Name = "butNextStage";
            this.butNextStage.Size = new System.Drawing.Size(481, 79);
            this.butNextStage.TabIndex = 8;
            this.butNextStage.Text = "Make Start and End states";
            this.butNextStage.UseVisualStyleBackColor = true;
            this.butNextStage.Click += new System.EventHandler(this.butNextStage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 333);
            this.Controls.Add(this.butNextStage);
            this.Controls.Add(this.tbAlfa);
            this.Controls.Add(this.tbStates);
            this.Controls.Add(this.labAlfa);
            this.Controls.Add(this.labStates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStates;
        private System.Windows.Forms.Label labAlfa;
        private System.Windows.Forms.TextBox tbStates;
        private System.Windows.Forms.TextBox tbAlfa;
        private System.Windows.Forms.Button butNextStage;
    }
}

