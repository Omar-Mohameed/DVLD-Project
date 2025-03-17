namespace DVLD_PresentationLayer.People
{
    partial class frmShowPeoples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPeoples));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvpeople = new DataGridView();
            contextMenuStripPeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            btnaddnewperson = new Button();
            btnclose = new Button();
            label3 = new Label();
            lblRecordsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvpeople).BeginInit();
            contextMenuStripPeople.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.People_400;
            pictureBox1.Location = new Point(640, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(660, 211);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage People";
            // 
            // dgvpeople
            // 
            dgvpeople.AllowUserToAddRows = false;
            dgvpeople.AllowUserToDeleteRows = false;
            dgvpeople.AllowUserToResizeRows = false;
            dgvpeople.BackgroundColor = Color.White;
            dgvpeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpeople.ContextMenuStrip = contextMenuStripPeople;
            dgvpeople.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvpeople.GridColor = SystemColors.ControlDark;
            dgvpeople.Location = new Point(12, 291);
            dgvpeople.Margin = new Padding(4, 5, 4, 5);
            dgvpeople.MultiSelect = false;
            dgvpeople.Name = "dgvpeople";
            dgvpeople.ReadOnly = true;
            dgvpeople.RowHeadersWidth = 62;
            dgvpeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvpeople.Size = new Size(1484, 371);
            dgvpeople.TabIndex = 1;
            dgvpeople.TabStop = false;
            // 
            // contextMenuStripPeople
            // 
            contextMenuStripPeople.ImageScalingSize = new Size(24, 24);
            contextMenuStripPeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStripPeople.Name = "contextMenuStripPeople";
            contextMenuStripPeople.Size = new Size(233, 256);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(232, 40);
            showDetailsToolStripMenuItem.Text = "&Show Details";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(229, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(232, 40);
            addNewPersonToolStripMenuItem.Text = "Add &New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(232, 40);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(232, 40);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(229, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(232, 40);
            sendEmailToolStripMenuItem.Text = "&Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(232, 40);
            phoneCallToolStripMenuItem.Text = "&Phone Call";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Font = new Font("Segoe UI", 12F);
            txtFilterValue.Location = new Point(318, 213);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(150, 39);
            txtFilterValue.TabIndex = 8;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Segoe UI", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gendor", "Phone", "Email" });
            cbFilterBy.Location = new Point(102, 213);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(182, 40);
            cbFilterBy.TabIndex = 7;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 211);
            label2.Name = "label2";
            label2.Size = new Size(85, 38);
            label2.TabIndex = 6;
            label2.Text = "Filter";
            // 
            // btnaddnewperson
            // 
            btnaddnewperson.Image = Properties.Resources.Add_Person_40;
            btnaddnewperson.Location = new Point(1383, 213);
            btnaddnewperson.Name = "btnaddnewperson";
            btnaddnewperson.Size = new Size(88, 55);
            btnaddnewperson.TabIndex = 0;
            btnaddnewperson.Tag = "1";
            btnaddnewperson.UseVisualStyleBackColor = true;
            btnaddnewperson.Click += btnaddnewperson_Click;
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Segoe UI", 14F);
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(1356, 673);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(140, 40);
            btnclose.TabIndex = 10;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 693);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 11;
            label3.Text = "Total ";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(91, 693);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(29, 38);
            lblRecordsCount.TabIndex = 12;
            lblRecordsCount.Text = "?";
            // 
            // frmShowPeoples
            // 
            AcceptButton = btnaddnewperson;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnclose;
            ClientSize = new Size(1520, 740);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(btnaddnewperson);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(dgvpeople);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowPeoples";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmShowPeople";
            Load += frmShowPeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvpeople).EndInit();
            contextMenuStripPeople.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvpeople;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label2;
        private Button btnaddnewperson;
        private Button btnclose;
        private Label label3;
        private Label lblRecordsCount;
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