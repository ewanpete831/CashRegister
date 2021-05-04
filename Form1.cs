using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //setup Variables
        double turkeySandwiches = 0;
        double veggieSandwiches = 0;
        double drinks = 0;
        double turkeyPrice = 10.25;
        double veggiePrice = 9.00;
        double drinkPrice = 1.50;
        double subTotal = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double amountPaid = 0;
        double amountTendered = 0;
        double change = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get numbers from input text boxes
              turkeySandwiches = Convert.ToDouble(turkeyInput.Text);
              veggieSandwiches = Convert.ToDouble(veggieInput.Text);
              drinks = Convert.ToDouble(drinkInput.Text);

                //calculate sub total, tax amount, and total cost
              subTotal = (turkeySandwiches * turkeyPrice) + (veggieSandwiches * veggiePrice) + (drinks * drinkPrice);
              taxAmount = subTotal * taxRate;
              amountPaid = subTotal + taxAmount;

                //display costs
              totalCostLabel.Text = $"Sub Total:                                           {subTotal.ToString("C")}"
                    + $"\nTax Paid:                                             {taxAmount.ToString("C")}"
                    + $"\nTotal:                                                   {amountPaid.ToString("C")}";

                //enable next button
                changeButton.Enabled = true;
            }
            catch
            {
                //display an error if an invalid order is placed
                totalCostLabel.Text = "Please input a valid order!";
                changeButton.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get amount tendered from input text box
                amountTendered = Convert.ToDouble(tenderedInput.Text);

                //calculate change
                change = amountTendered - amountPaid;

                if (change >= 0)
                {

                    //display change owed
                    changeLabel.Text = $"Change:                                              {change.ToString("C")}";

                    //enable next button
                    printButton.Enabled = true;
                }
                else
                {
                    //give error message
                    changeLabel.Text = "Amount Tendered is Less than Amount Owed!";
                }
            }
            catch
            {
                //display an error message if an invalid amount is tendered
                changeLabel.Text = "Please enter a valid amount!";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //have the receipt appear
            receiptLabel.Visible = true;

            //setup sound
            SoundPlayer Click = new SoundPlayer(Properties.Resources.click);

            //Print Receipt
            receiptLabel.Text = $"\n          Unnamed Sandwich Store Inc.";
            Click.Play();
            Refresh();

            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n                           Order # 1";
            Click.Play();
            Refresh();

            if (turkeySandwiches > 0)
            {
                Thread.Sleep(1000);
                receiptLabel.Text += $"\n\nTurkey Sandwich  x{turkeySandwiches}                 @ {turkeyPrice.ToString("C")}";
                Click.Play();
                Refresh();
            }

            if (veggieSandwiches > 0)
            {
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nVeggie Sandwich  x{veggieSandwiches}                 @ {veggiePrice.ToString("C")}";
                Click.Play();
                Refresh();
            }

            if (drinks > 0)
            {
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nDrink                       x{drinks}                 @ {drinkPrice.ToString("C")}";
                Click.Play();
                Refresh();
            }

            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nSubtotal                                            {subTotal.ToString("C")}";
            Click.Play();
            Refresh();

            Thread.Sleep(1000);
            receiptLabel.Text += $"\nTax Paid                                            {taxAmount.ToString("C")}";
            Click.Play();
            Refresh();

            Thread.Sleep(1000);
            receiptLabel.Text += $"\nTotal                                                  {amountPaid.ToString("C")}";
            Click.Play();
            Refresh();

            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nTendered                                           {amountTendered.ToString("C")}";
            Click.Play();
            Refresh();

            Thread.Sleep(1000);
            receiptLabel.Text += $"\nChange                                              {change.ToString("C")}";
            Click.Play();
            Refresh();

            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n                      Have a Nice Day!";
            Click.Play();

            //set New Order Button to visible
            newOrderButton.Visible = true;

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //reset variables
            turkeySandwiches = 0;
            veggieSandwiches = 0;
            drinks = 0;
            subTotal = 0;
            taxAmount = 0;
            amountTendered = 0;
            amountPaid = 0;
            change = 0;

            //reset lables and text boxes
            receiptLabel.Visible = false;
            turkeyInput.Text = "0";
            veggieInput.Text = "0";
            drinkInput.Text = "0";
            tenderedInput.Text = "0";
            changeButton.Enabled = false;
            printButton.Enabled = false;
            newOrderButton.Visible = false;
            totalCostLabel.Text = "";
            changeLabel.Text = "";



        }
    }
}
