using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200427653A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void opCalculate_Click(object sender, EventArgs e)
        {
            double total; //ok i know i spelt these words incorrect, when i started i named the textboxes the proper names and i forgot how to change the names of them without the program throwing a fit. my bad
            double change;
            double payed;
            int toonie;
            int loonie;
            int quarter;
            int dime;
            int nickels;

            if (string.IsNullOrWhiteSpace(this.total.Text) || string.IsNullOrWhiteSpace(pay.Text)) // error handeling this one checks for the boxes and if they actually hold anything
            {
                MessageBox.Show("please enter something");
                return;
            }
            if (double.TryParse(this.total.Text, out total) == false || double.TryParse(pay.Text, out payed) == false) // this error handle checks to see if the inputs are numerical
            {
                MessageBox.Show("Enter a number");
                return;
            }

            payed = double.Parse(pay.Text); //assigning the variables payed and total.
            total = double.Parse(this.total.Text);

            if (total > payed) // if the total is larger than what they are paying it shows the remaining balance.
            {
                MessageBox.Show("You are short by $" + (total - payed));
                return;
            }

            change = payed - total; // calculating the change to be returned.

            this.change.Text = "$" + change.ToString(); // this is how it displays to the change.textbox

            toonie = (int)change / 2;
            change = change % 2;

            loonie = (int)change / 1;
            change = change % 1;

            quarter = (int)(change / 0.25);
            change = change % 0.25;

            dime = (int)(change / 0.1);
            change = change % 0.1;

            nickels = (int)(change / 0.05);
            change = change % 0.05;

            if (change <= 0.029)
            {

            }
            else if (change <= 0.079)
            {
                nickels = 1;
            }
            else
            {
                dime += 1;
            }
            toonies.Text = toonie.ToString();
            loonies.Text = loonie.ToString();
            quarters.Text = quarter.ToString();
            dimes.Text = dime.ToString();
            nickel.Text = nickels.ToString();
        }

        private void nickel_TextChanged(object sender, EventArgs e)
        {

        }

        private void opClear_Click(object sender, EventArgs e) // wipe button sets all values to empty strings.
        {
            toonies.Text = "";
            loonies.Text = "";
            quarters.Text = "";
            dimes.Text = "";
            nickel.Text = "";
            total.Text = "";
            pay.Text = "";
            change.Text = "";

        }
    }
}
