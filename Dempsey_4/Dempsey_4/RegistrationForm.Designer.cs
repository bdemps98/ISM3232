namespace Dempsey_4
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.registrationFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrantInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.statusOfRegistrantComboBox = new System.Windows.Forms.ComboBox();
            this.statusOfRegistrantLabel = new System.Windows.Forms.Label();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registrationInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.classPriceLabel = new System.Windows.Forms.Label();
            this.selectedClassesLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.maximumAmountOfClassesLabel = new System.Windows.Forms.Label();
            this.classesNoteLabel = new System.Windows.Forms.Label();
            this.numberOfClassesSelectedLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.emailReceiptRequestedCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.registrationFormMenuStrip.SuspendLayout();
            this.registrantInformationGroupBox.SuspendLayout();
            this.registrationInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.mainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mainLabel.Location = new System.Drawing.Point(319, 46);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(172, 23);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(384, 87);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.dateMaskedTextBox.TabIndex = 3;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(345, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date:";
            // 
            // registrationFormMenuStrip
            // 
            this.registrationFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.registrationFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.registrationFormMenuStrip.Name = "registrationFormMenuStrip";
            this.registrationFormMenuStrip.Size = new System.Drawing.Size(538, 24);
            this.registrationFormMenuStrip.TabIndex = 0;
            this.registrationFormMenuStrip.Text = "Registration Form Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AutoToolTip = true;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Saves all the information on the form to an output file.";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.AutoToolTip = true;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.ToolTipText = "Sets the form to default state.";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoToolTip = true;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.ToolTipText = "Closes the program.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AutoToolTip = true;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Opens up another form that showcases the developer of the application. ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // registrantInformationGroupBox
            // 
            this.registrantInformationGroupBox.Controls.Add(this.statusOfRegistrantComboBox);
            this.registrantInformationGroupBox.Controls.Add(this.statusOfRegistrantLabel);
            this.registrantInformationGroupBox.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.emailAddressTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.registrantInformationGroupBox.Controls.Add(this.emailAddressLabel);
            this.registrantInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInformationGroupBox.Location = new System.Drawing.Point(12, 153);
            this.registrantInformationGroupBox.Name = "registrantInformationGroupBox";
            this.registrantInformationGroupBox.Size = new System.Drawing.Size(256, 138);
            this.registrantInformationGroupBox.TabIndex = 5;
            this.registrantInformationGroupBox.TabStop = false;
            this.registrantInformationGroupBox.Text = "Registrant Information";
            // 
            // statusOfRegistrantComboBox
            // 
            this.statusOfRegistrantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusOfRegistrantComboBox.FormattingEnabled = true;
            this.statusOfRegistrantComboBox.Location = new System.Drawing.Point(115, 105);
            this.statusOfRegistrantComboBox.Name = "statusOfRegistrantComboBox";
            this.statusOfRegistrantComboBox.Size = new System.Drawing.Size(122, 21);
            this.statusOfRegistrantComboBox.TabIndex = 9;
            // 
            // statusOfRegistrantLabel
            // 
            this.statusOfRegistrantLabel.AutoSize = true;
            this.statusOfRegistrantLabel.Location = new System.Drawing.Point(6, 108);
            this.statusOfRegistrantLabel.Name = "statusOfRegistrantLabel";
            this.statusOfRegistrantLabel.Size = new System.Drawing.Size(103, 13);
            this.statusOfRegistrantLabel.TabIndex = 8;
            this.statusOfRegistrantLabel.Text = "Status of Registrant:";
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(81, 83);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.dateOfBirthMaskedTextBox.TabIndex = 7;
            this.dateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(48, 61);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(189, 20);
            this.emailAddressTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(73, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(73, 17);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(6, 86);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 6;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(7, 64);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(35, 13);
            this.emailAddressLabel.TabIndex = 4;
            this.emailAddressLabel.Text = "Email:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 42);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // registrationInformationGroupBox
            // 
            this.registrationInformationGroupBox.Controls.Add(this.totalLabel);
            this.registrationInformationGroupBox.Controls.Add(this.classPriceLabel);
            this.registrationInformationGroupBox.Controls.Add(this.selectedClassesLabel);
            this.registrationInformationGroupBox.Controls.Add(this.totalPriceLabel);
            this.registrationInformationGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrationInformationGroupBox.Controls.Add(this.maximumAmountOfClassesLabel);
            this.registrationInformationGroupBox.Controls.Add(this.classesNoteLabel);
            this.registrationInformationGroupBox.Controls.Add(this.numberOfClassesSelectedLabel);
            this.registrationInformationGroupBox.Controls.Add(this.classesListBox);
            this.registrationInformationGroupBox.Controls.Add(this.animationRadioButton);
            this.registrationInformationGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrationInformationGroupBox.Location = new System.Drawing.Point(274, 153);
            this.registrationInformationGroupBox.Name = "registrationInformationGroupBox";
            this.registrationInformationGroupBox.Size = new System.Drawing.Size(256, 252);
            this.registrationInformationGroupBox.TabIndex = 6;
            this.registrationInformationGroupBox.TabStop = false;
            this.registrationInformationGroupBox.Text = "Registration Information";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(169, 226);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(16, 15);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "#";
            // 
            // classPriceLabel
            // 
            this.classPriceLabel.AutoSize = true;
            this.classPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classPriceLabel.Location = new System.Drawing.Point(169, 204);
            this.classPriceLabel.Name = "classPriceLabel";
            this.classPriceLabel.Size = new System.Drawing.Size(16, 15);
            this.classPriceLabel.TabIndex = 8;
            this.classPriceLabel.Text = "#";
            // 
            // selectedClassesLabel
            // 
            this.selectedClassesLabel.AutoSize = true;
            this.selectedClassesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedClassesLabel.Location = new System.Drawing.Point(169, 182);
            this.selectedClassesLabel.Name = "selectedClassesLabel";
            this.selectedClassesLabel.Size = new System.Drawing.Size(16, 15);
            this.selectedClassesLabel.TabIndex = 6;
            this.selectedClassesLabel.Text = "#";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(100, 226);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.AutoSize = true;
            this.pricePerClassLabel.Location = new System.Drawing.Point(80, 204);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(81, 13);
            this.pricePerClassLabel.TabIndex = 7;
            this.pricePerClassLabel.Text = "Price Per Class:";
            // 
            // maximumAmountOfClassesLabel
            // 
            this.maximumAmountOfClassesLabel.AutoSize = true;
            this.maximumAmountOfClassesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximumAmountOfClassesLabel.Location = new System.Drawing.Point(212, 46);
            this.maximumAmountOfClassesLabel.Name = "maximumAmountOfClassesLabel";
            this.maximumAmountOfClassesLabel.Size = new System.Drawing.Size(16, 15);
            this.maximumAmountOfClassesLabel.TabIndex = 3;
            this.maximumAmountOfClassesLabel.Text = "#";
            // 
            // classesNoteLabel
            // 
            this.classesNoteLabel.AutoSize = true;
            this.classesNoteLabel.Location = new System.Drawing.Point(14, 46);
            this.classesNoteLabel.Name = "classesNoteLabel";
            this.classesNoteLabel.Size = new System.Drawing.Size(192, 13);
            this.classesNoteLabel.TabIndex = 2;
            this.classesNoteLabel.Text = "Maximum Amount of Selected Classes: ";
            // 
            // numberOfClassesSelectedLabel
            // 
            this.numberOfClassesSelectedLabel.AutoSize = true;
            this.numberOfClassesSelectedLabel.Location = new System.Drawing.Point(72, 182);
            this.numberOfClassesSelectedLabel.Name = "numberOfClassesSelectedLabel";
            this.numberOfClassesSelectedLabel.Size = new System.Drawing.Size(91, 13);
            this.numberOfClassesSelectedLabel.TabIndex = 5;
            this.numberOfClassesSelectedLabel.Text = "Selected Classes:";
            // 
            // classesListBox
            // 
            this.classesListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(68, 64);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classesListBox.Size = new System.Drawing.Size(120, 108);
            this.classesListBox.Sorted = true;
            this.classesListBox.TabIndex = 4;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(141, 20);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(71, 17);
            this.animationRadioButton.TabIndex = 1;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Checked = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(45, 20);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(78, 17);
            this.liveActionRadioButton.TabIndex = 0;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Location = new System.Drawing.Point(72, 322);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 8;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(136, 322);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(56, 17);
            this.checkRadioButton.TabIndex = 9;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailReceiptRequestedCheckBox
            // 
            this.emailReceiptRequestedCheckBox.AutoSize = true;
            this.emailReceiptRequestedCheckBox.Location = new System.Drawing.Point(60, 345);
            this.emailReceiptRequestedCheckBox.Name = "emailReceiptRequestedCheckBox";
            this.emailReceiptRequestedCheckBox.Size = new System.Drawing.Size(146, 17);
            this.emailReceiptRequestedCheckBox.TabIndex = 10;
            this.emailReceiptRequestedCheckBox.Text = "Email Receipt Requested";
            this.emailReceiptRequestedCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(91, 306);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.paymentTypeLabel.TabIndex = 7;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = global::Dempsey_4.Properties.Resources.Untitled_1;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 27);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(256, 111);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 411);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.emailReceiptRequestedCheckBox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.registrationInformationGroupBox);
            this.Controls.Add(this.registrantInformationGroupBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.registrationFormMenuStrip);
            this.MainMenuStrip = this.registrationFormMenuStrip;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.registrationFormMenuStrip.ResumeLayout(false);
            this.registrationFormMenuStrip.PerformLayout();
            this.registrantInformationGroupBox.ResumeLayout(false);
            this.registrantInformationGroupBox.PerformLayout();
            this.registrationInformationGroupBox.ResumeLayout(false);
            this.registrationInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MenuStrip registrationFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox registrantInformationGroupBox;
        private System.Windows.Forms.ComboBox statusOfRegistrantComboBox;
        private System.Windows.Forms.Label statusOfRegistrantLabel;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox registrationInformationGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label classPriceLabel;
        private System.Windows.Forms.Label selectedClassesLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label maximumAmountOfClassesLabel;
        private System.Windows.Forms.Label classesNoteLabel;
        private System.Windows.Forms.Label numberOfClassesSelectedLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.CheckBox emailReceiptRequestedCheckBox;
        private System.Windows.Forms.Label paymentTypeLabel;
    }
}

