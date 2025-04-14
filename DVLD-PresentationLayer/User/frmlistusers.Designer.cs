namespace DVLD_PresentationLayer.User
{
    partial class frmlistusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistusers));
            pbpersonimage = new PictureBox();
            label1 = new Label();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            addnewuser = new Button();
            btnclose = new Button();
            lblRecordsCount = new Label();
            label3 = new Label();
            dgvUsers = new DataGridView();
            contextMenuStripPeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStripPeople.SuspendLayout();
            SuspendLayout();
            // 
            // pbpersonimage
            // 
            pbpersonimage.Image = Properties.Resources.Users_2_400;
            pbpersonimage.Location = new Point(342, 12);
            pbpersonimage.Name = "pbpersonimage";
            pbpersonimage.Size = new Size(193, 160);
            pbpersonimage.SizeMode = PictureBoxSizeMode.Zoom;
            pbpersonimage.TabIndex = 0;
            pbpersonimage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(310, 187);
            label1.Name = "label1";
            label1.Size = new Size(251, 40);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Font = new Font("Segoe UI", 12F);
            txtFilterValue.Location = new Point(505, 256);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(133, 39);
            txtFilterValue.TabIndex = 11;
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Segoe UI", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cbFilterBy.Location = new Point(143, 255);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(139, 40);
            cbFilterBy.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 253);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 9;
            label2.Text = "Filter By:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Yes", "No" });
            comboBox1.Location = new Point(321, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 40);
            comboBox1.TabIndex = 12;
            // 
            // addnewuser
            // 
            addnewuser.Image = Properties.Resources.Add_New_User_72;
            addnewuser.Location = new Point(802, 226);
            addnewuser.Name = "addnewuser";
            addnewuser.Size = new Size(87, 70);
            addnewuser.TabIndex = 13;
            addnewuser.UseVisualStyleBackColor = true;
            addnewuser.Click += addnewuser_Click;
            // 
            // btnclose
            // 
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(751, 700);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(138, 46);
            btnclose.TabIndex = 17;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(94, 700);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(29, 38);
            lblRecordsCount.TabIndex = 19;
            lblRecordsCount.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 700);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 18;
            label3.Text = "Total ";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStripPeople;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.GridColor = SystemColors.ControlDark;
            dgvUsers.Location = new Point(11, 320);
            dgvUsers.Margin = new Padding(4, 5, 4, 5);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(895, 371);
            dgvUsers.TabIndex = 20;
            dgvUsers.TabStop = false;
            // 
            // contextMenuStripPeople
            // 
            contextMenuStripPeople.ImageScalingSize = new Size(24, 24);
            contextMenuStripPeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStripPeople.Name = "contextMenuStripPeople";
            contextMenuStripPeople.Size = new Size(215, 256);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(214, 40);
            showDetailsToolStripMenuItem.Text = "&Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(214, 40);
            addNewPersonToolStripMenuItem.Text = "Add &New User";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(214, 40);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(214, 40);
            deleteToolStripMenuItem.Text = "&Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(211, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(214, 40);
            sendEmailToolStripMenuItem.Text = "&Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(214, 40);
            phoneCallToolStripMenuItem.Text = "&Phone Call";
            // 
            // frmlistusers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnclose;
            ClientSize = new Size(897, 760);
            Controls.Add(dgvUsers);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(addnewuser);
            Controls.Add(comboBox1);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbpersonimage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmlistusers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmlistusers";
            Load += frmlistusers_Load;
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStripPeople.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbpersonimage;
        private Label label1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label2;
        private ComboBox comboBox1;
        private Button addnewuser;
        private Button btnclose;
        private Label lblRecordsCount;
        private Label label3;
        private DataGridView dgvUsers;
        private ContextMenuStrip contextMenuStripPeople;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}