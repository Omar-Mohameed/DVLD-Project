namespace DVLD_PresentationLayer.Login
{
    partial class frmLogin
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
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 193);
            label1.Name = "label1";
            label1.Size = new Size(147, 55);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(588, 161);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(264, 31);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(443, 158);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(503, 35);
            label3.Name = "label3";
            label3.Size = new Size(274, 32);
            label3.TabIndex = 3;
            label3.Text = "Login To Your Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(443, 257);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 5;
            label4.Text = "PassWord";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(588, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(264, 31);
            txtPassword.TabIndex = 4;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Checked = true;
            chkRememberMe.CheckState = CheckState.Checked;
            chkRememberMe.Font = new Font("Segoe UI", 9F);
            chkRememberMe.Location = new Point(503, 318);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(154, 29);
            chkRememberMe.TabIndex = 6;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(680, 322);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 7;
            label5.Text = "Forget Pass?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(784, 322);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Reset";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(533, 386);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(274, 50);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 475);
            Controls.Add(btnLogin);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(chkRememberMe);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private CheckBox chkRememberMe;
        private Label label5;
        private LinkLabel linkLabel1;
        private Button btnLogin;
    }
}