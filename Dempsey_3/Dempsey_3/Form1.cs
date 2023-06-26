/*
 * Programmer: Braeden Dempsey
 * Project: Dempsey_3
 * Due Date: 7/1/2022
 * Description: Individual Assignment #3
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

namespace Dempsey_3
{
    public partial class BalloonOrderForm : Form
    {
        // Declares the cost of home delivery option.
        private const decimal HOME_DELIVERY_COST = 7.5m;

        // Declares the cost of the single quantity option.
        private const decimal SINGLE = 9.95m;

        // Declares the cost of the half dozen quantity option.
        private const decimal HALF_DOZEN = 35.95m;

        // Declares the cost of the dozen quantity option.
        private const decimal DOZEN = 65.95m;

        // Declares the cost of having a personalized message. 
        private const decimal PERSONALIZED_MESSAGE_COST = 2.5m;

        // Declares the cost of the extra items. 
        private const decimal EXTRA_ITEM_COST = 9.5m;

        // Declares the sales tax rate for the form.
        private const decimal SALES_TAX_RATE = 0.07m;

        // Initializes the program. 
        public BalloonOrderForm()
        {
            InitializeComponent();
        }

        // Populates the special occasions combo box and extras list box. 
        private void PopulateBoxes()
        {
            try
            {
                // Creates object to read the occasions text file.
                StreamReader occasionsFile = File.OpenText("Occasions.txt");

                // Creates object to read the extras text file.
                StreamReader extrasFile = File.OpenText("Extras.txt");

                // Populates the special occasions combo box until there is no more data to read. 
                while (!occasionsFile.EndOfStream)
                {
                    // Reads the the line and adds it as an item in the special occasions combo box.
                    specialOccasionComboBox.Items.Add(occasionsFile.ReadLine());
                }

                // Closes the occasions file.
                occasionsFile.Close();

                // Populates the extras list box until there is no more data to read.
                while (!extrasFile.EndOfStream)
                {
                    // Reads the line and ads it as an item in the extras list box. 
                    extraListBox.Items.Add(extrasFile.ReadLine());
                }

                // Closes the extras file.
                extrasFile.Close();

            }
            catch (Exception ex)
            {
                // If an error occurs while reading the input files this message will occur.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // The program closes if the input files are not read because they are vital to the forms function. 
                this.Close();
            }
        }

        // Executes the following statements upon startup. 
        private void BalloonOrderForm_Load(object sender, EventArgs e)
        {
            // Populates the combo and list box used within the form.
            PopulateBoxes();

            // Sets the combo box to display the 'Birthday' option per the rubric. 
            specialOccasionComboBox.SelectedItem = "Birthday";

            // Sets the date masked text box to default time
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM//dd/yyyy");

            // Sets the home delivery price label to the constant declared.
            homeDeliveryPriceLabel.Text = HOME_DELIVERY_COST.ToString("C");

            // Sets the single price label to the constant declared.
            singlePriceLabel.Text = SINGLE.ToString("C");

            // Sets the half dozen price label to the constant declared.
            halfDozenPriceLabel.Text = HALF_DOZEN.ToString("C");

            // Sets the dozen price label to the constant declared.
            dozenPriceLabel.Text = DOZEN.ToString("C");

            // Sets the personalized message prize label to the constant declared.
            personalizedMessagePriceLabel.Text = PERSONALIZED_MESSAGE_COST.ToString("C");

            // Sets the box of chocolates price label to the constant declared.
            boxOfChocolatesPriceLabel.Text = EXTRA_ITEM_COST.ToString("C");

            // Sets the coffee mug price label to the constant declared.
            coffeeMugPriceLabel.Text = EXTRA_ITEM_COST.ToString("C");

            // Sets the flower wrrangement price label to the constant declared.
            flowerArrangementPriceLabel.Text = EXTRA_ITEM_COST.ToString("C");

            // Sets the jar of jelly beans price label to the constant declared
            jarOfJellyBeansPriceLabel.Text = EXTRA_ITEM_COST.ToString("C");

            // Sets the potted plant price label to the constant declared.
            pottedPlantPriceLabel.Text = EXTRA_ITEM_COST.ToString("C");

            // Updates the totals.
            UpdateTotals();
        }

        // Resets the form to it's default state. 
        private void ResetForm()
        {
            // Resets the title combo box.
            titleComboBox.ResetText();

            // Resets the first name text box.
            firstNameTextBox.ResetText();

            // Resets the last name text box.
            lastNameTextBox.ResetText();

            // Resets the phone number masked text box.
            phoneNumberMaskedTextBox.ResetText();

            // Resets the street text box.
            streetTextBox.ResetText();

            // Resets the city text box.
            cityTextBox.ResetText();

            // Resets the state text box.
            stateTextBox.ResetText();

            // Resets the zip masked text box.
            zipMaskedTextBox.ResetText();

            // Resets the date masked text box back to default time. 
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM//dd/yyyy");

            // Sets delivery option to default. 
            storePickUpRadioButton.Checked = true;

            // Sets order amount to default.
            singleRadioButton.Checked = true;

            // Sets the special occasion combo box to 'Birthday' per the rubric.
            specialOccasionComboBox.SelectedItem = "Birthday";

            // Resets the personalized message check box.
            personalizedMessageCheckBox.Checked = false;

            // Sets the character limit label to not visible.
            characterLimitLabel.Visible = false;

            // Resets the personalized message textbox. 
            personalizedMessageTextBox.ResetText();

            // Resets the extras list box. 
            extraListBox.ClearSelected();

            // Sets the personalizes message textbox to not visible. 
            personalizedMessageTextBox.Visible = false; 

            // Sets the box of chocolates price label to not visible.
            boxOfChocolatesPriceLabel.Visible = false;

            // Sets the coffe mug price label to not visible.
            coffeeMugPriceLabel.Visible = false;

            // Sets the flower arrangement price label to not visible.
            flowerArrangementPriceLabel.Visible = false;

            // Sets the jar of jelly beans price label to not visible.
            jarOfJellyBeansPriceLabel.Visible = false;

            // Sets the potted plant price label to not visible.
            pottedPlantPriceLabel.Visible = false;

            // Updates the totals on the form after everything has been reset.
            UpdateTotals();

            // Shifts focus back to the top.
            firstNameTextBox.Focus();
        }

        // Updates the totals based on the user inputs. 
        private void UpdateTotals()
        {
            // Variable used for calculating the subtotal.
            decimal subtotal = 0m;

            // Variable used for calculating the sales tax. 
            decimal salesTax = 0m;

            // Variable used for caclulating the order total. 
            decimal orderTotal = 0m;

            // Checks if home delivery option is selected. 
            if (homeDeliveryRadioButton.Checked)
                subtotal += HOME_DELIVERY_COST;

            // Checks if the single quanitity option is selected.
            if (singleRadioButton.Checked)
                subtotal += SINGLE;

            // Checks if the half dozen quantity option is selected.
            if (halfDozenRadioButton.Checked)
                subtotal += HALF_DOZEN;

            // Checks if the doze quantity option is selected.
            if (dozenRadioButton.Checked)
                subtotal += DOZEN;

            // Checks if the personalized message checkbox is selected.
            if (personalizedMessageCheckBox.Checked)
                subtotal += PERSONALIZED_MESSAGE_COST;

            // Adds any extras to the subtotal.
            subtotal += extraListBox.SelectedItems.Count* EXTRA_ITEM_COST;

            // Sets the subtotal text to the subtotal.
            subtotalOutputLabel.Text = subtotal.ToString("C");

            // Calculates the sales tax. 
            salesTax = subtotal * SALES_TAX_RATE;

            // Sets the sales tax label to the sales tax.
            salesTaxOutputLabel.Text = salesTax.ToString("C");

            // Calcualtes the order total. 
            orderTotal = subtotal + salesTax;

            // Sets the order total text to the order total.
            orderTotalOutputLabel.Text = orderTotal.ToString("C");
        }

        // Handles the event of the personalized message check box being clicked.
        private void personalizedMessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the personalized message check box is true.
            if (personalizedMessageCheckBox.Checked)
            {
                // Sets the character limit label is visible.
                characterLimitLabel.Visible = true;

                // Sets the personalized message text box is visible.
                personalizedMessageTextBox.Visible = true;
            } else
            {
                // Sets the character limit label to not visible.
                characterLimitLabel.Visible = false;

                // Resets any text within the personalized message textbox when deselected.
                personalizedMessageTextBox.ResetText();

                // Sets the personalized message text box to not visible.
                personalizedMessageTextBox.Visible = false;
            }

            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Hanldes the event of the store pick up radio button being clicked.
        private void storePickUpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Handles the event of the home delivery radio button being clicked.
        private void homeDeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Handles the event of the single quantity radio button being clicked.
        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Handles the event of the half dozen quantity radio button being clicked. 
        private void halfDozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Handles the event of the dozen radio quantity radio button being clicked.
        private void dozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Handles the event of the extra list box being clicked.
        private void extraListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cycles through the entire extra list box.
            for (int i = 0; i < extraListBox.Items.Count; i++)
            {
                // Expression is based on the index value.
                switch (i)
                {
                    // Sets the visibility of the first label based on if the user has selected the value.
                    case 0:
                        boxOfChocolatesPriceLabel.Visible = extraListBox.GetSelected(i);
                        break;

                    // Sets the visibility of the second label based on if the user has selected the value.
                    case 1:
                        coffeeMugPriceLabel.Visible = extraListBox.GetSelected(i);
                        break;

                    // Sets the visibility of the third label based on if the user has selected the value.
                    case 2:
                        flowerArrangementPriceLabel.Visible = extraListBox.GetSelected(i);
                        break;

                    // Sets the visibility of the fourth label based on if the user has selected the value.
                    case 3:
                        jarOfJellyBeansPriceLabel.Visible = extraListBox.GetSelected(i);
                        break;

                    // Sets the visibility of the fifth label based on if the user has selected the value.
                    case 4:
                        pottedPlantPriceLabel.Visible = extraListBox.GetSelected(i);
                        break;

                    // Breaks on default, no further code is needed.
                    default:
                        break;
                }
            }

            // Updates the totals based on the actions from the user.
            UpdateTotals();
        }

        // Handles the event of the clear button being clicked.
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears the form to default state.
            ResetForm();
        }

        // Handles the event of the exit button being clicked.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Asks the user if they want to quit.
            var selectedOption = MessageBox.Show("Are you sure you want to quit?", "Bonnie's Balloons", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the selected option is yes the program closes.
            if (selectedOption == DialogResult.Yes)
                this.Close();
        }

        // Handles the event of the display sumamry button being clicked.
        private void displaySummaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks to see if first, last, and phone number were left blank. If the phone number is incomplete or any of the before it will not continue.
                if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneNumberMaskedTextBox.Text == "" || !phoneNumberMaskedTextBox.MaskCompleted)
                {
                    // Notifies the user that something is incomplete.
                    MessageBox.Show("At the minimum: First Name, Last Name, and Phone Number need to be filled out to display the transaction infromation.", "Error: Bonnie's Balloons", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    // Determines the output for delivery type.
                    string type;
                    bool deliveryType = storePickUpRadioButton.Checked;
                    if (deliveryType)
                        type = "Store Pick-Up";
                    else
                        type = "Home Delivery";

                    // Determines the output for bundle size. 
                    string bundle;
                    bool size = singleRadioButton.Checked;
                    if (size)
                        bundle = "Single";
                    else
                        size = halfDozenRadioButton.Checked;

                    if (size)
                    {
                        bundle = "Half-Dozen";
                    } else
                    {
                        bundle = "Dozen";
                    }

                    // Determines the output for all the selected extras.
                    string extrasList = "";
                    for (int i = 0; i < extraListBox.Items.Count; i++)
                    {
                        if (extraListBox.GetSelected(i))
                        {
                            extrasList += extraListBox.Items[i] + Environment.NewLine;
                        }
                    }

                    // If no extras are selected then create a new line.
                    if (extrasList == "")
                        extrasList = Environment.NewLine;

                    // Outputs all the inputed information.
                    MessageBox.Show("Customer Name: " + titleComboBox.SelectedItem + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + Environment.NewLine +
                   "Customer Address: " + streetTextBox.Text + " " + cityTextBox.Text + ", " + stateTextBox.Text + " " + zipMaskedTextBox.Text + Environment.NewLine +
                   "Phone Number: " + phoneNumberMaskedTextBox.Text + Environment.NewLine +
                   "Delivery Date: " + dateMaskedTextBox.Text + Environment.NewLine +
                   "Delivery Type: " + type + Environment.NewLine +
                   "Bundle Size: " + bundle + Environment.NewLine +
                   "Occasion: " + specialOccasionComboBox.Text + Environment.NewLine +
                   "Extras: " + extrasList + 
                   "Personal Message: " + personalizedMessageTextBox.Text + Environment.NewLine +
                   "Order Subtotal: " + subtotalOutputLabel.Text + Environment.NewLine +
                   "Sales Tax: " + salesTaxOutputLabel.Text + Environment.NewLine +
                   "Order Total: " + orderTotalOutputLabel.Text, "Bonnie's Ballons Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    // Resets the form after the output is displayed.
                    ResetForm();
                }
            } catch (Exception ex)
            {
                // If an error occurs while reading the input files this message will occur.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
