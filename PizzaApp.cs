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
        int toppingsPrice = 0;
        Dictionary<string, int[]> ItemsPrices ()
        {
            Dictionary<string, int[]> Prices = new Dictionary<string, int[] >();
            Prices["Toppings"] = new int[] { 5 };
            Prices["Size"] = new int[] { 20, 30, 40 };
            Prices["Crust"] = new int[] { 0, 10 };
            Prices["Toppings"] = new int[] { 5 };

            return Prices;
        }

        void UpdatePrice()
        {
            lblTotal.Text = $"{(sizePrice + crustPrice + toppingsPrice).ToString()}$";
        }                            

        int UpdateSize(RadioButton rb)
        {
            lblSize.Text = rb.Text;
            
            if (rb.Text == "Small")
            {
                return 20;
            } else if (rb.Text == "Medium")
            {
                return 30;
            } else if (rb.Text == "Large") {
                return 40;
            } else
            {
                return 0;
            }
        }

        int UpdateCrust(RadioButton rb)
        {
            lblCrust.Text = rb.Text;

            if (rb.Text == "Thick")
            {
                return 10;
            }
            else
            {
                return 0;
            }
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

        public PizzaApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void rbSize_CheckedChanged (object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            sizePrice = UpdateSize(rb);
            UpdatePrice();
        }

        private void rbCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            crustPrice = UpdateCrust(rb);
            UpdatePrice();
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
