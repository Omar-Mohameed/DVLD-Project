using DVLD_BusinessLayer;
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
using static DVLD_PresentationLayer.People.frmAddUpdatePerson;

namespace DVLD_PresentationLayer.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPeople _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void btneditpersoninfo_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblpersonid.Text = "[????]";
            lblnationalid.Text = "[????]";
            lblfullname.Text = "[????]";
            pbgender.Image = Resources.Man_32;
            lblgender.Text = "[????]";
            lblemail.Text = "[????]";
            lblphone.Text = "[????]";
            lbldateofbirth.Text = "[????]";
            lblcountry.Text = "[????]";
            lbladdress.Text = "[????]";
            pbperson.Image = Resources.Male_512;

        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbperson.Image = Resources.Male_512;
            else
                pbperson.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbperson.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblpersonid.Text = _Person.PersonID.ToString();
            lblnationalid.Text = _Person.NationalNo;
            lblfullname.Text = _Person.FullName;
            lblgender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblemail.Text = _Person.Email;
            lblphone.Text = _Person.Phone;
            lbldateofbirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblcountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lbladdress.Text = _Person.Address;

            _LoadPersonImage();

        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPeople.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
    }
}
