using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WODA
{
    public partial class WODAApplicationForm : Form
    {
        private string fullName = string.Empty;

        public WODAApplicationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WODAApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void applyNowButton_Click(object sender, EventArgs e)
        {
            //this method displays a message when the user clicks the button
            string messageText = string.Empty;
            byte minimumAge = 0;
            byte maximumAge = 0;
            byte ageRange = 0;
            DateTime dob = dateOfBirthPicker.Value;
            int age = 0;
            string ageCategory = string.Empty;
            string yourGender = string.Empty;
            string partnerGender = string.Empty;

            if (firstNameTextbox.Text == string.Empty)
            {
                firstNameTextbox.BackColor = Color.Pink;
                firstNameLabel.ForeColor = Color.Red;
                firstNameTextbox.Focus();
                return;
            }
            else
            {
                firstNameTextbox.BackColor = Color.White;
                firstNameLabel.ForeColor = Color.Black;
            }

            if (lastNameTextbox.Text == String.Empty)
            {
                lastNameTextbox.BackColor = Color.Pink;
                lastNameLabel.ForeColor = Color.Red;
                lastNameTextbox.Focus();
            }
            else
            {
                lastNameTextbox.BackColor = Color.White;
                lastNameLabel.ForeColor = Color.Black;
            }


            fullName = firstNameTextbox.Text + " " + lastNameTextbox.Text;

            age = DateTime.Today.Year - dob.Year;

            if (age < 18)
            {
                MessageBox.Show("You're too young");
                return;
            }
            else if (age < 30)
            {
                ageCategory = "Young";
            }
            else if (age < 55)
            {
                ageCategory = "Middle Age";
            }
            else
            {
                ageCategory = "Old";
            }

            yourGender = (yourGenderList.Text == "Male") ? "man" : "woman";
            partnerGender = (theirGenderList.Text == "Male") ? "man" : "woman";

            minimumAge = (byte)minimumAgeSpinner.Value;
            maximumAge = Convert.ToByte(maximumAgeSpinner.Value);

            ageRange = (byte)(maximumAge - minimumAge);

            messageText = "Welcome to WODA " + fullName;
            messageText += "\nYou are a " + yourGender;
            messageText += "\nYou are looking for a " + partnerGender;
            messageText += "\nYour partner's age range is " + ageRange;
            messageText += "\nYou were born on " + dob.ToString("dddd d MMMM yyyy");
            messageText += "\n your age is " + age;
            messageText += "\n your age category is " + ageCategory;

            MessageBox.Show
                (
                    messageText,
                    "WODA Application",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            //clear the first and last name textboxes
            firstNameTextbox.Clear();
            lastNameTextbox.Clear();

            //clear text from gender comboboxes
            yourGenderList.ResetText();
            theirGenderList.ResetText();

            //reset age boxes
            minimumAgeSpinner.Value = 18;
            maximumAgeSpinner.Value = 100;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //form disappear
            this.Visible = false;

            //message appears
            MessageBox.Show("Bye bye " + fullName);

            //quit application
            Application.Exit();
        }
    }
}
