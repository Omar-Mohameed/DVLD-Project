namespace DVLD_PresentationLayer.People
{
    partial class frmShowPersonInfo
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
            ctrlPersonCard1 = new Controls.ctrlPersonCard();
            btnclose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 40);
            label1.TabIndex = 0;
            label1.Text = "Person";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(13, 43);
            ctrlPersonCard1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(823, 309);
            ctrlPersonCard1.TabIndex = 1;
            // 
            // btnclose
            // 
            btnclose.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(708, 374);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 2;
            btnclose.Text = "Close";
            btnclose.TextAlign = ContentAlignment.MiddleRight;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 433);
            Controls.Add(btnclose);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowPersonInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmShowPersonInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Controls.ctrlPersonCard ctrlPersonCard1;
        private Button btnclose;
    }
}