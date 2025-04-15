namespace DVLD_PresentationLayer.Applications.Application_Type
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            label1 = new Label();
            pbpersonimage = new PictureBox();
            lblRecordsCount = new Label();
            dgvApplicationTypes = new DataGridView();
            label3 = new Label();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(200, 185);
            label1.Name = "label1";
            label1.Size = new Size(441, 40);
            label1.TabIndex = 25;
            label1.Text = "Manage Application Types";
            // 
            // pbpersonimage
            // 
            pbpersonimage.Image = (Image)resources.GetObject("pbpersonimage.Image");
            pbpersonimage.Location = new Point(336, 12);
            pbpersonimage.Name = "pbpersonimage";
            pbpersonimage.Size = new Size(193, 160);
            pbpersonimage.SizeMode = PictureBoxSizeMode.Zoom;
            pbpersonimage.TabIndex = 24;
            pbpersonimage.TabStop = false;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(109, 655);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(41, 38);
            lblRecordsCount.TabIndex = 36;
            lblRecordsCount.Text = "??";
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToResizeRows = false;
            dgvApplicationTypes.BackgroundColor = Color.White;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvApplicationTypes.GridColor = SystemColors.ControlDark;
            dgvApplicationTypes.Location = new Point(13, 275);
            dgvApplicationTypes.Margin = new Padding(4, 5, 4, 5);
            dgvApplicationTypes.MultiSelect = false;
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dgvApplicationTypes.RowHeadersWidth = 62;
            dgvApplicationTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicationTypes.Size = new Size(895, 371);
            dgvApplicationTypes.TabIndex = 35;
            dgvApplicationTypes.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 655);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 34;
            label3.Text = "Total ";
            // 
            // btnclose
            // 
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(753, 655);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(138, 46);
            btnclose.TabIndex = 33;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // frmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnclose;
            ClientSize = new Size(913, 708);
            Controls.Add(lblRecordsCount);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(label1);
            Controls.Add(pbpersonimage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageApplicationTypes";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbpersonimage;
        private Label lblRecordsCount;
        private DataGridView dgvApplicationTypes;
        private Label label3;
        private Button btnclose;
    }
}