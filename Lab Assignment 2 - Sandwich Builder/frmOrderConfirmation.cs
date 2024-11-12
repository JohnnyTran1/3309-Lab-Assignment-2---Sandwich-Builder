using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Assignment_2___Sandwich_Builder
{
    public partial class frmOrderConfirmation : Form
    {
        private Order order;
        public frmOrderConfirmation(Order order)
        {
            InitializeComponent();
            this.order = order;

            DisplayOrderDetails();
        }

        private void DisplayOrderDetails()
        {
            // Display customer details
            if (order.Customer != null)
            {
                lblDisplayPhoneNumber.Text = order.Customer.PhoneNumber;
                lblDisplayAddress.Text = order.Customer.Address;
                lblDisplayName.Text = order.Customer.Name;
            }
            else
            {
                MessageBox.Show("Customer is not here!");
            }
            lblDisplayOrder.Text = order.DeliveryMethod;

            lblDisplayTip.Text = $"${order.Tip}";

            string displayQty = Convert.ToString(order.Qty);
            lblQty.Text = displayQty + " sandwich(s)!";

            lblDisplayTotal.Text = $"${order.DisplayTotalCost():0.00}";

            lblDisplayTax.Text = $"${order.DisplayTotalTax():0.00}";

            lblDisplayDateAndTime.Text = order.OrderDateAndTime.ToString();

            lblDisplayCostOfBread.Text = $"${order.DisplayTotalBread():0.00}";

            lblDisplayCostOfSize.Text = $"${order.DisplayTotalSize():0.00}";

            lblDisplayCostOfSauce.Text = $"${order.DisplayTotalSauce():0.00}";

            lblDisplayCostOfCheese.Text = $"${order.DisplayTotalCheese():0.00}";

            lblDisplayCostOfTopping.Text = $"${order.DisplayTotalTopping():0.00}";

            lblDisplayCostOfPremium.Text = $"${order.DisplayTotalPremium():0.00}";

            lblDisplaySandwichCost.Text = $"${order.DisplayTotalItem():0.00}";

            lblDisplayCostOfMeat.Text = $"${order.DisplayTotalMeat():0.00}";

            lblDisplayItems.Text = string.Join(", \n", order.SelectedItems);

        }

        private void lblDisplayOrder_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmMain main;
            main = new frmMain();
            this.Hide();
            
        }

        private void lblDisplayName_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayTip_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void frmOrderConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
