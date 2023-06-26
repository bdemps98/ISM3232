using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Programmer: Braeden Dempsey
Project: Dempsey_1
Due Date: 06/02/2022
Description: Individual Assignment #1
*/

namespace Dempsey_1
{
    public partial class motorwayMotelForm : Form
    {
        // The current tax rate
        private const decimal TAX_RATE = 0.07m;

        // Initializes the program
        public motorwayMotelForm()
        {
            InitializeComponent();
        }

        // Handles all calculations and displays them in Billing Information
        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Converting the inputs from the MaskedTextBoxes to useable variables
                decimal nights = Convert.ToDecimal(nightsStayed.Text);
                decimal rate = Convert.ToDecimal(rateCharged.Text);
                decimal telephone = Convert.ToDecimal(telephoneCharges.Text);
                decimal minibar = Convert.ToDecimal(miniBarCharges.Text);
                decimal misc = Convert.ToDecimal(miscCharges.Text);

                // Billing Summary calculations
                decimal room = nights * rate;
                decimal additional = telephone + minibar + misc;
                decimal sub = room + additional;
                decimal taxes = sub * TAX_RATE;
                decimal grandTotal = sub + taxes;

                // Displaying the calculations
                roomCharges.Text = room.ToString("C");
                additionalCharges.Text = additional.ToString("C");
                subtotal.Text = sub.ToString("C");
                tax.Text = taxes.ToString("C");
                total.Text = grandTotal.ToString("C");

                // Foucsing on the clear button after all calculations have been displayed
                clearButton.Focus();
            } catch
            {
                // If one of the variables has null data this will notify the user that invalid data has been entered 
                MessageBox.Show("Invlaid data was entered. Please click the 'Help' button for more details", "Error");
            }
        }

        // Clears all TextBox entries as well as Billing Information labels
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Resetting the TextBoxes
            date.Clear();
            firstName.Clear();
            lastName.Clear();
            roomNumber.Clear();
            nightsStayed.Clear();
            rateCharged.Clear();
            telephoneCharges.Clear();
            miniBarCharges.Clear();
            miscCharges.Clear();

            // Resetting the Billing Information summary
            roomCharges.Text = "";
            additionalCharges.Text = "";
            subtotal.Text = "";
            tax.Text = "";
            total.Text = "";

            // Foucsing on the first entry
            date.Focus();
        }

        // Brief instructions to the user on how to utilize the program
        private void helpButton_Click(object sender, EventArgs e)
        {
            // MessageBox that gives instructions
            MessageBox.Show("This application is designed with four functions. Please note all information must be filled out in order to utilize the programs full functions" +
                "The 'Total' button totals up all costs based on information entered and displays what the guest owes. " +
                "The 'Clear' button resets all entries. " +
                "The 'Help' button displays this message." +
                "The 'Quit' button closes the program.", "Help Button");
        }

        // Closes the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the application
            this.Close();
        }
    }
}
