namespace Dempsey_3
{
    partial class BalloonOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.displaySummaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.zipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.storePickUpPriceLabel = new System.Windows.Forms.Label();
            this.homeDeliveryPriceLabel = new System.Windows.Forms.Label();
            this.homeDeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.storePickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.characterLimitLabel = new System.Windows.Forms.Label();
            this.personalizedMessageTextBox = new System.Windows.Forms.TextBox();
            this.personalizedMessagePriceLabel = new System.Windows.Forms.Label();
            this.personalizedMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.pottedPlantPriceLabel = new System.Windows.Forms.Label();
            this.jarOfJellyBeansPriceLabel = new System.Windows.Forms.Label();
            this.flowerArrangementPriceLabel = new System.Windows.Forms.Label();
            this.coffeeMugPriceLabel = new System.Windows.Forms.Label();
            this.boxOfChocolatesPriceLabel = new System.Windows.Forms.Label();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.extraListBox = new System.Windows.Forms.ListBox();
            this.specialOccasionLabel = new System.Windows.Forms.Label();
            this.specialOccasionComboBox = new System.Windows.Forms.ComboBox();
            this.dozenPriceLabel = new System.Windows.Forms.Label();
            this.halfDozenPriceLabel = new System.Windows.Forms.Label();
            this.singlePriceLabel = new System.Windows.Forms.Label();
            this.dozenRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDozenRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.orderTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderTotalOutputLabel = new System.Windows.Forms.Label();
            this.salesTaxOutputLabel = new System.Windows.Forms.Label();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.displayInformationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerInformationGroupBox.SuspendLayout();
            this.deliveryInformationGroupBox.SuspendLayout();
            this.orderDetailsGroupBox.SuspendLayout();
            this.orderTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaySummaryButton
            // 
            this.displaySummaryButton.Location = new System.Drawing.Point(12, 590);
            this.displaySummaryButton.Name = "displaySummaryButton";
            this.displaySummaryButton.Size = new System.Drawing.Size(96, 23);
            this.displaySummaryButton.TabIndex = 5;
            this.displaySummaryButton.Text = "&Display Summary";
            this.displayInformationToolTip.SetToolTip(this.displaySummaryButton, "This button displays the order summary of a completed form.");
            this.displaySummaryButton.UseVisualStyleBackColor = true;
            this.displaySummaryButton.Click += new System.EventHandler(this.displaySummaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(333, 590);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitToolTip.SetToolTip(this.exitButton, "This button will exit the program. ");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(165, 590);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearToolTip.SetToolTip(this.clearButton, "This button clears the entire form back to default state.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dempsey_3.Properties.Resources.ballonspicture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 108);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyNameLabel.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.companyNameLabel.Location = new System.Drawing.Point(135, 123);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(177, 23);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Bonnie\'s Balloons";
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.zipMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.zipLabel);
            this.customerInformationGroupBox.Controls.Add(this.stateTextBox);
            this.customerInformationGroupBox.Controls.Add(this.stateLabel);
            this.customerInformationGroupBox.Controls.Add(this.cityTextBox);
            this.customerInformationGroupBox.Controls.Add(this.cityLabel);
            this.customerInformationGroupBox.Controls.Add(this.streetTextBox);
            this.customerInformationGroupBox.Controls.Add(this.streetLabel);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberLabel);
            this.customerInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.titleLabel);
            this.customerInformationGroupBox.Controls.Add(this.titleComboBox);
            this.customerInformationGroupBox.Location = new System.Drawing.Point(12, 149);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(422, 135);
            this.customerInformationGroupBox.TabIndex = 1;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // zipMaskedTextBox
            // 
            this.zipMaskedTextBox.Location = new System.Drawing.Point(255, 106);
            this.zipMaskedTextBox.Mask = "00000";
            this.zipMaskedTextBox.Name = "zipMaskedTextBox";
            this.zipMaskedTextBox.Size = new System.Drawing.Size(45, 20);
            this.zipMaskedTextBox.TabIndex = 15;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(224, 109);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 14;
            this.zipLabel.Text = "Zip:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stateTextBox.Location = new System.Drawing.Point(257, 77);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(43, 20);
            this.stateTextBox.TabIndex = 13;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(216, 77);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 12;
            this.stateLabel.Text = "State:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(257, 46);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(151, 20);
            this.cityTextBox.TabIndex = 11;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(224, 49);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(257, 16);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(151, 20);
            this.streetTextBox.TabIndex = 9;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(213, 19);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 8;
            this.streetLabel.Text = "Street:";
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(93, 106);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(95, 20);
            this.phoneNumberMaskedTextBox.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(6, 109);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 6;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(73, 77);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 80);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(72, 46);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 49);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(6, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev."});
            this.titleComboBox.Location = new System.Drawing.Point(47, 16);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(49, 21);
            this.titleComboBox.TabIndex = 1;
            // 
            // deliveryInformationGroupBox
            // 
            this.deliveryInformationGroupBox.Controls.Add(this.storePickUpPriceLabel);
            this.deliveryInformationGroupBox.Controls.Add(this.homeDeliveryPriceLabel);
            this.deliveryInformationGroupBox.Controls.Add(this.homeDeliveryRadioButton);
            this.deliveryInformationGroupBox.Controls.Add(this.storePickUpRadioButton);
            this.deliveryInformationGroupBox.Controls.Add(this.dateMaskedTextBox);
            this.deliveryInformationGroupBox.Controls.Add(this.dateLabel);
            this.deliveryInformationGroupBox.Location = new System.Drawing.Point(12, 290);
            this.deliveryInformationGroupBox.Name = "deliveryInformationGroupBox";
            this.deliveryInformationGroupBox.Size = new System.Drawing.Size(422, 74);
            this.deliveryInformationGroupBox.TabIndex = 2;
            this.deliveryInformationGroupBox.TabStop = false;
            this.deliveryInformationGroupBox.Text = "Delivery Information";
            // 
            // storePickUpPriceLabel
            // 
            this.storePickUpPriceLabel.AutoSize = true;
            this.storePickUpPriceLabel.Location = new System.Drawing.Point(166, 48);
            this.storePickUpPriceLabel.Name = "storePickUpPriceLabel";
            this.storePickUpPriceLabel.Size = new System.Drawing.Size(35, 13);
            this.storePickUpPriceLabel.TabIndex = 3;
            this.storePickUpPriceLabel.Text = "FREE";
            this.storePickUpPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeDeliveryPriceLabel
            // 
            this.homeDeliveryPriceLabel.AutoSize = true;
            this.homeDeliveryPriceLabel.Location = new System.Drawing.Point(319, 48);
            this.homeDeliveryPriceLabel.Name = "homeDeliveryPriceLabel";
            this.homeDeliveryPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.homeDeliveryPriceLabel.TabIndex = 5;
            this.homeDeliveryPriceLabel.Text = "$7.50";
            this.homeDeliveryPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeDeliveryRadioButton
            // 
            this.homeDeliveryRadioButton.AutoSize = true;
            this.homeDeliveryRadioButton.Location = new System.Drawing.Point(223, 46);
            this.homeDeliveryRadioButton.Name = "homeDeliveryRadioButton";
            this.homeDeliveryRadioButton.Size = new System.Drawing.Size(94, 17);
            this.homeDeliveryRadioButton.TabIndex = 4;
            this.homeDeliveryRadioButton.TabStop = true;
            this.homeDeliveryRadioButton.Text = "Home Delivery";
            this.homeDeliveryRadioButton.UseVisualStyleBackColor = true;
            this.homeDeliveryRadioButton.CheckedChanged += new System.EventHandler(this.homeDeliveryRadioButton_CheckedChanged);
            // 
            // storePickUpRadioButton
            // 
            this.storePickUpRadioButton.AutoSize = true;
            this.storePickUpRadioButton.Checked = true;
            this.storePickUpRadioButton.Location = new System.Drawing.Point(69, 46);
            this.storePickUpRadioButton.Name = "storePickUpRadioButton";
            this.storePickUpRadioButton.Size = new System.Drawing.Size(91, 17);
            this.storePickUpRadioButton.TabIndex = 2;
            this.storePickUpRadioButton.TabStop = true;
            this.storePickUpRadioButton.Text = "Store Pick-Up";
            this.storePickUpRadioButton.UseVisualStyleBackColor = true;
            this.storePickUpRadioButton.CheckedChanged += new System.EventHandler(this.storePickUpRadioButton_CheckedChanged);
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(192, 19);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.dateMaskedTextBox.TabIndex = 1;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(153, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // orderDetailsGroupBox
            // 
            this.orderDetailsGroupBox.Controls.Add(this.characterLimitLabel);
            this.orderDetailsGroupBox.Controls.Add(this.personalizedMessageTextBox);
            this.orderDetailsGroupBox.Controls.Add(this.personalizedMessagePriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.personalizedMessageCheckBox);
            this.orderDetailsGroupBox.Controls.Add(this.pottedPlantPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.jarOfJellyBeansPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.flowerArrangementPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.coffeeMugPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.boxOfChocolatesPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.extrasLabel);
            this.orderDetailsGroupBox.Controls.Add(this.extraListBox);
            this.orderDetailsGroupBox.Controls.Add(this.specialOccasionLabel);
            this.orderDetailsGroupBox.Controls.Add(this.specialOccasionComboBox);
            this.orderDetailsGroupBox.Controls.Add(this.dozenPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.halfDozenPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.singlePriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.dozenRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.halfDozenRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.singleRadioButton);
            this.orderDetailsGroupBox.Location = new System.Drawing.Point(13, 370);
            this.orderDetailsGroupBox.Name = "orderDetailsGroupBox";
            this.orderDetailsGroupBox.Size = new System.Drawing.Size(422, 154);
            this.orderDetailsGroupBox.TabIndex = 3;
            this.orderDetailsGroupBox.TabStop = false;
            this.orderDetailsGroupBox.Text = "Order Details";
            // 
            // characterLimitLabel
            // 
            this.characterLimitLabel.AutoSize = true;
            this.characterLimitLabel.Location = new System.Drawing.Point(38, 112);
            this.characterLimitLabel.Name = "characterLimitLabel";
            this.characterLimitLabel.Size = new System.Drawing.Size(162, 13);
            this.characterLimitLabel.TabIndex = 10;
            this.characterLimitLabel.Text = "30 Characters Maxiumum Length";
            this.characterLimitLabel.Visible = false;
            // 
            // personalizedMessageTextBox
            // 
            this.personalizedMessageTextBox.Location = new System.Drawing.Point(9, 128);
            this.personalizedMessageTextBox.MaxLength = 30;
            this.personalizedMessageTextBox.Name = "personalizedMessageTextBox";
            this.personalizedMessageTextBox.Size = new System.Drawing.Size(217, 20);
            this.personalizedMessageTextBox.TabIndex = 11;
            this.personalizedMessageTextBox.Visible = false;
            // 
            // personalizedMessagePriceLabel
            // 
            this.personalizedMessagePriceLabel.AutoSize = true;
            this.personalizedMessagePriceLabel.Location = new System.Drawing.Point(149, 89);
            this.personalizedMessagePriceLabel.Name = "personalizedMessagePriceLabel";
            this.personalizedMessagePriceLabel.Size = new System.Drawing.Size(34, 13);
            this.personalizedMessagePriceLabel.TabIndex = 9;
            this.personalizedMessagePriceLabel.Text = "$2.50";
            this.personalizedMessagePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // personalizedMessageCheckBox
            // 
            this.personalizedMessageCheckBox.AutoSize = true;
            this.personalizedMessageCheckBox.Location = new System.Drawing.Point(13, 85);
            this.personalizedMessageCheckBox.Name = "personalizedMessageCheckBox";
            this.personalizedMessageCheckBox.Size = new System.Drawing.Size(132, 17);
            this.personalizedMessageCheckBox.TabIndex = 8;
            this.personalizedMessageCheckBox.Text = "Personalized Message";
            this.personalizedMessageCheckBox.UseVisualStyleBackColor = true;
            this.personalizedMessageCheckBox.CheckedChanged += new System.EventHandler(this.personalizedMessageCheckBox_CheckedChanged);
            // 
            // pottedPlantPriceLabel
            // 
            this.pottedPlantPriceLabel.AutoSize = true;
            this.pottedPlantPriceLabel.Location = new System.Drawing.Point(378, 128);
            this.pottedPlantPriceLabel.Name = "pottedPlantPriceLabel";
            this.pottedPlantPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.pottedPlantPriceLabel.TabIndex = 18;
            this.pottedPlantPriceLabel.Text = "$9.50";
            this.pottedPlantPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pottedPlantPriceLabel.Visible = false;
            // 
            // jarOfJellyBeansPriceLabel
            // 
            this.jarOfJellyBeansPriceLabel.AutoSize = true;
            this.jarOfJellyBeansPriceLabel.Location = new System.Drawing.Point(377, 115);
            this.jarOfJellyBeansPriceLabel.Name = "jarOfJellyBeansPriceLabel";
            this.jarOfJellyBeansPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.jarOfJellyBeansPriceLabel.TabIndex = 17;
            this.jarOfJellyBeansPriceLabel.Text = "$9.50";
            this.jarOfJellyBeansPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jarOfJellyBeansPriceLabel.Visible = false;
            // 
            // flowerArrangementPriceLabel
            // 
            this.flowerArrangementPriceLabel.AutoSize = true;
            this.flowerArrangementPriceLabel.Location = new System.Drawing.Point(377, 102);
            this.flowerArrangementPriceLabel.Name = "flowerArrangementPriceLabel";
            this.flowerArrangementPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.flowerArrangementPriceLabel.TabIndex = 16;
            this.flowerArrangementPriceLabel.Text = "$9.50";
            this.flowerArrangementPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowerArrangementPriceLabel.Visible = false;
            // 
            // coffeeMugPriceLabel
            // 
            this.coffeeMugPriceLabel.AutoSize = true;
            this.coffeeMugPriceLabel.Location = new System.Drawing.Point(377, 89);
            this.coffeeMugPriceLabel.Name = "coffeeMugPriceLabel";
            this.coffeeMugPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.coffeeMugPriceLabel.TabIndex = 15;
            this.coffeeMugPriceLabel.Text = "$9.50";
            this.coffeeMugPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coffeeMugPriceLabel.Visible = false;
            // 
            // boxOfChocolatesPriceLabel
            // 
            this.boxOfChocolatesPriceLabel.AutoSize = true;
            this.boxOfChocolatesPriceLabel.Location = new System.Drawing.Point(377, 76);
            this.boxOfChocolatesPriceLabel.Name = "boxOfChocolatesPriceLabel";
            this.boxOfChocolatesPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.boxOfChocolatesPriceLabel.TabIndex = 14;
            this.boxOfChocolatesPriceLabel.Text = "$9.50";
            this.boxOfChocolatesPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boxOfChocolatesPriceLabel.Visible = false;
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasLabel.Location = new System.Drawing.Point(296, 60);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(36, 13);
            this.extrasLabel.TabIndex = 13;
            this.extrasLabel.Text = "Extras\r\n";
            // 
            // extraListBox
            // 
            this.extraListBox.FormattingEnabled = true;
            this.extraListBox.Location = new System.Drawing.Point(254, 76);
            this.extraListBox.Name = "extraListBox";
            this.extraListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.extraListBox.Size = new System.Drawing.Size(120, 69);
            this.extraListBox.Sorted = true;
            this.extraListBox.TabIndex = 12;
            this.extraListBox.SelectedIndexChanged += new System.EventHandler(this.extraListBox_SelectedIndexChanged);
            // 
            // specialOccasionLabel
            // 
            this.specialOccasionLabel.AutoSize = true;
            this.specialOccasionLabel.Location = new System.Drawing.Point(10, 60);
            this.specialOccasionLabel.Name = "specialOccasionLabel";
            this.specialOccasionLabel.Size = new System.Drawing.Size(93, 13);
            this.specialOccasionLabel.TabIndex = 6;
            this.specialOccasionLabel.Text = "Special Occasion:";
            // 
            // specialOccasionComboBox
            // 
            this.specialOccasionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialOccasionComboBox.FormattingEnabled = true;
            this.specialOccasionComboBox.Location = new System.Drawing.Point(109, 57);
            this.specialOccasionComboBox.MaxDropDownItems = 7;
            this.specialOccasionComboBox.Name = "specialOccasionComboBox";
            this.specialOccasionComboBox.Size = new System.Drawing.Size(121, 21);
            this.specialOccasionComboBox.Sorted = true;
            this.specialOccasionComboBox.TabIndex = 7;
            // 
            // dozenPriceLabel
            // 
            this.dozenPriceLabel.AutoSize = true;
            this.dozenPriceLabel.Location = new System.Drawing.Point(372, 27);
            this.dozenPriceLabel.Name = "dozenPriceLabel";
            this.dozenPriceLabel.Size = new System.Drawing.Size(40, 13);
            this.dozenPriceLabel.TabIndex = 5;
            this.dozenPriceLabel.Text = "$65.95";
            // 
            // halfDozenPriceLabel
            // 
            this.halfDozenPriceLabel.AutoSize = true;
            this.halfDozenPriceLabel.Location = new System.Drawing.Point(236, 27);
            this.halfDozenPriceLabel.Name = "halfDozenPriceLabel";
            this.halfDozenPriceLabel.Size = new System.Drawing.Size(40, 13);
            this.halfDozenPriceLabel.TabIndex = 3;
            this.halfDozenPriceLabel.Text = "$35.95";
            // 
            // singlePriceLabel
            // 
            this.singlePriceLabel.AutoSize = true;
            this.singlePriceLabel.Location = new System.Drawing.Point(69, 27);
            this.singlePriceLabel.Name = "singlePriceLabel";
            this.singlePriceLabel.Size = new System.Drawing.Size(34, 13);
            this.singlePriceLabel.TabIndex = 1;
            this.singlePriceLabel.Text = "$9.95";
            // 
            // dozenRadioButton
            // 
            this.dozenRadioButton.AutoSize = true;
            this.dozenRadioButton.Location = new System.Drawing.Point(310, 23);
            this.dozenRadioButton.Name = "dozenRadioButton";
            this.dozenRadioButton.Size = new System.Drawing.Size(56, 17);
            this.dozenRadioButton.TabIndex = 4;
            this.dozenRadioButton.TabStop = true;
            this.dozenRadioButton.Text = "Dozen";
            this.dozenRadioButton.UseVisualStyleBackColor = true;
            this.dozenRadioButton.CheckedChanged += new System.EventHandler(this.dozenRadioButton_CheckedChanged);
            // 
            // halfDozenRadioButton
            // 
            this.halfDozenRadioButton.AutoSize = true;
            this.halfDozenRadioButton.Location = new System.Drawing.Point(152, 23);
            this.halfDozenRadioButton.Name = "halfDozenRadioButton";
            this.halfDozenRadioButton.Size = new System.Drawing.Size(78, 17);
            this.halfDozenRadioButton.TabIndex = 2;
            this.halfDozenRadioButton.TabStop = true;
            this.halfDozenRadioButton.Text = "Half-Dozen";
            this.halfDozenRadioButton.UseVisualStyleBackColor = true;
            this.halfDozenRadioButton.CheckedChanged += new System.EventHandler(this.halfDozenRadioButton_CheckedChanged);
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Checked = true;
            this.singleRadioButton.Location = new System.Drawing.Point(9, 23);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(54, 17);
            this.singleRadioButton.TabIndex = 0;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            this.singleRadioButton.CheckedChanged += new System.EventHandler(this.singleRadioButton_CheckedChanged);
            // 
            // orderTotalsGroupBox
            // 
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalOutputLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxOutputLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalOutputLabel);
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalLabel);
            this.orderTotalsGroupBox.Location = new System.Drawing.Point(13, 530);
            this.orderTotalsGroupBox.Name = "orderTotalsGroupBox";
            this.orderTotalsGroupBox.Size = new System.Drawing.Size(422, 54);
            this.orderTotalsGroupBox.TabIndex = 4;
            this.orderTotalsGroupBox.TabStop = false;
            this.orderTotalsGroupBox.Text = "Order Totals";
            // 
            // orderTotalOutputLabel
            // 
            this.orderTotalOutputLabel.AutoSize = true;
            this.orderTotalOutputLabel.Location = new System.Drawing.Point(372, 20);
            this.orderTotalOutputLabel.Name = "orderTotalOutputLabel";
            this.orderTotalOutputLabel.Size = new System.Drawing.Size(34, 13);
            this.orderTotalOutputLabel.TabIndex = 5;
            this.orderTotalOutputLabel.Text = "$0.00";
            this.orderTotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxOutputLabel
            // 
            this.salesTaxOutputLabel.AutoSize = true;
            this.salesTaxOutputLabel.Location = new System.Drawing.Point(235, 20);
            this.salesTaxOutputLabel.Name = "salesTaxOutputLabel";
            this.salesTaxOutputLabel.Size = new System.Drawing.Size(34, 13);
            this.salesTaxOutputLabel.TabIndex = 3;
            this.salesTaxOutputLabel.Text = "$0.00";
            this.salesTaxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.AutoSize = true;
            this.subtotalOutputLabel.Location = new System.Drawing.Point(69, 20);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(34, 13);
            this.subtotalOutputLabel.TabIndex = 1;
            this.subtotalOutputLabel.Text = "$0.00";
            this.subtotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(303, 20);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.orderTotalLabel.TabIndex = 4;
            this.orderTotalLabel.Text = "Order Total:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(165, 20);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(57, 13);
            this.salesTaxLabel.TabIndex = 2;
            this.salesTaxLabel.Text = "Sales Tax:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(14, 20);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // displayInformationToolTip
            // 
            this.displayInformationToolTip.ToolTipTitle = "Display Information";
            // 
            // clearToolTip
            // 
            this.clearToolTip.ToolTipTitle = "Clear";
            // 
            // exitToolTip
            // 
            this.exitToolTip.ToolTipTitle = "Exit";
            // 
            // BalloonOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 625);
            this.Controls.Add(this.orderTotalsGroupBox);
            this.Controls.Add(this.orderDetailsGroupBox);
            this.Controls.Add(this.deliveryInformationGroupBox);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displaySummaryButton);
            this.Name = "BalloonOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonnie\'s Balloons";
            this.Load += new System.EventHandler(this.BalloonOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.deliveryInformationGroupBox.ResumeLayout(false);
            this.deliveryInformationGroupBox.PerformLayout();
            this.orderDetailsGroupBox.ResumeLayout(false);
            this.orderDetailsGroupBox.PerformLayout();
            this.orderTotalsGroupBox.ResumeLayout(false);
            this.orderTotalsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displaySummaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.MaskedTextBox zipMaskedTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox deliveryInformationGroupBox;
        private System.Windows.Forms.Label storePickUpPriceLabel;
        private System.Windows.Forms.Label homeDeliveryPriceLabel;
        private System.Windows.Forms.RadioButton homeDeliveryRadioButton;
        private System.Windows.Forms.RadioButton storePickUpRadioButton;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox orderDetailsGroupBox;
        private System.Windows.Forms.Label dozenPriceLabel;
        private System.Windows.Forms.Label halfDozenPriceLabel;
        private System.Windows.Forms.Label singlePriceLabel;
        private System.Windows.Forms.RadioButton dozenRadioButton;
        private System.Windows.Forms.RadioButton halfDozenRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.Label characterLimitLabel;
        private System.Windows.Forms.TextBox personalizedMessageTextBox;
        private System.Windows.Forms.Label personalizedMessagePriceLabel;
        private System.Windows.Forms.CheckBox personalizedMessageCheckBox;
        private System.Windows.Forms.Label pottedPlantPriceLabel;
        private System.Windows.Forms.Label jarOfJellyBeansPriceLabel;
        private System.Windows.Forms.Label flowerArrangementPriceLabel;
        private System.Windows.Forms.Label coffeeMugPriceLabel;
        private System.Windows.Forms.Label boxOfChocolatesPriceLabel;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.ListBox extraListBox;
        private System.Windows.Forms.Label specialOccasionLabel;
        private System.Windows.Forms.ComboBox specialOccasionComboBox;
        private System.Windows.Forms.GroupBox orderTotalsGroupBox;
        private System.Windows.Forms.Label orderTotalOutputLabel;
        private System.Windows.Forms.Label salesTaxOutputLabel;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.ToolTip displayInformationToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}

