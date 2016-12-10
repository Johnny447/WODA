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

            fullName = firstNameTextbox.Text + " " + lastNameTextbox.Text;

            minimumAge = (byte)minimumAgeSpinner.Value;
            maximumAge = Convert.ToByte(maximumAgeSpinner.Value);

            ageRange = (byte)(maximumAge - minimumAge);

            messageText = "Welcome to WODA " + fullName;
            messageText += "\nYou are a " + yourGenderList.Text;
            messageText += "\nYou are looking for a " + theirGenderList.Text;
            messageText += "\nYour partner's age range is " + ageRange;
            messageText += "\nYou were born on " + dob.ToString("dddd d MMMM yyyy");

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
