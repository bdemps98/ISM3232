using System.Windows.Forms;

namespace Dempsey_1
{
    partial class motorwayMotelForm
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
            this.motorwayMotelHeader = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.guestInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.rateCharged = new System.Windows.Forms.MaskedTextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.nightsStayed = new System.Windows.Forms.MaskedTextBox();
            this.nightsLabel = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.MaskedTextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.miniBarLabel = new System.Windows.Forms.Label();
            this.telephoneChargesLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.miniBarCharges = new System.Windows.Forms.MaskedTextBox();
            this.telephoneCharges = new System.Windows.Forms.MaskedTextBox();
            this.miscCharges = new System.Windows.Forms.MaskedTextBox();
            this.additionalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.billingSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.additionalCharges = new System.Windows.Forms.Label();
            this.roomCharges = new System.Windows.Forms.Label();
            this.totalBarLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.additionalChargesLabel = new System.Windows.Forms.Label();
            this.roomChargesLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.motorwayMotelHeader)).BeginInit();
            this.guestInformationGroupBox.SuspendLayout();
            this.additionalChargesGroupBox.SuspendLayout();
            this.billingSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorwayMotelHeader
            // 
            this.motorwayMotelHeader.Image = global::Dempsey_1.Properties.Resources.Motorway_Motel;
            this.motorwayMotelHeader.Location = new System.Drawing.Point(12, 12);
            this.motorwayMotelHeader.Name = "motorwayMotelHeader";
            this.motorwayMotelHeader.Size = new System.Drawing.Size(871, 108);
            this.motorwayMotelHeader.TabIndex = 0;
            this.motorwayMotelHeader.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.headerLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerLabel.Location = new System.Drawing.Point(322, 123);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(251, 32);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Motorway Motel";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(395, 162);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(434, 159);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(67, 20);
            this.date.TabIndex = 0;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // guestInformationGroupBox
            // 
            this.guestInformationGroupBox.Controls.Add(this.rateCharged);
            this.guestInformationGroupBox.Controls.Add(this.rateLabel);
            this.guestInformationGroupBox.Controls.Add(this.nightsStayed);
            this.guestInformationGroupBox.Controls.Add(this.nightsLabel);
            this.guestInformationGroupBox.Controls.Add(this.roomNumber);
            this.guestInformationGroupBox.Controls.Add(this.roomNumberLabel);
            this.guestInformationGroupBox.Controls.Add(this.lastName);
            this.guestInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.guestInformationGroupBox.Controls.Add(this.firstName);
            this.guestInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.guestInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestInformationGroupBox.Location = new System.Drawing.Point(12, 200);
            this.guestInformationGroupBox.Name = "guestInformationGroupBox";
            this.guestInformationGroupBox.Size = new System.Drawing.Size(416, 79);
            this.guestInformationGroupBox.TabIndex = 4;
            this.guestInformationGroupBox.TabStop = false;
            this.guestInformationGroupBox.Text = "Guest Information";
            // 
            // rateCharged
            // 
            this.rateCharged.Location = new System.Drawing.Point(310, 50);
            this.rateCharged.Mask = "000.00";
            this.rateCharged.Name = "rateCharged";
            this.rateCharged.Size = new System.Drawing.Size(45, 20);
            this.rateCharged.TabIndex = 4;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(271, 53);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(33, 13);
            this.rateLabel.TabIndex = 8;
            this.rateLabel.Text = "Rate:";
            // 
            // nightsStayed
            // 
            this.nightsStayed.Location = new System.Drawing.Point(239, 50);
            this.nightsStayed.Mask = "00";
            this.nightsStayed.Name = "nightsStayed";
            this.nightsStayed.Size = new System.Drawing.Size(26, 20);
            this.nightsStayed.TabIndex = 3;
            // 
            // nightsLabel
            // 
            this.nightsLabel.AutoSize = true;
            this.nightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightsLabel.Location = new System.Drawing.Point(190, 53);
            this.nightsLabel.Name = "nightsLabel";
            this.nightsLabel.Size = new System.Drawing.Size(43, 13);
            this.nightsLabel.TabIndex = 6;
            this.nightsLabel.Text = "Nights: ";
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(274, 19);
            this.roomNumber.Mask = "000";
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(25, 20);
            this.roomNumber.TabIndex = 2;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(190, 22);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.roomNumberLabel.TabIndex = 4;
            this.roomNumberLabel.Text = "Room Number:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(73, 50);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(7, 53);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(73, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(7, 23);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // miniBarLabel
            // 
            this.miniBarLabel.AutoSize = true;
            this.miniBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBarLabel.Location = new System.Drawing.Point(19, 53);
            this.miniBarLabel.Name = "miniBarLabel";
            this.miniBarLabel.Size = new System.Drawing.Size(48, 13);
            this.miniBarLabel.TabIndex = 10;
            this.miniBarLabel.Text = "Mini Bar:";
            // 
            // telephoneChargesLabel
            // 
            this.telephoneChargesLabel.AutoSize = true;
            this.telephoneChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneChargesLabel.Location = new System.Drawing.Point(7, 26);
            this.telephoneChargesLabel.Name = "telephoneChargesLabel";
            this.telephoneChargesLabel.Size = new System.Drawing.Size(61, 13);
            this.telephoneChargesLabel.TabIndex = 11;
            this.telephoneChargesLabel.Text = "Telephone:";
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscChargesLabel.Location = new System.Drawing.Point(190, 26);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(80, 13);
            this.miscChargesLabel.TabIndex = 12;
            this.miscChargesLabel.Text = "Miscellaneous: ";
            // 
            // miniBarCharges
            // 
            this.miniBarCharges.Location = new System.Drawing.Point(73, 50);
            this.miniBarCharges.Mask = "0000.00";
            this.miniBarCharges.Name = "miniBarCharges";
            this.miniBarCharges.Size = new System.Drawing.Size(55, 20);
            this.miniBarCharges.TabIndex = 2;
            // 
            // telephoneCharges
            // 
            this.telephoneCharges.Location = new System.Drawing.Point(73, 19);
            this.telephoneCharges.Mask = "0000.00";
            this.telephoneCharges.Name = "telephoneCharges";
            this.telephoneCharges.Size = new System.Drawing.Size(55, 20);
            this.telephoneCharges.TabIndex = 1;
            // 
            // miscCharges
            // 
            this.miscCharges.Location = new System.Drawing.Point(274, 23);
            this.miscCharges.Mask = "0000.00";
            this.miscCharges.Name = "miscCharges";
            this.miscCharges.Size = new System.Drawing.Size(53, 20);
            this.miscCharges.TabIndex = 3;
            // 
            // additionalChargesGroupBox
            // 
            this.additionalChargesGroupBox.Controls.Add(this.miscCharges);
            this.additionalChargesGroupBox.Controls.Add(this.miscChargesLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarCharges);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneChargesLabel);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneCharges);
            this.additionalChargesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalChargesGroupBox.Location = new System.Drawing.Point(12, 285);
            this.additionalChargesGroupBox.Name = "additionalChargesGroupBox";
            this.additionalChargesGroupBox.Size = new System.Drawing.Size(416, 78);
            this.additionalChargesGroupBox.TabIndex = 5;
            this.additionalChargesGroupBox.TabStop = false;
            this.additionalChargesGroupBox.Text = "Additional Charges";
            // 
            // billingSummaryGroupBox
            // 
            this.billingSummaryGroupBox.Controls.Add(this.total);
            this.billingSummaryGroupBox.Controls.Add(this.tax);
            this.billingSummaryGroupBox.Controls.Add(this.subtotal);
            this.billingSummaryGroupBox.Controls.Add(this.additionalCharges);
            this.billingSummaryGroupBox.Controls.Add(this.roomCharges);
            this.billingSummaryGroupBox.Controls.Add(this.totalBarLabel);
            this.billingSummaryGroupBox.Controls.Add(this.totalLabel);
            this.billingSummaryGroupBox.Controls.Add(this.taxLabel);
            this.billingSummaryGroupBox.Controls.Add(this.subtotalLabel);
            this.billingSummaryGroupBox.Controls.Add(this.additionalChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.roomChargesLabel);
            this.billingSummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingSummaryGroupBox.Location = new System.Drawing.Point(435, 200);
            this.billingSummaryGroupBox.Name = "billingSummaryGroupBox";
            this.billingSummaryGroupBox.Size = new System.Drawing.Size(290, 163);
            this.billingSummaryGroupBox.TabIndex = 6;
            this.billingSummaryGroupBox.TabStop = false;
            this.billingSummaryGroupBox.Text = "Billing Summary";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(111, 135);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 10;
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(111, 94);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(0, 13);
            this.tax.TabIndex = 9;
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(111, 66);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(0, 13);
            this.subtotal.TabIndex = 8;
            // 
            // additionalCharges
            // 
            this.additionalCharges.AutoSize = true;
            this.additionalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalCharges.Location = new System.Drawing.Point(111, 40);
            this.additionalCharges.Name = "additionalCharges";
            this.additionalCharges.Size = new System.Drawing.Size(0, 13);
            this.additionalCharges.TabIndex = 7;
            // 
            // roomCharges
            // 
            this.roomCharges.AutoSize = true;
            this.roomCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCharges.Location = new System.Drawing.Point(111, 16);
            this.roomCharges.Name = "roomCharges";
            this.roomCharges.Size = new System.Drawing.Size(0, 13);
            this.roomCharges.TabIndex = 6;
            // 
            // totalBarLabel
            // 
            this.totalBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalBarLabel.Location = new System.Drawing.Point(0, 118);
            this.totalBarLabel.Name = "totalBarLabel";
            this.totalBarLabel.Size = new System.Drawing.Size(296, 3);
            this.totalBarLabel.TabIndex = 5;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(7, 135);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(7, 94);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "Tax:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(7, 66);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 2;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // additionalChargesLabel
            // 
            this.additionalChargesLabel.AutoSize = true;
            this.additionalChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalChargesLabel.Location = new System.Drawing.Point(7, 40);
            this.additionalChargesLabel.Name = "additionalChargesLabel";
            this.additionalChargesLabel.Size = new System.Drawing.Size(98, 13);
            this.additionalChargesLabel.TabIndex = 1;
            this.additionalChargesLabel.Text = "Additional Charges:";
            // 
            // roomChargesLabel
            // 
            this.roomChargesLabel.AutoSize = true;
            this.roomChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomChargesLabel.Location = new System.Drawing.Point(7, 16);
            this.roomChargesLabel.Name = "roomChargesLabel";
            this.roomChargesLabel.Size = new System.Drawing.Size(80, 13);
            this.roomChargesLabel.TabIndex = 0;
            this.roomChargesLabel.Text = "Room Charges:";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(731, 207);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(152, 29);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(731, 250);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(152, 29);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(731, 292);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(152, 29);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(731, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 29);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // motorwayMotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 370);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.billingSummaryGroupBox);
            this.Controls.Add(this.additionalChargesGroupBox);
            this.Controls.Add(this.guestInformationGroupBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.motorwayMotelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "motorwayMotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorway Motel";
            ((System.ComponentModel.ISupportInitialize)(this.motorwayMotelHeader)).EndInit();
            this.guestInformationGroupBox.ResumeLayout(false);
            this.guestInformationGroupBox.PerformLayout();
            this.additionalChargesGroupBox.ResumeLayout(false);
            this.additionalChargesGroupBox.PerformLayout();
            this.billingSummaryGroupBox.ResumeLayout(false);
            this.billingSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox motorwayMotelHeader;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.GroupBox guestInformationGroupBox;
        private System.Windows.Forms.MaskedTextBox rateCharged;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.MaskedTextBox nightsStayed;
        private System.Windows.Forms.Label nightsLabel;
        private System.Windows.Forms.MaskedTextBox roomNumber;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label miniBarLabel;
        private System.Windows.Forms.Label telephoneChargesLabel;
        private System.Windows.Forms.Label miscChargesLabel;
        private System.Windows.Forms.MaskedTextBox miniBarCharges;
        private System.Windows.Forms.MaskedTextBox telephoneCharges;
        private System.Windows.Forms.MaskedTextBox miscCharges;
        private System.Windows.Forms.GroupBox additionalChargesGroupBox;
        private System.Windows.Forms.GroupBox billingSummaryGroupBox;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label additionalCharges;
        private System.Windows.Forms.Label roomCharges;
        private System.Windows.Forms.Label totalLabel;
        private Label totalBarLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label additionalChargesLabel;
        private System.Windows.Forms.Label roomChargesLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}

