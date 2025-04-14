namespace DVLD_PresentationLayer.User
{
    partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            ctrlUserCard1 = new ctrlUserCard();
            btnclose = new Button();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlUserCard1.Location = new Point(2, 1);
            ctrlUserCard1.Margin = new Padding(4, 3, 4, 3);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(832, 476);
            ctrlUserCard1.TabIndex = 0;
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Segoe UI", 14F);
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(275, 483);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(288, 62);
            btnclose.TabIndex = 11;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 548);
            Controls.Add(btnclose);
            Controls.Add(ctrlUserCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUserInfo";
            Text = "frmUserInfo";
            Load += frmUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private Button btnclose;
    }
}