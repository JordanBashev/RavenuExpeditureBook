namespace WindowsFormsApp1.View
{
    partial class RegisterPart
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
            this.txtPasswordRegisterForm = new System.Windows.Forms.TextBox();
            this.txtUsernameRegisterForm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPasswordRegisterForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Bookstypes = new System.Windows.Forms.ComboBox();
            this.BookType = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordRegisterForm
            // 
            this.txtPasswordRegisterForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPasswordRegisterForm.Location = new System.Drawing.Point(213, 76);
            this.txtPasswordRegisterForm.MaxLength = 16;
            this.txtPasswordRegisterForm.Name = "txtPasswordRegisterForm";
            this.txtPasswordRegisterForm.PasswordChar = '*';
            this.txtPasswordRegisterForm.Size = new System.Drawing.Size(175, 31);
            this.txtPasswordRegisterForm.TabIndex = 10;
            // 
            // txtUsernameRegisterForm
            // 
            this.txtUsernameRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsernameRegisterForm.Location = new System.Drawing.Point(213, 39);
            this.txtUsernameRegisterForm.MaxLength = 20;
            this.txtUsernameRegisterForm.Name = "txtUsernameRegisterForm";
            this.txtUsernameRegisterForm.Size = new System.Drawing.Size(175, 31);
            this.txtUsernameRegisterForm.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // txtConfirmPasswordRegisterForm
            // 
            this.txtConfirmPasswordRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfirmPasswordRegisterForm.Location = new System.Drawing.Point(212, 113);
            this.txtConfirmPasswordRegisterForm.MaxLength = 16;
            this.txtConfirmPasswordRegisterForm.Name = "txtConfirmPasswordRegisterForm";
            this.txtConfirmPasswordRegisterForm.PasswordChar = '*';
            this.txtConfirmPasswordRegisterForm.Size = new System.Drawing.Size(175, 31);
            this.txtConfirmPasswordRegisterForm.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm Password:";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.Location = new System.Drawing.Point(259, 206);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(199, 70);
            this.Register.TabIndex = 13;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Bookstypes
            // 
            this.Bookstypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bookstypes.FormattingEnabled = true;
            this.Bookstypes.Items.AddRange(new object[] {
            "Small Shop",
            "Medium Shop",
            "Lagre Shop"});
            this.Bookstypes.Location = new System.Drawing.Point(212, 150);
            this.Bookstypes.Name = "Bookstypes";
            this.Bookstypes.Size = new System.Drawing.Size(175, 32);
            this.Bookstypes.TabIndex = 14;
            this.Bookstypes.DropDown += new System.EventHandler(this.Message);
            // 
            // BookType
            // 
            this.BookType.AutoSize = true;
            this.BookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookType.Location = new System.Drawing.Point(15, 152);
            this.BookType.Name = "BookType";
            this.BookType.Size = new System.Drawing.Size(191, 25);
            this.BookType.TabIndex = 15;
            this.BookType.Text = "RavenueBook For:";
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return.Location = new System.Drawing.Point(2, 206);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(204, 70);
            this.Return.TabIndex = 16;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // RegisterPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 288);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.BookType);
            this.Controls.Add(this.Bookstypes);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmPasswordRegisterForm);
            this.Controls.Add(this.txtPasswordRegisterForm);
            this.Controls.Add(this.txtUsernameRegisterForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterPart";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordRegisterForm;
        private System.Windows.Forms.TextBox txtUsernameRegisterForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPasswordRegisterForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.ComboBox Bookstypes;
        private System.Windows.Forms.Label BookType;
        private System.Windows.Forms.Button Return;
    }
}