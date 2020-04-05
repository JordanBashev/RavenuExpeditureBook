namespace WindowsFormsApp1.View
{
    partial class Information
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Englishbutton = new System.Windows.Forms.Button();
            this.Bulgarian = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.Bulgarian);
            this.groupBox1.Controls.Add(this.Englishbutton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // Englishbutton
            // 
            this.Englishbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Englishbutton.Location = new System.Drawing.Point(6, 19);
            this.Englishbutton.Name = "Englishbutton";
            this.Englishbutton.Size = new System.Drawing.Size(188, 23);
            this.Englishbutton.TabIndex = 0;
            this.Englishbutton.Text = "English";
            this.Englishbutton.UseVisualStyleBackColor = true;
            this.Englishbutton.UseWaitCursor = true;
            this.Englishbutton.Click += new System.EventHandler(this.Englishbutton_Click);
            // 
            // Bulgarian
            // 
            this.Bulgarian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bulgarian.Location = new System.Drawing.Point(6, 48);
            this.Bulgarian.Name = "Bulgarian";
            this.Bulgarian.Size = new System.Drawing.Size(188, 23);
            this.Bulgarian.TabIndex = 1;
            this.Bulgarian.Text = "Български";
            this.Bulgarian.UseVisualStyleBackColor = true;
            this.Bulgarian.Click += new System.EventHandler(this.Bulgarian_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(234, 139);
            this.Controls.Add(this.groupBox1);
            this.Name = "Information";
            this.Text = "Information";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bulgarian;
        private System.Windows.Forms.Button Englishbutton;
    }
}