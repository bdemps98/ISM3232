/*
 * Programmer: Braeden Dempsey
 * Project: Assignment #4
 * Due Date: 7/15/2022
 * Description: Registration form.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dempsey_4
{
    public partial class RegistrationForm : Form
    {
        // Used to determine the price of live action classes.
        private const decimal LIVE_ACTION_CLASS = 79.95m;

        // Used to determine the price of animation classes.
        private const decimal ANIMATION_CLASS = 99.95m;

        // Used to determine the maximum classes allowed.
        private const int MAXIMUM_CLASSES_ALLOWED = 4;

        // Used to determine the name of the school throughout the program.
        public const string SCHOOL_NAME = "Hopkins Film School";

        // Constructor initializing the form.
        public RegistrationForm()
        {
            // Initializes the form load.
            InitializeComponent();

            // Sets the text to the schools name constant.
            Text = SCHOOL_NAME;
        }

        // Executes all statements upon form load. 
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            double test = PoundsToKg(20);
            double test2 = PoundsToKg2(20);
            MessageBox.Show(test.ToString() + Environment.NewLine + test2.ToString());

            // Sets the main label to the schools name. 
            mainLabel.Text = SCHOOL_NAME;

            // Sets the default date to the current date. 
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Sets the maximum amount of classes note to the constant. 
            maximumAmountOfClassesLabel.Text = MAXIMUM_CLASSES_ALLOWED.ToString();

            // Declares all possible status of the registerant. 
            string[] status = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };

            // Loops through status and adds each item to the combo box.
            for (int i = 0; i < status.Length; i++)
                statusOfRegistrantComboBox.Items.Add(status[i]);

            // Populates the classes list.
            PopulateList();

            // Updates the totals. 
            UpdateTotals();
        }

        // Executes all statements upon the save button being clicked.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checks to verify if all required information has been filled out. 
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailAddressTextBox.Text == "" || !dateOfBirthMaskedTextBox.MaskCompleted)

                // Notifies user if they have left anything blank.
                MessageBox.Show("At the minimum: First Name, Last Name, Email Address, and Date of Birth are required to save.", SCHOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Checks to verify if at least 1 class has been selected, but no more than the maximum allowed classes. (The greater than check is redundant and could be removed but the rubric asks for it)
            else if (classesListBox.SelectedIndices.Count < 1 || classesListBox.SelectedIndices.Count > MAXIMUM_CLASSES_ALLOWED)

                // Notifies user if they do not have the correct amount of classes selected.
                MessageBox.Show("At least 1 class has to be selected and no more than " + MAXIMUM_CLASSES_ALLOWED.ToString() + " are allowed.", SCHOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);

            // If none of the above is true try to save the file.
            else
            {
                try
                {
                    // Used to output all the selected classes.
                    string classes = "";
                    
                    // Loops through the entire classes list box.
                    for (int i = 0; i < classesListBox.Items.Count; i++)
                    {
                        // Checks to see if the index is selected.
                        if (classesListBox.GetSelected(i))

                            // Adds the indexed class to the classes string.
                            classes += classesListBox.Items[i] + Environment.NewLine;
                    }

                    // Used to output the payment type.
                    string payment = "";

                    // Checks if cash payment type is selected.
                    bool type = cashRadioButton.Checked;

                    // Determines the output value for payment.
                    if (type)

                        // Sets payment type ouput to cash.
                        payment = "Cash";
                    else

                        // Sets payment type output to check.
                        payment = "Check";

                    // Used to output whether email receipt is requsted or not.
                    string receipt = "";

                    // Checks if the email receipt requested checkbox is selected.
                    bool response = emailReceiptRequestedCheckBox.Checked;

                    // Determines the output value for receipt.
                    if (response)

                        // Sets the receipt to yes.
                        receipt = "Yes";
                    else

                        // Sets the receipt to no.
                        receipt = "No";

                    // Prepares a summary of all information determined by the user.
                    string summary = "Registration Summary" + Environment.NewLine +
                        "Registration Date: " + dateMaskedTextBox.Text + Environment.NewLine +
                        "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + Environment.NewLine +
                        "Email Address: " + emailAddressTextBox.Text + Environment.NewLine +
                        "Date of Birth: " + dateOfBirthMaskedTextBox.Text + Environment.NewLine +
                        "Status: " + statusOfRegistrantComboBox.SelectedItem.ToString() + Environment.NewLine +
                        "Classes Selected: " + Environment.NewLine + classes +
                        "Number of Classes Selected: " + classesListBox.SelectedIndices.Count + Environment.NewLine +
                        "Price Per Class: " + classPriceLabel.Text + Environment.NewLine +
                        "Total Registration Price: " + totalLabel.Text + Environment.NewLine +
                        "Payment Type: " + payment + Environment.NewLine +
                        "Email Receipt Requested: " + receipt;

                    // Showcases the summary to the user.
                    MessageBox.Show(summary, SCHOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Creates an instance of streamwriter to save the summary.
                    StreamWriter registrationData = File.AppendText("RegistrationData.txt");

                    // Writes the summary.
                    registrationData.WriteLine(summary);

                    // Writes another line to seperate future summaries.
                    registrationData.WriteLine();

                    // Closes the instance of streamwriter.
                    registrationData.Close();

                    // Resets the form to default state.
                    ResetForm();

                    // If something occurs when saving the file it will throw an exception.
                } catch (Exception exception)
                {
                    // If an error occurs while writing the output files this message will occur.
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // The program closes if the output files are not written properly due to an exception. 
                    this.Close();
                }
            }
        }

        // Executes all statements upon the clear button being clicked. 
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resets the form to default state.
            ResetForm();
        }

        // Executes all statements upon the exit button being clicked.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Asks the user if they want to quit.
            var selectedOption = MessageBox.Show("Are you sure you want to exit the program?", SCHOOL_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the selected option is yes the program closes.
            if (selectedOption == DialogResult.Yes)
                this.Close();
        }

        // Executes all statements upon the about button being clicked.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates an instance of the about form. 
            AboutForm aboutForm = new AboutForm();

            // Opens the form. 
            aboutForm.ShowDialog();
        }

        // Executes all statements upon the live action radio button being clicked.
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the classes list.
            PopulateList();

            // Updates the totals.
            UpdateTotals();
        }

        // Executes all statements upon the animation radio button being clicked.
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the classes list.
            PopulateList();

            // Updates the totals.
            UpdateTotals();
        }

        // Executes all statements upon the classes list box being clicked. 
        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cycles through the entire classes list box.
            for (int i = 0; i < classesListBox.Items.Count; i++)
            {
                // Deselects the class if the counter is above the maximum amount of classes.
                if (classesListBox.SelectedIndices.Count == MAXIMUM_CLASSES_ALLOWED + 1 && classesListBox.GetSelected(i))
                    classesListBox.SetSelected(i, false);
            }

            // Updates the totals accordingly.
            UpdateTotals();
        }

        // Loads data from external files into the classes list box.
        private void PopulateList()
        {
            // Clears items preventing duplicates. 
            classesListBox.Items.Clear();
            try
            {
                // If the live action radio button is selcted update the class list accordingly
                if (liveActionRadioButton.Checked)
                {
                    // Creates object to read the live action classes text file.
                    StreamReader liveActionClassesFile = File.OpenText("LiveActionClasses.txt");

                    // Populates the classes list box until there is no more data to read.
                    while (!liveActionClassesFile.EndOfStream)
                    {
                        // Reads the line and adds it as an item in the classes list box. 
                        classesListBox.Items.Add(liveActionClassesFile.ReadLine());
                    }

                    // Closes the file clearing up memory.
                    liveActionClassesFile.Close();

                    // Otherwise update the class list according to animation classes.
                } else
                {
                    // Creates object to read the animation classes text file.
                    StreamReader animationClassesFile = File.OpenText("AnimationClasses.txt");

                    // Populates the classes list box until there is no more data to read.
                    while (!animationClassesFile.EndOfStream)
                    {
                        // Reads the line and adds it as an item in the classes list box.
                        classesListBox.Items.Add(animationClassesFile.ReadLine());
                    }

                    // Closes the file clearing up memory.
                    animationClassesFile.Close();
                }
            } catch (Exception exception)
            {
                // If an error occurs while reading the input files this message will occur.
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // The program closes if the input files are not read because they are vital to the forms function. 
                this.Close();
            }
        }

        // Handles the task of updating the three number controls on the form. 
        private void UpdateTotals()
        {
            // Used to calculate the total cost. 
            decimal totalCost;

            // Updates the label displaying the number of selected classes.
            selectedClassesLabel.Text = classesListBox.SelectedItems.Count.ToString();

            // If the live action radio button is selected update totals based accordingly
            if (liveActionRadioButton.Checked)
            {
                // Updates the label displaying the cost per class.
                classPriceLabel.Text = LIVE_ACTION_CLASS.ToString("C");

                // Calculates the total cost.
                totalCost = classesListBox.SelectedItems.Count * LIVE_ACTION_CLASS;

                // Otherwise update totals according to the animation prices.
            } else
            {
                // Updates the label displaying the cost per class.
                classPriceLabel.Text = ANIMATION_CLASS.ToString("C");

                // Calculates the total cost.
                totalCost = classesListBox.SelectedItems.Count * ANIMATION_CLASS;
            }

            // Updates the label displaying the total cost. 
            totalLabel.Text = totalCost.ToString("C");
        }

        // Clears and resets any actions setting the form to default state. 
        private void ResetForm()
        {
            // Sets the default date to the current date. 
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Sets the first name text box to default.
            firstNameTextBox.ResetText();

            // Sets the last name text box to default.
            lastNameTextBox.ResetText();

            // Sets the email address text box to default.
            emailAddressTextBox.ResetText();

            // Sets the date of birth masked text box to default.
            dateOfBirthMaskedTextBox.ResetText();

            // Sets the class type to default.
            liveActionRadioButton.Checked = true;

            // Clears all selected classes.
            classesListBox.ClearSelected();

            // Updates the totals.
            UpdateTotals();

            // Sets the payment type to default.
            cashRadioButton.Checked = true;

            // Sets the email receipt requested check box to default.
            emailReceiptRequestedCheckBox.Checked = false;
        }

        public static double PoundsToKg(double pounds)
        {
            return (1 / 2.2) * pounds;
        }

        public static double PoundsToKg2(double pounds)
        {
            return pounds / 2.2;
        }
    }
}
