namespace DVLD_PresentationLayer.Tests
{
    partial class frmListTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestTypes));
            lblRecordsCount = new Label();
            dgvTestTypes = new DataGridView();
            label3 = new Label();
            btnclose = new Button();
            label1 = new Label();
            pbpersonimage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).BeginInit();
            SuspendLayout();
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(98, 641);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(41, 38);
            lblRecordsCount.TabIndex = 42;
            lblRecordsCount.Text = "??";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToResizeRows = false;
            dgvTestTypes.BackgroundColor = Color.White;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTestTypes.GridColor = SystemColors.ControlDark;
            dgvTestTypes.Location = new Point(2, 261);
            dgvTestTypes.Margin = new Padding(4, 5, 4, 5);
            dgvTestTypes.MultiSelect = false;
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dgvTestTypes.RowHeadersWidth = 62;
            dgvTestTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestTypes.Size = new Size(895, 371);
            dgvTestTypes.TabIndex = 41;
            dgvTestTypes.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 641);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 40;
            label3.Text = "Total ";
            // 
            // btnclose
            // 
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(742, 641);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(138, 46);
            btnclose.TabIndex = 39;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(269, 186);
            label1.Name = "label1";
            label1.Size = new Size(335, 40);
            label1.TabIndex = 38;
            label1.Text = "Manage Test Types";
            // 
            // pbpersonimage
            // 
            pbpersonimage.Image = (Image)resources.GetObject("pbpersonimage.Image");
            pbpersonimage.Location = new Point(342, 12);
            pbpersonimage.Name = "pbpersonimage";
            pbpersonimage.Size = new Size(193, 160);
            pbpersonimage.SizeMode = PictureBoxSizeMode.Zoom;
            pbpersonimage.TabIndex = 37;
            pbpersonimage.TabStop = false;
            // 
            // frmListTestTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnclose;
            ClientSize = new Size(900, 693);
            Controls.Add(lblRecordsCount);
            Controls.Add(dgvTestTypes);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(label1);
            Controls.Add(pbpersonimage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmListTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListTestTypes";
            Load += frmListTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecordsCount;
        private DataGridView dgvTestTypes;
        private Label label3;
        private Button btnclose;
        private Label label1;
        private PictureBox pbpersonimage;
    }
}