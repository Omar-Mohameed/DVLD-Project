namespace DVLD_PresentationLayer.User
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            lblTitle = new Label();
            tcUserInfo = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            ctrlPersonCardWithFilter1 = new People.Controls.ctrlPersonCardWithFilter();
            tpLoginInfo = new TabPage();
            chkIsActive = new CheckBox();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnclose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tcUserInfo.SuspendLayout();
            tabPage1.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(289, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Edit App Type";
            // 
            // tcUserInfo
            // 
            tcUserInfo.Controls.Add(tabPage1);
            tcUserInfo.Controls.Add(tpLoginInfo);
            tcUserInfo.Font = new Font("Segoe UI", 12F);
            tcUserInfo.Location = new Point(12, 63);
            tcUserInfo.Name = "tcUserInfo";
            tcUserInfo.SelectedIndex = 0;
            tcUserInfo.Size = new Size(899, 544);
            tcUserInfo.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(ctrlPersonCardWithFilter1);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(891, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(496, 436);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 18;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPersonInfoNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(0, 4);
            ctrlPersonCardWithFilter1.Margin = new Padding(4);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(887, 495);
            ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.Controls.Add(chkIsActive);
            tpLoginInfo.Controls.Add(txtConfirmPassword);
            tpLoginInfo.Controls.Add(label5);
            tpLoginInfo.Controls.Add(txtPassword);
            tpLoginInfo.Controls.Add(label4);
            tpLoginInfo.Controls.Add(txtUserName);
            tpLoginInfo.Controls.Add(label3);
            tpLoginInfo.Controls.Add(lblUserID);
            tpLoginInfo.Controls.Add(label1);
            tpLoginInfo.Location = new Point(4, 41);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(192, 55);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "Login Info";
            tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkIsActive.Location = new Point(315, 402);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(136, 36);
            chkIsActive.TabIndex = 8;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(318, 314);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(150, 35);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(126, 320);
            label5.Name = "label5";
            label5.Size = new Size(175, 29);
            label5.TabIndex = 6;
            label5.Text = "Confirm Pass:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(318, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 35);
            txtPassword.TabIndex = 5;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(126, 243);
            label4.Name = "label4";
            label4.Size = new Size(135, 29);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(318, 161);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(150, 35);
            txtUserName.TabIndex = 3;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 167);
            label3.Name = "label3";
            label3.Size = new Size(151, 29);
            label3.TabIndex = 2;
            label3.Text = "User Name:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblUserID.Location = new Point(318, 97);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(52, 29);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(126, 97);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(702, 619);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 46);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnclose
            // 
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(527, 619);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(138, 46);
            btnclose.TabIndex = 16;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CancelButton = btnclose;
            ClientSize = new Size(904, 677);
            Controls.Add(btnSave);
            Controls.Add(btnclose);
            Controls.Add(tcUserInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateUser";
            Activated += frmAddUpdateUser_Activated;
            Load += frmAddUpdateUser_Load;
            tcUserInfo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private TabControl tcUserInfo;
        private TabPage tabPage1;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private TabPage tpLoginInfo;
        private Button button1;
        private Button btnSave;
        private Button btnclose;
        private Label lblUserID;
        private Label label1;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtConfirmPassword;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private CheckBox chkIsActive;
        private ErrorProvider errorProvider1;
    }
}