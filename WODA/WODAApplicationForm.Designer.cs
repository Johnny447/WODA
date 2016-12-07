namespace WODA
{
    partial class WODAApplicationForm
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
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.applicantDetailsGroup = new System.Windows.Forms.GroupBox();
            this.yourGenderLabel = new System.Windows.Forms.Label();
            this.yourGenderList = new System.Windows.Forms.ComboBox();
            this.theirGenderList = new System.Windows.Forms.ComboBox();
            this.theirGenderLabel = new System.Windows.Forms.Label();
            this.partnerDetailsGroup = new System.Windows.Forms.GroupBox();
            this.maximumAgeLabel = new System.Windows.Forms.Label();
            this.minimumAgeLabel = new System.Windows.Forms.Label();
            this.maximumAgeSpinner = new System.Windows.Forms.NumericUpDown();
            this.minimumAgeSpinner = new System.Windows.Forms.NumericUpDown();
            this.applyNowButton = new System.Windows.Forms.Button();
            this.applicantDetailsGroup.SuspendLayout();
            this.partnerDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumAgeSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumAgeSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(102, 35);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(142, 20);
            this.firstNameTextbox.TabIndex = 0;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(102, 75);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(141, 20);
            this.lastNameTextbox.TabIndex = 1;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(102, 115);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(142, 20);
            this.dateOfBirthPicker.TabIndex = 2;
            this.dateOfBirthPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 78);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(13, 118);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(66, 13);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // applicantDetailsGroup
            // 
            this.applicantDetailsGroup.Controls.Add(this.yourGenderLabel);
            this.applicantDetailsGroup.Controls.Add(this.yourGenderList);
            this.applicantDetailsGroup.Controls.Add(this.firstNameTextbox);
            this.applicantDetailsGroup.Controls.Add(this.dateOfBirthLabel);
            this.applicantDetailsGroup.Controls.Add(this.lastNameTextbox);
            this.applicantDetailsGroup.Controls.Add(this.lastNameLabel);
            this.applicantDetailsGroup.Controls.Add(this.dateOfBirthPicker);
            this.applicantDetailsGroup.Controls.Add(this.firstNameLabel);
            this.applicantDetailsGroup.Location = new System.Drawing.Point(12, 12);
            this.applicantDetailsGroup.Name = "applicantDetailsGroup";
            this.applicantDetailsGroup.Size = new System.Drawing.Size(260, 223);
            this.applicantDetailsGroup.TabIndex = 6;
            this.applicantDetailsGroup.TabStop = false;
            this.applicantDetailsGroup.Text = "Your Details";
            // 
            // yourGenderLabel
            // 
            this.yourGenderLabel.AutoSize = true;
            this.yourGenderLabel.Location = new System.Drawing.Point(16, 155);
            this.yourGenderLabel.Name = "yourGenderLabel";
            this.yourGenderLabel.Size = new System.Drawing.Size(67, 13);
            this.yourGenderLabel.TabIndex = 9;
            this.yourGenderLabel.Text = "Your Gender";
            // 
            // yourGenderList
            // 
            this.yourGenderList.FormattingEnabled = true;
            this.yourGenderList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.yourGenderList.Location = new System.Drawing.Point(102, 155);
            this.yourGenderList.Name = "yourGenderList";
            this.yourGenderList.Size = new System.Drawing.Size(142, 21);
            this.yourGenderList.TabIndex = 7;
            // 
            // theirGenderList
            // 
            this.theirGenderList.FormattingEnabled = true;
            this.theirGenderList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.theirGenderList.Location = new System.Drawing.Point(98, 37);
            this.theirGenderList.Name = "theirGenderList";
            this.theirGenderList.Size = new System.Drawing.Size(142, 21);
            this.theirGenderList.TabIndex = 8;
            // 
            // theirGenderLabel
            // 
            this.theirGenderLabel.AutoSize = true;
            this.theirGenderLabel.Location = new System.Drawing.Point(15, 37);
            this.theirGenderLabel.Name = "theirGenderLabel";
            this.theirGenderLabel.Size = new System.Drawing.Size(69, 13);
            this.theirGenderLabel.TabIndex = 10;
            this.theirGenderLabel.Text = "Their Gender";
            // 
            // partnerDetailsGroup
            // 
            this.partnerDetailsGroup.Controls.Add(this.maximumAgeLabel);
            this.partnerDetailsGroup.Controls.Add(this.minimumAgeLabel);
            this.partnerDetailsGroup.Controls.Add(this.maximumAgeSpinner);
            this.partnerDetailsGroup.Controls.Add(this.minimumAgeSpinner);
            this.partnerDetailsGroup.Controls.Add(this.theirGenderLabel);
            this.partnerDetailsGroup.Controls.Add(this.theirGenderList);
            this.partnerDetailsGroup.Location = new System.Drawing.Point(279, 13);
            this.partnerDetailsGroup.Name = "partnerDetailsGroup";
            this.partnerDetailsGroup.Size = new System.Drawing.Size(257, 222);
            this.partnerDetailsGroup.TabIndex = 7;
            this.partnerDetailsGroup.TabStop = false;
            this.partnerDetailsGroup.Text = "Partner Details";
            // 
            // maximumAgeLabel
            // 
            this.maximumAgeLabel.AutoSize = true;
            this.maximumAgeLabel.Location = new System.Drawing.Point(18, 114);
            this.maximumAgeLabel.Name = "maximumAgeLabel";
            this.maximumAgeLabel.Size = new System.Drawing.Size(73, 13);
            this.maximumAgeLabel.TabIndex = 14;
            this.maximumAgeLabel.Text = "Maximum Age";
            // 
            // minimumAgeLabel
            // 
            this.minimumAgeLabel.AutoSize = true;
            this.minimumAgeLabel.Location = new System.Drawing.Point(18, 75);
            this.minimumAgeLabel.Name = "minimumAgeLabel";
            this.minimumAgeLabel.Size = new System.Drawing.Size(70, 13);
            this.minimumAgeLabel.TabIndex = 13;
            this.minimumAgeLabel.Text = "Minimum Age";
            // 
            // maximumAgeSpinner
            // 
            this.maximumAgeSpinner.Location = new System.Drawing.Point(98, 114);
            this.maximumAgeSpinner.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.maximumAgeSpinner.Name = "maximumAgeSpinner";
            this.maximumAgeSpinner.Size = new System.Drawing.Size(72, 20);
            this.maximumAgeSpinner.TabIndex = 12;
            this.maximumAgeSpinner.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // minimumAgeSpinner
            // 
            this.minimumAgeSpinner.Location = new System.Drawing.Point(98, 75);
            this.minimumAgeSpinner.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.minimumAgeSpinner.Name = "minimumAgeSpinner";
            this.minimumAgeSpinner.Size = new System.Drawing.Size(72, 20);
            this.minimumAgeSpinner.TabIndex = 11;
            this.minimumAgeSpinner.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // applyNowButton
            // 
            this.applyNowButton.Location = new System.Drawing.Point(424, 252);
            this.applyNowButton.Name = "applyNowButton";
            this.applyNowButton.Size = new System.Drawing.Size(75, 23);
            this.applyNowButton.TabIndex = 8;
            this.applyNowButton.Text = "Apply Now";
            this.applyNowButton.UseVisualStyleBackColor = true;
            // 
            // WODAApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 301);
            this.Controls.Add(this.applyNowButton);
            this.Controls.Add(this.partnerDetailsGroup);
            this.Controls.Add(this.applicantDetailsGroup);
            this.Name = "WODAApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to WODA";
            this.Load += new System.EventHandler(this.WODAApplicationForm_Load);
            this.applicantDetailsGroup.ResumeLayout(false);
            this.applicantDetailsGroup.PerformLayout();
            this.partnerDetailsGroup.ResumeLayout(false);
            this.partnerDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumAgeSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumAgeSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.GroupBox applicantDetailsGroup;
        private System.Windows.Forms.Label yourGenderLabel;
        private System.Windows.Forms.ComboBox yourGenderList;
        private System.Windows.Forms.ComboBox theirGenderList;
        private System.Windows.Forms.Label theirGenderLabel;
        private System.Windows.Forms.GroupBox partnerDetailsGroup;
        private System.Windows.Forms.Label maximumAgeLabel;
        private System.Windows.Forms.Label minimumAgeLabel;
        private System.Windows.Forms.NumericUpDown maximumAgeSpinner;
        private System.Windows.Forms.NumericUpDown minimumAgeSpinner;
        private System.Windows.Forms.Button applyNowButton;
    }
}

