namespace SoftwareProject2024
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gBoxLogin = new System.Windows.Forms.GroupBox();
            this.lLblLogin = new System.Windows.Forms.LinkLabel();
            this.lLblSignup = new System.Windows.Forms.LinkLabel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lLblDeleteAccount = new System.Windows.Forms.LinkLabel();
            this.btnCustomerData = new System.Windows.Forms.Button();
            this.gBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxLogin
            // 
            this.gBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.gBoxLogin.Controls.Add(this.btnCustomerData);
            this.gBoxLogin.Controls.Add(this.btnSignup);
            this.gBoxLogin.Controls.Add(this.lLblDeleteAccount);
            this.gBoxLogin.Controls.Add(this.lLblLogin);
            this.gBoxLogin.Controls.Add(this.lLblSignup);
            this.gBoxLogin.Controls.Add(this.txtLoginUsername);
            this.gBoxLogin.Controls.Add(this.txtLoginPassword);
            this.gBoxLogin.Controls.Add(this.btnLogin);
            this.gBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxLogin.Location = new System.Drawing.Point(175, 50);
            this.gBoxLogin.Name = "gBoxLogin";
            this.gBoxLogin.Size = new System.Drawing.Size(550, 350);
            this.gBoxLogin.TabIndex = 0;
            this.gBoxLogin.TabStop = false;
            // 
            // lLblLogin
            // 
            this.lLblLogin.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lLblLogin.AutoSize = true;
            this.lLblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLblLogin.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLblLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lLblLogin.Location = new System.Drawing.Point(450, 320);
            this.lLblLogin.Name = "lLblLogin";
            this.lLblLogin.Size = new System.Drawing.Size(60, 18);
            this.lLblLogin.TabIndex = 5;
            this.lLblLogin.TabStop = true;
            this.lLblLogin.Text = "Log In";
            this.lLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblLogin_LinkClicked);
            // 
            // lLblSignup
            // 
            this.lLblSignup.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lLblSignup.AutoSize = true;
            this.lLblSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLblSignup.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLblSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lLblSignup.Location = new System.Drawing.Point(450, 320);
            this.lLblSignup.Name = "lLblSignup";
            this.lLblSignup.Size = new System.Drawing.Size(71, 18);
            this.lLblSignup.TabIndex = 4;
            this.lLblSignup.TabStop = true;
            this.lLblSignup.Text = "Sign Up";
            this.lLblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblSignup_LinkClicked);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(25, 250);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(500, 68);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsername.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtLoginUsername.Location = new System.Drawing.Point(25, 50);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(500, 25);
            this.txtLoginUsername.TabIndex = 3;
            this.txtLoginUsername.Text = "Username";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtLoginPassword.Location = new System.Drawing.Point(25, 100);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(500, 25);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnLogin.Location = new System.Drawing.Point(25, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(500, 68);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lLblDeleteAccount
            // 
            this.lLblDeleteAccount.AutoSize = true;
            this.lLblDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLblDeleteAccount.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLblDeleteAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lLblDeleteAccount.Location = new System.Drawing.Point(25, 320);
            this.lLblDeleteAccount.Name = "lLblDeleteAccount";
            this.lLblDeleteAccount.Size = new System.Drawing.Size(132, 18);
            this.lLblDeleteAccount.TabIndex = 6;
            this.lLblDeleteAccount.TabStop = true;
            this.lLblDeleteAccount.Text = "Delete Account";
            this.lLblDeleteAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblDeleteAccount_LinkClicked);
            // 
            // btnCustomerData
            // 
            this.btnCustomerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnCustomerData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerData.FlatAppearance.BorderSize = 0;
            this.btnCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerData.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerData.Location = new System.Drawing.Point(150, 170);
            this.btnCustomerData.Name = "btnCustomerData";
            this.btnCustomerData.Size = new System.Drawing.Size(250, 68);
            this.btnCustomerData.TabIndex = 18;
            this.btnCustomerData.Text = "Customer Data ";
            this.btnCustomerData.UseVisualStyleBackColor = false;
            this.btnCustomerData.Click += new System.EventHandler(this.btnCustomerData_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.gBoxLogin);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 370);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.gBoxLogin.ResumeLayout(false);
            this.gBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lLblSignup;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.LinkLabel lLblLogin;
        private System.Windows.Forms.LinkLabel lLblDeleteAccount;
        private System.Windows.Forms.Button btnCustomerData;
    }
}