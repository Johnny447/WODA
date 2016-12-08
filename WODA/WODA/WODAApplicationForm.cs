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
            MessageBox.Show
                (
                    "Welcome to WODA " 
                        + firstNameTextbox.Text 
                        + " " 
                        + lastNameTextbox.Text,
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
            MessageBox.Show("Bye bye");

            //quit application
            Application.Exit();
        }
    }
}
