/*
 * Programmer: Braeden Dempsey
 * Project: Assignment #4
 * Due Date: 7/15/2022
 * Description: About form.
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

namespace Dempsey_4
{
    public partial class AboutForm : Form
    {
        // Constructor initializing the form.
        public AboutForm()
        {
            // Initializes the form. 
            InitializeComponent();

            // Sets the label to the corresponding information.
            developerLabel.Text = RegistrationForm.SCHOOL_NAME + Environment.NewLine + "Copyright 2022 by Braeden Dempsey";
        }

        // Executes the following statements when the exit button is clicked.
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the program.
            this.Close();
        }
    }
}
