/*
 * Programmer: Braeden Dempsey
 * Project: Dempsey_2
 * Due Date: 6/10/2022
 * Description: Individual Assignment #2
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dempsey_2
{
    public partial class LanguageArtsInstitute : Form
    {
        // Initializes the program. 
        public LanguageArtsInstitute()
        {
            InitializeComponent();
        }

        // Used to calculate the amount of courses selected.
        private int courseCounter = 0;

        // Used to calculate the total cost of all selected courses.
        private decimal totalCost = 0.00m;

        // Determines the instate cost per course.
        private const decimal IN_STATE_COST = 49.00m;

        // Determines the out of state cost per course.
        private const decimal OUT_OF_STATE_COST = 99.00m;

        // Outputs the calculations to seperate form. 
        private void saveButton_Click(object sender, EventArgs e)
        {

            // Determines the term for output.
            bool isFall = fallRadioButton.Checked;
            string term;
            if (isFall)
                term = "Fall";
            else
                term = "Spring";

            // Determines the residency for output.
            bool isInState = inStateRadioButton.Checked;
            string residency;
            decimal cost;
            if (isInState)
            {
                residency = "In-State";
                cost = IN_STATE_COST;
            } else
            {
                residency = "Out-Of-State";
                cost = OUT_OF_STATE_COST;
            }

            // Determines the card type for output.
            bool isMasterCard = masterCardRadioButton.Checked;
            string card;
            if (isMasterCard)
                card = "Master Card";
            else
                card = "Visa";

            // Checks to see if the correct amount of courses have been selected. 
            if (courseCounter < 1 || courseCounter > 3)
            {
                MessageBox.Show("Course Order Information must contain at least one, but no more than three courses.", "Error: Course Order Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                try
                {
                    MessageBox.Show("Registeration Term: " + term + Environment.NewLine +
                        "Year: " + yearComboBox.Text + Environment.NewLine +
                        "First Name: " + studentFirstNameTextBox.Text + Environment.NewLine +
                        "Last Name: " + studentLastNameTextBox.Text + Environment.NewLine +
                        "Email: " + studentEmailTextBox.Text + Environment.NewLine +
                        "Residence Status: " + residency + Environment.NewLine +
                        "Total Courses Purchased: " + courseCounter.ToString() + Environment.NewLine +
                        "Price Per Course: " + cost.ToString("C") + Environment.NewLine + 
                        "Total Course Price: " + totalCost.ToString("C") + Environment.NewLine + 
                        "Credit Card Type: " + card + Environment.NewLine + 
                        "Card Number: " + creditCardNumberMaskedTextBox.Text + Environment.NewLine + 
                        "Card Expiration Date: " + expirationDateMaskedTextBox.Text, "Language Arts Institute (LAI) - Finalized Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch
                {
                    MessageBox.Show("Input data is invalid.", "Error: Course Order Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Clears all inputs and outputs on the main form. 
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Resets everything in term information to default. 
            fallRadioButton.Checked = true;
            yearComboBox.SelectedIndex = -1;

            // Resets everything in term information to default.
            studentIdentificationNumberTextBox.ResetText();
            firstNameTextBox.ResetText();
            lastNameTextBox.ResetText();
            emailTextBox.ResetText();
            inStateRadioButton.Checked = true;

            // Resets everything in course order information to default. 
            frenchCheckBox.Checked = false;
            frenchPriceLabel.ResetText();
            germanCheckBox.Checked = false;
            germanPriceLabel.ResetText();
            italianCheckBox.Checked = false;
            italianPriceLabel.ResetText();
            russianCheckBox.Checked = false;
            russianPriceLabel.ResetText();
            spanishCheckBox.Checked = false;
            spanishPriceLabel.ResetText();
            coursesLabel.Text = "0";
            totalPriceLabel.Text = "$0.00";

            // Resets everything in payment information to default.
            masterCardRadioButton.Checked = true;
            creditCardNumberMaskedTextBox.ResetText();
            expirationDateMaskedTextBox.ResetText();

            // Clears internal variables
            totalCost = 0.00m;
            courseCounter = 0;
        }

        // Exits the program. 
        private void exitButton_Click(object sender, EventArgs e)
        {
            var selectedOption = MessageBox.Show("Are you sure you want to quit?", "Language Arts Institute (LAI)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selectedOption == DialogResult.Yes)
                this.Close();   
        }

        // Prelimnary code that is ran before the program initializes.
        private void LanguageArtsInstitute_Load(object sender, EventArgs e)
        {
            // Adds the tool tips to the specified buttons. 
            saveButtonToolTip.SetToolTip(saveButton, "Outputs the inputed results ");
            clearButtonToolTip.SetToolTip(clearButton, "Clears all inputs and outputs on the program.");
            exitButtonToolTip.SetToolTip(exitButton, "Exits the program.");
        }

        // Handles the state of the French checked box.
        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frenchCheckBox.Checked)
            {
                courseCounter++;
                updateCourseInformation(frenchCheckBox, frenchPriceLabel);
            } else if (!frenchCheckBox.Checked)
            {
                courseCounter--;
                updateCourseInformation(frenchCheckBox, frenchPriceLabel);
            }
        }

        // Handles the state of the German checked box.
        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (germanCheckBox.Checked)
            {
                courseCounter++;
                updateCourseInformation(germanCheckBox, germanPriceLabel);
            }
            else if (!germanCheckBox.Checked)
            {
                courseCounter--;
                updateCourseInformation(germanCheckBox, germanPriceLabel);
            }
        }

        // Handles the state of the Italian checked box.
        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (italianCheckBox.Checked)
            {
                courseCounter++;
                updateCourseInformation(italianCheckBox, italianPriceLabel);
            }
            else if (!italianCheckBox.Checked)
            {
                courseCounter--;
                updateCourseInformation(italianCheckBox, italianPriceLabel);
            }
        }

        // Handles the state of the Russian checked box.
        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (russianCheckBox.Checked)
            {
                courseCounter++;
                updateCourseInformation(russianCheckBox, russianPriceLabel);
            }
            else if (!russianCheckBox.Checked)
            {
                courseCounter--;
                updateCourseInformation(russianCheckBox, russianPriceLabel);
            }
        }

        // Handles the state of the Spanish checked box.
        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (spanishCheckBox.Checked)
            {
                courseCounter++;
                updateCourseInformation(spanishCheckBox, spanishPriceLabel);
            }
            else if (!spanishCheckBox.Checked)
            {
                courseCounter--;
                updateCourseInformation(spanishCheckBox, spanishPriceLabel);
            }
        }

        // Calculates and updates the course information. 
        private void updateCourseInformation(CheckBox checkBox, Label label)
        {
            // Updates the course counter to the label.
            coursesLabel.Text = courseCounter.ToString();
            
            // If the checkbox is checked add to the total cost based on the status of the residency.
            if (checkBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    label.Text = IN_STATE_COST.ToString("C");
                    totalCost += IN_STATE_COST;
                    totalPriceLabel.Text = totalCost.ToString("C");
                }
                else
                {
                    label.Text = OUT_OF_STATE_COST.ToString("C");
                    totalCost += OUT_OF_STATE_COST;
                    totalPriceLabel.Text = totalCost.ToString("C");
                }
            // If the checkbox is unchecked subtract to the total cost based on the status of the residency. 
            } else if (!checkBox.Checked)
            {
                if (inStateRadioButton.Checked)
                {
                    label.ResetText();
                    totalCost -= IN_STATE_COST;
                    totalPriceLabel.Text = totalCost.ToString("C");
                }
                else
                {
                    label.ResetText();
                    totalCost -= OUT_OF_STATE_COST;
                    totalPriceLabel.Text = totalCost.ToString("C");
                }
            }
        }

        // If the state is changed it will clear out certain variables to prevent mathmatical errors.
        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Resets everything in course order information to default. 
            frenchCheckBox.Checked = false;
            frenchPriceLabel.ResetText();
            germanCheckBox.Checked = false;
            germanPriceLabel.ResetText();
            italianCheckBox.Checked = false;
            italianPriceLabel.ResetText();
            russianCheckBox.Checked = false;
            russianPriceLabel.ResetText();
            spanishCheckBox.Checked = false;
            spanishPriceLabel.ResetText();
            coursesLabel.Text = "0";
            totalPriceLabel.Text = "$0.00";

            // Clears internal variables
            totalCost = 0.00m;
            courseCounter = 0;
        }

        // If the state is changed it will clear out certain variables to prevent mathmatical errors.
        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Resets everything in course order information to default. 
            frenchCheckBox.Checked = false;
            frenchPriceLabel.ResetText();
            germanCheckBox.Checked = false;
            germanPriceLabel.ResetText();
            italianCheckBox.Checked = false;
            italianPriceLabel.ResetText();
            russianCheckBox.Checked = false;
            russianPriceLabel.ResetText();
            spanishCheckBox.Checked = false;
            spanishPriceLabel.ResetText();
            coursesLabel.Text = "0";
            totalPriceLabel.Text = "$0.00";

            // Clears internal variables
            totalCost = 0.00m;
            courseCounter = 0;
        }
    }
}
