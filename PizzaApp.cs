using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class PizzaApp : Form
    {
        int sizePrice;
        int crustPrice;
        int toppingsPrice;
        Dictionary<string, int> sizePrices()
        {
            Dictionary<string, int> Prices = new Dictionary<string, int>();
            Prices["Small"] = 20;
            Prices["Medium"] = 30; ;
            Prices["Large"] = 40;

            return Prices;
        }

        void UpdatePrice()
        {
            lblTotal.Text = $"{(sizePrice + crustPrice + toppingsPrice).ToString()}$";
        }                            

        void UpdateSize(RadioButton rb)
        {
            lblSize.Text = rb.Text;
            sizePrice = sizePrices()[rb.Text];
            UpdatePrice();
        }

        void UpdateCrust(RadioButton rb)
        {
            lblCrust.Text = rb.Text;

            if (rb.Text == "Thick")
            {
                crustPrice = 10;
            }
            else
            {
                crustPrice = 0;
            }
            UpdatePrice();
        }

        void UpdateWhereToEat(RadioButton rb)
        {
            lblWhereToEat.Text = rb.Text;
        }

        void UpdateToppings(List<string> selectedToppings)
        {
            string wantedToppings = "";
            foreach (string topping in selectedToppings)
            {
                wantedToppings += $"{topping}, ";
            }
            lblToppings.Text = wantedToppings;
        }

        void DisableForm()
        {
            gbCrust.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
        }

        void EnableForm()
        {
            gbCrust.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
        }

        public PizzaApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order?", "Confirmation", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableForm();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableForm();
        }

        private void rbSize_CheckedChanged (object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateSize(rb);
        }

        private void rbCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateCrust(rb);
        }
        private void rbWhereToEat_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            UpdateWhereToEat(rb);
        }

        List<string> selectedToppings = new List<string>();
        private void toppingsCheckChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                selectedToppings.Add(checkBox.Text);
            } else
            {
                selectedToppings.Remove(checkBox.Text);

            }
            UpdateToppings(selectedToppings);
            
            toppingsPrice = selectedToppings.Count == 0 ? (0) :(selectedToppings.Count * 5);
            UpdatePrice();
        }

    }
}
