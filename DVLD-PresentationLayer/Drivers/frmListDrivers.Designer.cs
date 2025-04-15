namespace DVLD_PresentationLayer.Drivers
{
    partial class frmListDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDrivers));
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvDrivers = new DataGridView();
            label3 = new Label();
            btnclose = new Button();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pbpersonimage = new PictureBox();
            lblRecordCount = new Label();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).BeginInit();
            SuspendLayout();
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(325, 40);
            sendEmailToolStripMenuItem.Text = "Show Person License History";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(322, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(325, 40);
            addNewPersonToolStripMenuItem.Text = "Issue International License";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(322, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(325, 40);
            showDetailsToolStripMenuItem.Text = "&Show Person Info";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, addNewPersonToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStripPeople";
            contextMenuStrip1.Size = new Size(326, 136);
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AllowUserToResizeRows = false;
            dgvDrivers.BackgroundColor = Color.White;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.ContextMenuStrip = contextMenuStrip1;
            dgvDrivers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDrivers.GridColor = SystemColors.ControlDark;
            dgvDrivers.Location = new Point(27, 335);
            dgvDrivers.Margin = new Padding(4, 5, 4, 5);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowHeadersWidth = 62;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(895, 371);
            dgvDrivers.TabIndex = 31;
            dgvDrivers.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 715);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 29;
            label3.Text = "Total ";
            // 
            // btnclose
            // 
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(767, 715);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(138, 46);
            btnclose.TabIndex = 28;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Font = new Font("Segoe UI", 12F);
            txtFilterValue.Location = new Point(366, 272);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(185, 39);
            txtFilterValue.TabIndex = 26;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.Font = new Font("Segoe UI", 12F);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cbFilterBy.Location = new Point(159, 270);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(185, 40);
            cbFilterBy.TabIndex = 25;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 268);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 24;
            label2.Text = "Filter By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(326, 202);
            label1.Name = "label1";
            label1.Size = new Size(271, 40);
            label1.TabIndex = 23;
            label1.Text = "Manage Drivers";
            // 
            // pbpersonimage
            // 
            pbpersonimage.Image = (Image)resources.GetObject("pbpersonimage.Image");
            pbpersonimage.Location = new Point(358, 27);
            pbpersonimage.Name = "pbpersonimage";
            pbpersonimage.Size = new Size(193, 160);
            pbpersonimage.SizeMode = PictureBoxSizeMode.Zoom;
            pbpersonimage.TabIndex = 22;
            pbpersonimage.TabStop = false;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordCount.Location = new Point(123, 715);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(41, 38);
            lblRecordCount.TabIndex = 32;
            lblRecordCount.Text = "??";
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnclose;
            ClientSize = new Size(948, 775);
            Controls.Add(lblRecordCount);
            Controls.Add(dgvDrivers);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbpersonimage);
            Name = "frmListDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListDrivers";
            Load += frmListDrivers_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvDrivers;
        private Label label3;
        private Button btnclose;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label2;
        private Label label1;
        private PictureBox pbpersonimage;
        private Label lblRecordCount;
    }
}