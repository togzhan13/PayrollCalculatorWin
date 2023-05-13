using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4_TogzhanTolegen
{
    public partial class Form1 : Form
    {
        //Decalring variables
        static double healthInsuranceRate = 0.06;
        static double taxWithholdRate = 0.15;
        static double retirementContributionRate = 0.12;
        static string lastName;
        static string firstName;
        static double biWeeklyWorkingHours;
        static double payRate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assigning values to labels
            lblTitle.Text = "Display Pay Stub";
            lblHealthInsuraceRate.Text = "Health Insurance Rate: " + (healthInsuranceRate).ToString("P0");
            lblTaxWithholdRate.Text = "Tax Withhold Rate: " + (taxWithholdRate).ToString("P0");
            lblRetirementContributionRate.Text = "Retirement Contribution Rate: " + (retirementContributionRate).ToString("P0");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Rendering label visibility as true
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblBiweekly.Visible = true;
            lblPayRate.Visible = true;
            firstNameTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            biWeeklyTextBox.Visible = true;
            payRateTextBox.Visible = true;
            button1.Visible = false;
            calculateButton.Visible = true;
        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            //Get information from user
            lastName = lastNameTextBox.Text;
            firstName = firstNameTextBox.Text;
            biWeeklyWorkingHours = Convert.ToDouble(biWeeklyTextBox.Text);
            payRate = Convert.ToDouble(payRateTextBox.Text);
            lblGrossPay.Visible = true;
            lblGrossPay.Text = "Gross pay for " + firstName + " " + lastName + " is " + (biWeeklyWorkingHours * payRate).ToString("C");
            calculateButton.Visible = false;
            displayButton.Visible = true;
            lblBiweekly.Text = firstName + ", " + lastName + "'s Biweekly Work Hours: ";
            lblPayRate.Text = firstName + ", " + lastName + "'s Pay Rate: ";
        }

        private void displayButton_Click_1(object sender, EventArgs e)
        {
            //Pay Stub Calculation and Display
            displayButton.Visible = false;
            resetButton.Visible = true;
            double biWeeklyGrossPay = biWeeklyWorkingHours * payRate;
            double healthInsuranceFee = biWeeklyGrossPay * (healthInsuranceRate);
            double taxWithholdAmount = biWeeklyGrossPay * (taxWithholdRate);
            double retirementContribution = biWeeklyGrossPay * (retirementContributionRate);
            double biWeeklyNetPay = biWeeklyGrossPay - (healthInsuranceFee + taxWithholdAmount + retirementContribution);
            dispHrl1.Visible = true; lblDispPayStub.Visible = true; dispHrl2.Visible = true;
            dispHrl1.Text = new string('*',170); dispHrl2.Text = new string('*', 170); dispHrl3.Text = new string('*', 170); dispHrl4.Text = new string('*', 170); dispHrl5.Text = new string('*', 170);
            lblDispPayStub.Text = string.Format("{0,110}","Pay Stub");
            lblDispEmpName.Visible = true; lblDispEmpName.Text = string.Format("*{0,51}Employee Name: {1,-85}*{2,47}*", "", (firstName + " " + lastName), "");
            lblDispBiweekly.Visible = true; lblDispBiweekly.Text = string.Format("*{0,37}Bi-weekly Working Hours: {1,87}{2,55}*", "", "*", biWeeklyWorkingHours);
            lblDispPayRate.Visible = true; lblDispPayRate.Text = string.Format("*{0,61}Pay Rate: {1,87}{2,53}{3:C}*", "", "*", "X ", payRate);
            dispHrl3.Visible = true;
            lblDispGrossPay.Visible = true; lblDispGrossPay.Text = string.Format("*{0,140}Gross Pay: {1,39:C}*", "", biWeeklyGrossPay);
            lblDispHealthInsurance.Visible = true; lblDispHealthInsurance.Text = string.Format("*{0,49}Health Insurance: {1,90}{2,40}{3:C}*", "", "*", "- ", healthInsuranceFee);
            lblDispTaxWithhold.Visible = true; lblDispTaxWithhold.Text = string.Format("*{0,55}Tax Withhold: {1,87}{2,54}{3:C}*", "", "*", "- ", taxWithholdAmount);
            lblDispRetirementContribution.Visible = true; lblDispRetirementContribution.Text = string.Format("*{0,39}Retirement Contribution: {1,87}{2,17}{3:C}*", "", "*", "- ", retirementContribution);
            dispHrl4.Visible = true;
            lblDispNetPay.Visible = true; lblDispNetPay.Text = string.Format("*{0,140}Net Pay: {1,28:C}*", "", biWeeklyNetPay);
            dispHrl5.Visible = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Rendering the visibility and button value as false
            resetButton.Visible = false;
            button1.Visible = true;
            dispHrl1.Visible = false; dispHrl2.Visible = false; dispHrl3.Visible = false; dispHrl4.Visible = false; dispHrl5.Visible = false;
            lblDispPayStub.Visible = false;
            lblDispEmpName.Visible = false; lblDispBiweekly.Visible = false; lblDispPayRate.Visible = false;
            lblDispGrossPay.Visible = false; lblDispHealthInsurance.Visible = false; lblDispTaxWithhold.Visible = false; lblDispRetirementContribution.Visible = false;
            lblDispNetPay.Visible = false;
            lblGrossPay.Visible = false;
            lblFirstName.Visible = false; lblLastName.Visible = false; lblBiweekly.Visible = false; lblPayRate.Visible = false;
            lblBiweekly.Text = "Enter Employee's Biweekly Working Hours: ";
            lblPayRate.Text = "Enter Employee's Pay Rate: ";
            lastNameTextBox.Visible = false; firstNameTextBox.Visible = false; biWeeklyTextBox.Visible = false; payRateTextBox.Visible = false;
            lastNameTextBox.Clear(); firstNameTextBox.Clear();
            biWeeklyTextBox.Clear();
            payRateTextBox.Clear();
        }
    }
}

