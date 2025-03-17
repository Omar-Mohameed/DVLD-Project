namespace DVLD_PresentationLayer.People
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            lbltitle = new Label();
            groupBox1 = new GroupBox();
            lbremoveimage = new LinkLabel();
            lbsetimage = new LinkLabel();
            pbpersonimage = new PictureBox();
            cbcountry = new ComboBox();
            txtphone = new TextBox();
            dtpdateofbirth = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtaddress = new TextBox();
            txtemail = new TextBox();
            rbfemale = new RadioButton();
            rbmale = new RadioButton();
            txtnationalno = new TextBox();
            txtlastname = new TextBox();
            txtthirdname = new TextBox();
            txtsecondname = new TextBox();
            txtfirstname = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnsave = new Button();
            btnclose = new Button();
            label2 = new Label();
            lblpersonid = new Label();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Red;
            lbltitle.Location = new Point(265, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(400, 55);
            lbltitle.TabIndex = 2;
            lbltitle.Text = "Add New Person";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbremoveimage);
            groupBox1.Controls.Add(lbsetimage);
            groupBox1.Controls.Add(pbpersonimage);
            groupBox1.Controls.Add(cbcountry);
            groupBox1.Controls.Add(txtphone);
            groupBox1.Controls.Add(dtpdateofbirth);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(rbfemale);
            groupBox1.Controls.Add(rbmale);
            groupBox1.Controls.Add(txtnationalno);
            groupBox1.Controls.Add(txtlastname);
            groupBox1.Controls.Add(txtthirdname);
            groupBox1.Controls.Add(txtsecondname);
            groupBox1.Controls.Add(txtfirstname);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnsave);
            groupBox1.Controls.Add(btnclose);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 355);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lbremoveimage
            // 
            lbremoveimage.AutoSize = true;
            lbremoveimage.Location = new Point(840, 250);
            lbremoveimage.Name = "lbremoveimage";
            lbremoveimage.Size = new Size(103, 29);
            lbremoveimage.TabIndex = 13;
            lbremoveimage.TabStop = true;
            lbremoveimage.Text = "Remove";
            lbremoveimage.LinkClicked += lbremoveimage_LinkClicked;
            // 
            // lbsetimage
            // 
            lbsetimage.AutoSize = true;
            lbsetimage.Location = new Point(695, 250);
            lbsetimage.Name = "lbsetimage";
            lbsetimage.Size = new Size(122, 29);
            lbsetimage.TabIndex = 12;
            lbsetimage.TabStop = true;
            lbsetimage.Text = "Set Image";
            lbsetimage.LinkClicked += lbsetimage_LinkClicked;
            // 
            // pbpersonimage
            // 
            pbpersonimage.Image = Properties.Resources.Female_512;
            pbpersonimage.Location = new Point(749, 107);
            pbpersonimage.Name = "pbpersonimage";
            pbpersonimage.Size = new Size(150, 121);
            pbpersonimage.SizeMode = PictureBoxSizeMode.Zoom;
            pbpersonimage.TabIndex = 29;
            pbpersonimage.TabStop = false;
            // 
            // cbcountry
            // 
            cbcountry.FormattingEnabled = true;
            cbcountry.Location = new Point(518, 212);
            cbcountry.Name = "cbcountry";
            cbcountry.Size = new Size(182, 37);
            cbcountry.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(518, 159);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(150, 35);
            txtphone.TabIndex = 8;
            txtphone.Validating += ValidateEmptyTextBox;
            // 
            // dtpdateofbirth
            // 
            dtpdateofbirth.CustomFormat = "dd/M/yyyy";
            dtpdateofbirth.Format = DateTimePickerFormat.Custom;
            dtpdateofbirth.Location = new Point(518, 113);
            dtpdateofbirth.Name = "dtpdateofbirth";
            dtpdateofbirth.Size = new Size(187, 35);
            dtpdateofbirth.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(403, 214);
            label14.Name = "label14";
            label14.Size = new Size(109, 29);
            label14.TabIndex = 25;
            label14.Text = "Country:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(417, 165);
            label13.Name = "label13";
            label13.Size = new Size(95, 29);
            label13.TabIndex = 24;
            label13.Text = "Phone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(363, 113);
            label12.Name = "label12";
            label12.Size = new Size(155, 29);
            label12.TabIndex = 23;
            label12.Text = "DateOfBirth:";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(179, 275);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(314, 67);
            txtaddress.TabIndex = 11;
            txtaddress.Validating += ValidateEmptyTextBox;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(179, 211);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(188, 35);
            txtemail.TabIndex = 9;
            txtemail.Validating += txtemail_Validating;
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Location = new Point(276, 163);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(120, 33);
            rbfemale.TabIndex = 7;
            rbfemale.Text = "Female";
            rbfemale.UseVisualStyleBackColor = true;
            rbfemale.Click += rbFemale_Click;
            // 
            // rbmale
            // 
            rbmale.AutoSize = true;
            rbmale.Checked = true;
            rbmale.Location = new Point(179, 163);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(91, 33);
            rbmale.TabIndex = 6;
            rbmale.TabStop = true;
            rbmale.Text = "Male";
            rbmale.UseVisualStyleBackColor = true;
            rbmale.Click += rbMale_Click;
            // 
            // txtnationalno
            // 
            txtnationalno.Location = new Point(179, 107);
            txtnationalno.Name = "txtnationalno";
            txtnationalno.Size = new Size(175, 35);
            txtnationalno.TabIndex = 4;
            txtnationalno.Validating += txtnationalno_Validating;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(779, 54);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(150, 35);
            txtlastname.TabIndex = 3;
            txtlastname.Validating += ValidateEmptyTextBox;
            // 
            // txtthirdname
            // 
            txtthirdname.Location = new Point(583, 51);
            txtthirdname.Name = "txtthirdname";
            txtthirdname.Size = new Size(150, 35);
            txtthirdname.TabIndex = 2;
            // 
            // txtsecondname
            // 
            txtsecondname.Location = new Point(383, 48);
            txtsecondname.Name = "txtsecondname";
            txtsecondname.Size = new Size(150, 35);
            txtsecondname.TabIndex = 1;
            txtsecondname.Validating += ValidateEmptyTextBox;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(179, 51);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(150, 35);
            txtfirstname.TabIndex = 0;
            txtfirstname.Validating += ValidateEmptyTextBox;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(822, 15);
            label11.Name = "label11";
            label11.Size = new Size(57, 29);
            label11.TabIndex = 13;
            label11.Text = "Last";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(613, 15);
            label10.Name = "label10";
            label10.Size = new Size(70, 29);
            label10.TabIndex = 12;
            label10.Text = "Third";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 15);
            label9.Name = "label9";
            label9.Size = new Size(96, 29);
            label9.TabIndex = 11;
            label9.Text = "Second";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 15);
            label8.Name = "label8";
            label8.Size = new Size(60, 29);
            label8.TabIndex = 10;
            label8.Text = "First";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 214);
            label7.Name = "label7";
            label7.Size = new Size(86, 29);
            label7.TabIndex = 9;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 278);
            label6.Name = "label6";
            label6.Size = new Size(116, 29);
            label6.TabIndex = 8;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 163);
            label5.Name = "label5";
            label5.Size = new Size(107, 29);
            label5.TabIndex = 7;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 107);
            label4.Name = "label4";
            label4.Size = new Size(158, 29);
            label4.TabIndex = 6;
            label4.Text = "National No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 54);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.ImageAlign = ContentAlignment.MiddleLeft;
            btnsave.Location = new Point(720, 296);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(138, 46);
            btnsave.TabIndex = 15;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnclose
            // 
            btnclose.Image = Properties.Resources.Close_32;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(545, 296);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(138, 46);
            btnclose.TabIndex = 14;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(135, 29);
            label2.TabIndex = 4;
            label2.Text = "Person ID:";
            // 
            // lblpersonid
            // 
            lblpersonid.AutoSize = true;
            lblpersonid.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpersonid.Location = new Point(169, 81);
            lblpersonid.Name = "lblpersonid";
            lblpersonid.Size = new Size(27, 29);
            lblpersonid.TabIndex = 5;
            lblpersonid.Text = "0";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AcceptButton = btnsave;
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            CancelButton = btnclose;
            ClientSize = new Size(967, 467);
            Controls.Add(lblpersonid);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lbltitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddUpdatePerson";
            Load += frmAddUpdatePerson_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbpersonimage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbltitle;
        private GroupBox groupBox1;
        private Button btnsave;
        private Button btnclose;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtthirdname;
        private TextBox txtsecondname;
        private TextBox txtfirstname;
        private TextBox txtnationalno;
        private TextBox txtlastname;
        private RadioButton rbfemale;
        private RadioButton rbmale;
        private TextBox txtaddress;
        private TextBox txtemail;
        private Label label14;
        private Label label13;
        private Label label12;
        private DateTimePicker dtpdateofbirth;
        private ComboBox cbcountry;
        private TextBox txtphone;
        private PictureBox pbpersonimage;
        private LinkLabel lbremoveimage;
        private LinkLabel lbsetimage;
        private Label lblpersonid;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}