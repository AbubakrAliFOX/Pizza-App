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
        void UpdateSize(RadioButton rb)
        {
            lblSize.Text = rb.Text;
        }

        void UpdateCrust(RadioButton rb)
        {
            lblCrust.Text = rb.Text;
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
        }

    }
}
