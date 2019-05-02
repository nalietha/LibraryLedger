namespace LibraryManagement.Displays
{
    partial class Login
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHomeLibrary = new System.Windows.Forms.Label();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(175, 156);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(79, 91);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(171, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(79, 130);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(171, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // lblHomeLibrary
            // 
            this.lblHomeLibrary.AutoSize = true;
            this.lblHomeLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeLibrary.Location = new System.Drawing.Point(13, 13);
            this.lblHomeLibrary.Name = "lblHomeLibrary";
            this.lblHomeLibrary.Size = new System.Drawing.Size(140, 25);
            this.lblHomeLibrary.TabIndex = 5;
            this.lblHomeLibrary.Text = "Home Library";
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblForgotPass.Location = new System.Drawing.Point(81, 161);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(88, 13);
            this.lblForgotPass.TabIndex = 6;
            this.lblForgotPass.Text = "forgot password?";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReg.Location = new System.Drawing.Point(81, 189);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(46, 13);
            this.lblReg.TabIndex = 7;
            this.lblReg.Text = "Registar";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 246);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.lblHomeLibrary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnLogIn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHomeLibrary;
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.Label lblReg;
    }
}