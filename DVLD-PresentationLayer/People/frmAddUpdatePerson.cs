using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using DVLD_PresentationLayer.Global_Classes;
using DVLD_PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class frmAddUpdatePerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPeople _Person;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _InitializeForm()
        {
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lbltitle.Text = "Add New Person";
                _Person = new clsPeople();
            }
            else
            {
                lbltitle.Text = "Update Person";
            }
            if (rbmale.Checked)
                pbpersonimage.Image = Resources.Male_512;
            else
                pbpersonimage.Image = Resources.Female_512;

            lbremoveimage.Visible = (pbpersonimage.ImageLocation != null);

            cbcountry.SelectedIndex = cbcountry.FindString("Egypt");

            dtpdateofbirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpdateofbirth.Value = dtpdateofbirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpdateofbirth.MinDate = DateTime.Now.AddYears(-100);

            txtfirstname.Text = "";
            txtsecondname.Text = "";
            txtthirdname.Text = "";
            txtlastname.Text = "";
            txtnationalno.Text = "";
            rbmale.Checked = true;
            txtphone.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";

        }
        // Load Data.
        private void _LoadData()
        {
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblpersonid.Text = _PersonID.ToString();
            txtfirstname.Text = _Person.FirstName;
            txtsecondname.Text = _Person.SecondName;
            txtthirdname.Text = _Person.ThirdName;
            txtlastname.Text = _Person.LastName;
            txtnationalno.Text = _Person.NationalNo;
            dtpdateofbirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbmale.Checked = true;
            else
                rbfemale.Checked = true;

            txtaddress.Text = _Person.Address;
            txtphone.Text = _Person.Phone;
            txtemail.Text = _Person.Email;
            cbcountry.SelectedIndex = cbcountry.FindString(_Person.CountryInfo.CountryName);

            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbpersonimage.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            lbremoveimage.Visible = (_Person.ImagePath != "");
        }
            // fill country in combobox.
            private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbcountry.Items.Add(row["CountryName"]);
            }
        }
        //  Close Button
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // When Form Is Loaded
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _InitializeForm();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbpersonimage.ImageLocation == null)
                pbpersonimage.Image = Resources.Female_512;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (pbpersonimage.ImageLocation == null)
                pbpersonimage.Image = Resources.Male_512;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _Person.FirstName = txtfirstname.Text.Trim();
            _Person.SecondName = txtsecondname.Text.Trim();
            _Person.ThirdName = txtthirdname.Text.Trim();
            _Person.LastName = txtlastname.Text.Trim();
            _Person.NationalNo = txtnationalno.Text.Trim();
            _Person.Email = txtemail.Text.Trim();
            _Person.Phone = txtphone.Text.Trim();
            _Person.Address = txtaddress.Text.Trim();
            _Person.DateOfBirth = dtpdateofbirth.Value;
            if (rbmale.Checked)
                _Person.Gender = (short)enGendor.Male;
            else
                _Person.Gender = (short)enGendor.Female;

            int NationalityCountryID = clsCountry.Find(cbcountry.Text).ID;
            _Person.NationalityCountryID = NationalityCountryID;

            // handle image
            if (pbpersonimage.ImageLocation != null)
                _Person.ImagePath = pbpersonimage.ImageLocation;
            else
                _Person.ImagePath = "";

            // Save Process
            if (_Person.Save())
            {
                lblpersonid.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lbltitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // validating 
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox t = ((TextBox)sender);

            if (string.IsNullOrEmpty(t.Text.Trim()))
            {
                e.Cancel = true; // منع المستخدم من الخروج من هذا الحقل قبل ملئه
                errorProvider1.SetError(t, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(t, null);
            }

        }

        private void txtnationalno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnationalno.Text.Trim()))
            {
                errorProvider1.SetError(txtnationalno, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtnationalno, null);
            }
            //Make sure the national number is not used by another person
            if (txtnationalno.Text.Trim() != _Person.NationalNo && clsPeople.isPersonExist(txtnationalno.Text.Trim()))
            {
                errorProvider1.SetError(txtnationalno, "National Number is used for another person!");
            }
            else
            {
                errorProvider1.SetError(txtnationalno, null);
            }
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtemail.Text.Trim() == "")
                return;
            //validate email format
            if (!clsValidatoin.ValidateEmail(txtemail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtemail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtemail, null);
            }
        }

        // set image
        private void lbsetimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgPath = openFileDialog1.FileName;
                pbpersonimage.Load(imgPath);
                lbremoveimage.Visible = true;
            }
        }

        private void lbremoveimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbpersonimage.ImageLocation = null;



            if (rbmale.Checked)
                pbpersonimage.Image = Resources.Male_512;
            else
                pbpersonimage.Image = Resources.Female_512;

            lbremoveimage.Visible = false;
        }
    
    }
}
