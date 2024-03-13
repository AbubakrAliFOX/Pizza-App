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
        void UpdateSize ()
        {
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
            } else if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
            } else if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
            }
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
    }
}
