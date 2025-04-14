namespace DVLD_PresentationLayer.User
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new People.Controls.ctrlPersonCard();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblUserID = new Label();
            lblUserName = new Label();
            label4 = new Label();
            lblIsActive = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(4, 5);
            ctrlPersonCard1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(832, 307);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 60);
            label1.Name = "label1";
            label1.Size = new Size(114, 29);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(172, 60);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(52, 29);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "???";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(412, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(52, 29);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 60);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 2;
            label4.Text = "User Name :";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(725, 60);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(52, 29);
            lblIsActive.TabIndex = 5;
            lblIsActive.Text = "???";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(605, 60);
            label6.Name = "label6";
            label6.Size = new Size(124, 29);
            label6.TabIndex = 4;
            label6.Text = "Is Active :";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrlUserCard";
            Size = new Size(833, 464);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblUserName;
        private Label label4;
        private Label lblUserID;
        private Label lblIsActive;
        private Label label6;
    }
}
