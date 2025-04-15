namespace DVLD_PresentationLayer.User
{
    partial class frmChangePassword
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
            components = new System.ComponentModel.Container();
            ctrlUserCard1 = new ctrlUserCard();
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlUserCard1.Location = new Point(4, 3);
            ctrlUserCard1.Margin = new Padding(4, 3, 4, 3);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(833, 461);
            ctrlUserCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 492);
            label1.Name = "label1";
            label1.Size = new Size(235, 29);
            label1.TabIndex = 1;
            label1.Text = "Current Password :";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(325, 492);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(213, 31);
            txtCurrentPassword.TabIndex = 2;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(325, 550);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(213, 31);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 550);
            label2.Name = "label2";
            label2.Size = new Size(202, 29);
            label2.TabIndex = 3;
            label2.Text = "New Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(325, 608);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(213, 31);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 608);
            label3.Name = "label3";
            label3.Size = new Size(240, 29);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(603, 492);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightCoral;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(603, 566);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(209, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CancelButton = btnClose;
            ClientSize = new Size(839, 656);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label1);
            Controls.Add(ctrlUserCard1);
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private Label label1;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private Label label2;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Button btnSave;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}