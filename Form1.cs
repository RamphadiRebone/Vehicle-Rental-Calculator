using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentalcarsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtphone.Clear();
            txtaddress.Clear();
            txtdays.Clear();
            txtprice.Clear();
            txtvat.Clear();

            chksunroof.Checked = false;
            chksound.Checked = false;
            chkleather.Checked = false;

            radbtnsedan.Checked = false;
            radbtnsuv.Checked = false;
            radbtnmpv.Checked = false;

            lstreceipt.Items.Clear();

            txtname.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Length == 0 || txtphone.Text.Length == 0 || txtaddress.Text.Length == 0 || txtdays.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (txtname.Text.All(char.IsLetter) == false)
            {
                MessageBox.Show("Name should be alphabetic");
                txtname.Focus();
                return;
            }

            if (txtphone.Text.Length != 10 || txtphone.Text.StartsWith("0") == false)
            {
                MessageBox.Show("Phone number must start with 0 and have 10 digits");
                txtphone.Focus();
                return;
            }

            if (txtdays.Text.All(char.IsDigit) == false || int.Parse(txtdays.Text) <= 0)
            {
                MessageBox.Show("Days must be numeric and above 0");
                txtdays.Focus();
                return;
            }

            if (radbtnsedan.Checked == false && radbtnsuv.Checked == false && radbtnmpv.Checked == false)
            {
                MessageBox.Show("Please select a vehicle type");
                return;
            }

            try
            {
                string name = txtname.Text;
                string phone = txtphone.Text;
                string address = txtaddress.Text;
                int days = int.Parse(txtdays.Text);

                double dailyRate = 0;
                if (radbtnsedan.Checked) { dailyRate = 1000; }
                else if (radbtnsuv.Checked) { dailyRate = 2000; }
                else if (radbtnmpv.Checked) { dailyRate = 4000; }

                double baseCost = days * dailyRate;

                double extras = 0;
                if (chksunroof.Checked) { extras += 1000; }
                if (chksound.Checked) { extras += 1500; }
                if (chkleather.Checked) { extras += 3000; }

                double subTotal = baseCost + extras;
                double vat = subTotal * 0.15;
                double grandTotal = subTotal + vat;

                txtprice.Text = grandTotal.ToString("C");
                txtvat.Text = vat.ToString("C");

                lstreceipt.Items.Clear();
                lstreceipt.Items.Add("--- CAR RENTAL RECEIPT ---");
                lstreceipt.Items.Add("Client Name: " + name);
                lstreceipt.Items.Add("Phone: " + phone);
                lstreceipt.Items.Add("Address: " + address);
                lstreceipt.Items.Add("Days Booked: " + days);
                lstreceipt.Items.Add("Vehicle Rate: R" + dailyRate + "/day");
                lstreceipt.Items.Add("Extras Total: R" + extras);
                lstreceipt.Items.Add("----------------------");
                lstreceipt.Items.Add("Subtotal: R" + subTotal);
                lstreceipt.Items.Add("VAT (15%): R" + vat);
                lstreceipt.Items.Add("GRAND TOTAL: " + grandTotal.ToString("C"));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for days.");
            }
        }
    }
}
