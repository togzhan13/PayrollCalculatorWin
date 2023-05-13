namespace A4_TogzhanTolegen
{
    partial class Form1
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
            this.lblHealthInsuraceRate = new System.Windows.Forms.Label();
            this.lblTaxWithholdRate = new System.Windows.Forms.Label();
            this.lblRetirementContributionRate = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.biWeeklyTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblBiweekly = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dispHrl1 = new System.Windows.Forms.Label();
            this.lblDispPayStub = new System.Windows.Forms.Label();
            this.dispHrl2 = new System.Windows.Forms.Label();
            this.lblDispEmpName = new System.Windows.Forms.Label();
            this.lblDispBiweekly = new System.Windows.Forms.Label();
            this.lblDispPayRate = new System.Windows.Forms.Label();
            this.dispHrl3 = new System.Windows.Forms.Label();
            this.lblDispGrossPay = new System.Windows.Forms.Label();
            this.lblDispHealthInsurance = new System.Windows.Forms.Label();
            this.lblDispTaxWithhold = new System.Windows.Forms.Label();
            this.lblDispRetirementContribution = new System.Windows.Forms.Label();
            this.dispHrl4 = new System.Windows.Forms.Label();
            this.lblDispNetPay = new System.Windows.Forms.Label();
            this.dispHrl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHealthInsuraceRate
            // 
            this.lblHealthInsuraceRate.AutoSize = true;
            this.lblHealthInsuraceRate.Location = new System.Drawing.Point(536, 52);
            this.lblHealthInsuraceRate.Name = "lblHealthInsuraceRate";
            this.lblHealthInsuraceRate.Size = new System.Drawing.Size(35, 13);
            this.lblHealthInsuraceRate.TabIndex = 0;
            this.lblHealthInsuraceRate.Text = "label1";
            this.lblHealthInsuraceRate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTaxWithholdRate
            // 
            this.lblTaxWithholdRate.AutoSize = true;
            this.lblTaxWithholdRate.Location = new System.Drawing.Point(536, 85);
            this.lblTaxWithholdRate.Name = "lblTaxWithholdRate";
            this.lblTaxWithholdRate.Size = new System.Drawing.Size(35, 13);
            this.lblTaxWithholdRate.TabIndex = 1;
            this.lblTaxWithholdRate.Text = "label2";
            // 
            // lblRetirementContributionRate
            // 
            this.lblRetirementContributionRate.AutoSize = true;
            this.lblRetirementContributionRate.Location = new System.Drawing.Point(536, 115);
            this.lblRetirementContributionRate.Name = "lblRetirementContributionRate";
            this.lblRetirementContributionRate.Size = new System.Drawing.Size(35, 13);
            this.lblRetirementContributionRate.TabIndex = 2;
            this.lblRetirementContributionRate.Text = "label3";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(536, 145);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(35, 13);
            this.lblGrossPay.TabIndex = 3;
            this.lblGrossPay.Text = "label4";
            this.lblGrossPay.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(395, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(108, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Compute Salary";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(395, 110);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(108, 23);
            this.displayButton.TabIndex = 6;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Visible = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(395, 140);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(210, 50);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.Visible = false;
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(258, 143);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(131, 20);
            this.payRateTextBox.TabIndex = 9;
            this.payRateTextBox.Visible = false;
            // 
            // biWeeklyTextBox
            // 
            this.biWeeklyTextBox.Location = new System.Drawing.Point(258, 113);
            this.biWeeklyTextBox.Name = "biWeeklyTextBox";
            this.biWeeklyTextBox.Size = new System.Drawing.Size(131, 20);
            this.biWeeklyTextBox.TabIndex = 10;
            this.biWeeklyTextBox.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(210, 83);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.firstNameTextBox.TabIndex = 11;
            this.firstNameTextBox.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(54, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(145, 13);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Enter Employee\'s Last Name:";
            this.lblLastName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(54, 85);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(144, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "Enter Employee\'s First Name:";
            this.lblFirstName.Visible = false;
            // 
            // lblBiweekly
            // 
            this.lblBiweekly.AutoSize = true;
            this.lblBiweekly.Location = new System.Drawing.Point(54, 115);
            this.lblBiweekly.Name = "lblBiweekly";
            this.lblBiweekly.Size = new System.Drawing.Size(167, 13);
            this.lblBiweekly.TabIndex = 14;
            this.lblBiweekly.Text = "Enter Employee\'s Biweekly Hours:";
            this.lblBiweekly.Visible = false;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(54, 145);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(138, 13);
            this.lblPayRate.TabIndex = 15;
            this.lblPayRate.Text = "Enter Employee\'s Pay Rate:";
            this.lblPayRate.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(392, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "label9";
            // 
            // dispHrl1
            // 
            this.dispHrl1.AutoSize = true;
            this.dispHrl1.Location = new System.Drawing.Point(54, 184);
            this.dispHrl1.Name = "dispHrl1";
            this.dispHrl1.Size = new System.Drawing.Size(41, 13);
            this.dispHrl1.TabIndex = 17;
            this.dispHrl1.Text = "label10";
            this.dispHrl1.Visible = false;
            // 
            // lblDispPayStub
            // 
            this.lblDispPayStub.AutoSize = true;
            this.lblDispPayStub.Location = new System.Drawing.Point(54, 197);
            this.lblDispPayStub.Name = "lblDispPayStub";
            this.lblDispPayStub.Size = new System.Drawing.Size(41, 13);
            this.lblDispPayStub.TabIndex = 18;
            this.lblDispPayStub.Text = "label11";
            this.lblDispPayStub.Visible = false;
            // 
            // dispHrl2
            // 
            this.dispHrl2.AutoSize = true;
            this.dispHrl2.Location = new System.Drawing.Point(54, 210);
            this.dispHrl2.Name = "dispHrl2";
            this.dispHrl2.Size = new System.Drawing.Size(41, 13);
            this.dispHrl2.TabIndex = 19;
            this.dispHrl2.Text = "label12";
            this.dispHrl2.Visible = false;
            // 
            // lblDispEmpName
            // 
            this.lblDispEmpName.AutoSize = true;
            this.lblDispEmpName.Location = new System.Drawing.Point(54, 235);
            this.lblDispEmpName.Name = "lblDispEmpName";
            this.lblDispEmpName.Size = new System.Drawing.Size(41, 13);
            this.lblDispEmpName.TabIndex = 20;
            this.lblDispEmpName.Text = "label13";
            this.lblDispEmpName.Visible = false;
            // 
            // lblDispBiweekly
            // 
            this.lblDispBiweekly.AutoSize = true;
            this.lblDispBiweekly.Location = new System.Drawing.Point(54, 251);
            this.lblDispBiweekly.Name = "lblDispBiweekly";
            this.lblDispBiweekly.Size = new System.Drawing.Size(41, 13);
            this.lblDispBiweekly.TabIndex = 21;
            this.lblDispBiweekly.Text = "label14";
            this.lblDispBiweekly.Visible = false;
            // 
            // lblDispPayRate
            // 
            this.lblDispPayRate.AutoSize = true;
            this.lblDispPayRate.Location = new System.Drawing.Point(55, 272);
            this.lblDispPayRate.Name = "lblDispPayRate";
            this.lblDispPayRate.Size = new System.Drawing.Size(41, 13);
            this.lblDispPayRate.TabIndex = 22;
            this.lblDispPayRate.Text = "label15";
            this.lblDispPayRate.Visible = false;
            // 
            // dispHrl3
            // 
            this.dispHrl3.AutoSize = true;
            this.dispHrl3.Location = new System.Drawing.Point(54, 296);
            this.dispHrl3.Name = "dispHrl3";
            this.dispHrl3.Size = new System.Drawing.Size(41, 13);
            this.dispHrl3.TabIndex = 23;
            this.dispHrl3.Text = "label16";
            this.dispHrl3.Visible = false;
            // 
            // lblDispGrossPay
            // 
            this.lblDispGrossPay.AutoSize = true;
            this.lblDispGrossPay.Location = new System.Drawing.Point(54, 312);
            this.lblDispGrossPay.Name = "lblDispGrossPay";
            this.lblDispGrossPay.Size = new System.Drawing.Size(41, 13);
            this.lblDispGrossPay.TabIndex = 24;
            this.lblDispGrossPay.Text = "label17";
            this.lblDispGrossPay.Visible = false;
            // 
            // lblDispHealthInsurance
            // 
            this.lblDispHealthInsurance.AutoSize = true;
            this.lblDispHealthInsurance.Location = new System.Drawing.Point(54, 325);
            this.lblDispHealthInsurance.Name = "lblDispHealthInsurance";
            this.lblDispHealthInsurance.Size = new System.Drawing.Size(41, 13);
            this.lblDispHealthInsurance.TabIndex = 25;
            this.lblDispHealthInsurance.Text = "label18";
            this.lblDispHealthInsurance.Visible = false;
            // 
            // lblDispTaxWithhold
            // 
            this.lblDispTaxWithhold.AutoSize = true;
            this.lblDispTaxWithhold.Location = new System.Drawing.Point(55, 338);
            this.lblDispTaxWithhold.Name = "lblDispTaxWithhold";
            this.lblDispTaxWithhold.Size = new System.Drawing.Size(41, 13);
            this.lblDispTaxWithhold.TabIndex = 26;
            this.lblDispTaxWithhold.Text = "label19";
            this.lblDispTaxWithhold.Visible = false;
            // 
            // lblDispRetirementContribution
            // 
            this.lblDispRetirementContribution.AutoSize = true;
            this.lblDispRetirementContribution.Location = new System.Drawing.Point(55, 351);
            this.lblDispRetirementContribution.Name = "lblDispRetirementContribution";
            this.lblDispRetirementContribution.Size = new System.Drawing.Size(41, 13);
            this.lblDispRetirementContribution.TabIndex = 27;
            this.lblDispRetirementContribution.Text = "label20";
            this.lblDispRetirementContribution.Visible = false;
            // 
            // dispHrl4
            // 
            this.dispHrl4.AutoSize = true;
            this.dispHrl4.Location = new System.Drawing.Point(54, 374);
            this.dispHrl4.Name = "dispHrl4";
            this.dispHrl4.Size = new System.Drawing.Size(41, 13);
            this.dispHrl4.TabIndex = 28;
            this.dispHrl4.Text = "label21";
            this.dispHrl4.Visible = false;
            // 
            // lblDispNetPay
            // 
            this.lblDispNetPay.AutoSize = true;
            this.lblDispNetPay.Location = new System.Drawing.Point(54, 396);
            this.lblDispNetPay.Name = "lblDispNetPay";
            this.lblDispNetPay.Size = new System.Drawing.Size(41, 13);
            this.lblDispNetPay.TabIndex = 29;
            this.lblDispNetPay.Text = "label22";
            this.lblDispNetPay.Visible = false;
            // 
            // dispHrl5
            // 
            this.dispHrl5.AutoSize = true;
            this.dispHrl5.Location = new System.Drawing.Point(54, 425);
            this.dispHrl5.Name = "dispHrl5";
            this.dispHrl5.Size = new System.Drawing.Size(41, 13);
            this.dispHrl5.TabIndex = 30;
            this.dispHrl5.Text = "label23";
            this.dispHrl5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.dispHrl5);
            this.Controls.Add(this.lblDispNetPay);
            this.Controls.Add(this.dispHrl4);
            this.Controls.Add(this.lblDispRetirementContribution);
            this.Controls.Add(this.lblDispTaxWithhold);
            this.Controls.Add(this.lblDispHealthInsurance);
            this.Controls.Add(this.lblDispGrossPay);
            this.Controls.Add(this.dispHrl3);
            this.Controls.Add(this.lblDispPayRate);
            this.Controls.Add(this.lblDispBiweekly);
            this.Controls.Add(this.lblDispEmpName);
            this.Controls.Add(this.dispHrl2);
            this.Controls.Add(this.lblDispPayStub);
            this.Controls.Add(this.dispHrl1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblBiweekly);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.biWeeklyTextBox);
            this.Controls.Add(this.payRateTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblRetirementContributionRate);
            this.Controls.Add(this.lblTaxWithholdRate);
            this.Controls.Add(this.lblHealthInsuraceRate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHealthInsuraceRate;
        private System.Windows.Forms.Label lblTaxWithholdRate;
        private System.Windows.Forms.Label lblRetirementContributionRate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.TextBox biWeeklyTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblBiweekly;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label dispHrl1;
        private System.Windows.Forms.Label lblDispPayStub;
        private System.Windows.Forms.Label dispHrl2;
        private System.Windows.Forms.Label lblDispEmpName;
        private System.Windows.Forms.Label lblDispBiweekly;
        private System.Windows.Forms.Label lblDispPayRate;
        private System.Windows.Forms.Label dispHrl3;
        private System.Windows.Forms.Label lblDispGrossPay;
        private System.Windows.Forms.Label lblDispHealthInsurance;
        private System.Windows.Forms.Label lblDispTaxWithhold;
        private System.Windows.Forms.Label lblDispRetirementContribution;
        private System.Windows.Forms.Label dispHrl4;
        private System.Windows.Forms.Label lblDispNetPay;
        private System.Windows.Forms.Label dispHrl5;
    }
}

