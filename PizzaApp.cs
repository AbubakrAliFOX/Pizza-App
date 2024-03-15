using System;
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
        void UpdateSize()
        {
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
            }
            else if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
            }
            else if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
            }
        }

        void UpdateCrust()
        {
            if (rbThick.Checked)
            {
                lblCrust.Text = "Thick";
            }
            else if (rbThin.Checked)
            {
                lblCrust.Text = "Thin";
            }
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
            }
            else if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
            }
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

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
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
        }

    }
}
