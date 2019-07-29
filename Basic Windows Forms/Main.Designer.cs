namespace Basic_Windows_Forms
{
    partial class Main
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
            this.FIrstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameEntry = new System.Windows.Forms.TextBox();
            this.LastNameEntry = new System.Windows.Forms.TextBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIrstNameLabel
            // 
            this.FIrstNameLabel.AutoSize = true;
            this.FIrstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIrstNameLabel.Location = new System.Drawing.Point(32, 94);
            this.FIrstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FIrstNameLabel.Name = "FIrstNameLabel";
            this.FIrstNameLabel.Size = new System.Drawing.Size(96, 20);
            this.FIrstNameLabel.TabIndex = 0;
            this.FIrstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(33, 148);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(95, 20);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // FirstNameEntry
            // 
            this.FirstNameEntry.Location = new System.Drawing.Point(145, 91);
            this.FirstNameEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameEntry.Name = "FirstNameEntry";
            this.FirstNameEntry.Size = new System.Drawing.Size(164, 26);
            this.FirstNameEntry.TabIndex = 2;
            // 
            // LastNameEntry
            // 
            this.LastNameEntry.Location = new System.Drawing.Point(145, 145);
            this.LastNameEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameEntry.Name = "LastNameEntry";
            this.LastNameEntry.Size = new System.Drawing.Size(164, 26);
            this.LastNameEntry.TabIndex = 3;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessButton.Location = new System.Drawing.Point(156, 334);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(124, 35);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "Process..";
            this.ProcessButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 457);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.LastNameEntry);
            this.Controls.Add(this.FirstNameEntry);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FIrstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIrstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameEntry;
        private System.Windows.Forms.TextBox LastNameEntry;
        private System.Windows.Forms.Button ProcessButton;
    }
}

