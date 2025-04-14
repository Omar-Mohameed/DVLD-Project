namespace DVLD_PresentationLayer.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilters = new GroupBox();
            btnAddNewPerson = new Button();
            btnFind = new Button();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(0, 120);
            ctrlPersonCard1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(825, 305);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(label1);
            gbFilters.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilters.Location = new Point(3, 12);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(822, 100);
            gbFilters.TabIndex = 1;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(621, 44);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(52, 46);
            btnAddNewPerson.TabIndex = 4;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnFind
            // 
            btnFind.Image = Properties.Resources.SearchPerson;
            btnFind.Location = new Point(548, 44);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(52, 46);
            btnFind.TabIndex = 3;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(366, 44);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(150, 39);
            txtFilterValue.TabIndex = 2;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "National No.", "Person ID" });
            cbFilterBy.Location = new Point(145, 44);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(182, 40);
            cbFilterBy.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 0;
            label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilters);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(829, 430);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbFilters;
        private Label label1;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Button btnFind;
        private Button btnAddNewPerson;
        private ErrorProvider errorProvider1;
    }
}
