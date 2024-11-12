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
    public partial class frmMain : Form
    {
        // Declare the Sandwich, Customer, and Order instances
        Sandwich sandwich;
        Customer customer;
        Order order;

        public frmMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            int qty;
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNameEnter.Text, "^[a-zA-Z ]"))
            {
                lblError.Text = "Name only accept letters!";
                lblError.Visible = true;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumberEnter.Text, @"^(\d{10}|)$"))
            {
                lblError.Text = "Phone number must be a positive 10 digits number or left blank!";
                lblError.Visible = true;
                return;
            }
            double tipValue = 0;  // Default value
            if (string.IsNullOrWhiteSpace(txtTip.Text))
            {
                tipValue = 0;  // Set to 0 if textbox is blank
            }
            else if (!double.TryParse(txtTip.Text, out tipValue) || tipValue < 0)
            {
                lblError.Text = "Tip must be a positive number!";
                lblError.Visible = true;
                return;
            }
            
            if (!int.TryParse(txtQty.Text, out qty) || qty <= 0)
            {
                lblError.Text = "Please enter a postive number for qty.";
                lblError.Visible = true;
                return;
            }
            if (!radDelivery.Checked && !radPickUp.Checked)
            {
                // Display error message if none of the radio buttons are checked
                lblError.Text = "Please select a type of order!";
                lblError.Visible = true;
                return;
            }

            string name = txtNameEnter.Text;
            string phone = txtPhoneNumberEnter.Text.Trim();
            string address = txtAddressEnter.Text;
            customer = new Customer(name, phone, address);

            string deliveryMethod = radDelivery.Checked ? "Delivery" : "Pickup";

            string tip = tipValue.ToString();

            if (cboTypeOfBread.SelectedItem == null)
            {
                lblError.Text = "Must select a bread type!";
                lblError.Visible = true;
                return;
            }
            string breadType = cboTypeOfBread.SelectedItem.ToString();

            if (cboSize.SelectedItem == null)
            {
                lblError.Text = "Must select a size type!";
                lblError.Visible = true;
                return;
            }
            string size = cboSize.SelectedItem.ToString();

            if (clbSauces.SelectedItem == null)
            {
                lblError.Text = "Must select at least one sauce!";
                lblError.Visible = true;
                return;
            }
            string sauces = clbSauces.SelectedItem.ToString();

            List<string> selectedSauces = clbSauces.CheckedItems.OfType<string>().ToList();

            if (clbCheeses.SelectedItem == null)
            {
                lblError.Text = "Must select at least one cheese!";
                lblError.Visible = true;
                return;
            }
            string cheeses = clbCheeses.SelectedItem.ToString();

            List<string> selectedCheeses = clbCheeses.CheckedItems.OfType<string>().ToList();

            if (clbPremium.SelectedItem == null)
            {
                lblError.Text = "Must select at least one Premium!";
                lblError.Visible = true;
                return;
            }
            string premium = clbPremium.SelectedItem.ToString();

            List<string> selectedPremium = clbPremium.CheckedItems.OfType<string>().ToList();

            if (clbToppings.SelectedItem == null)
            {
                lblError.Text = "Must select at least one topping!";
                lblError.Visible = true;
                return;
            }
            string toppings = clbToppings.SelectedItem.ToString();

            List<string> selectedToppings = clbToppings.CheckedItems.OfType<string>().ToList();

            List<string> selectedMeats = new List<string>();
            if (ckbBacon.Checked) selectedMeats.Add("Bacon");
            if (ckbChicken.Checked) selectedMeats.Add("Chicken");
            if (ckbHam.Checked) selectedMeats.Add("Ham");
            if (ckbMeatballs.Checked) selectedMeats.Add("Meatballs");
            if (ckbPastrami.Checked) selectedMeats.Add("Pastrami");
            if (ckbPepperoni.Checked) selectedMeats.Add("Pepperoni");
            if (ckbRoastBeef.Checked) selectedMeats.Add("Roast Beef");
            if (ckbSalami.Checked) selectedMeats.Add("Salami");
            if (ckbTuna.Checked) selectedMeats.Add("Tuna");
            if (ckbTurkey.Checked) selectedMeats.Add("Turkey");
            if (selectedMeats.Count == 0)
            {
                lblError.Text = "You must select at least one meat!";
                lblError.Visible = true;
                return;
            }

            sandwich = new Sandwich(breadType, size, selectedSauces, selectedCheeses, selectedPremium, selectedToppings, selectedMeats);
            sandwich.SelectedBreadType = breadType;
            sandwich.SelectedSizeType = size;
            sandwich.SelectedSauces = selectedSauces;
            sandwich.SelectedCheeses = selectedCheeses;
            sandwich.SelectedPremium = selectedPremium;
            sandwich.SelectedToppings = selectedToppings;
            sandwich.SelectedMeats = selectedMeats;


            order = new Order(customer, deliveryMethod, tip, qty, sandwich);

            order.SelectedItems = new List<string>() { cboSize.SelectedItem.ToString() }
                                .Concat(new List<string>() { cboTypeOfBread.SelectedItem.ToString() })
                                .Concat(clbSauces.CheckedItems.OfType<string>())
                                .Concat(clbToppings.CheckedItems.OfType<string>())
                                .Concat(clbCheeses.CheckedItems.OfType<string>())
                                .Concat(clbPremium.CheckedItems.OfType<string>())
                                .Concat(selectedMeats)
                                .ToList();


            // Create an instance of the form to open and use
            frmOrderConfirmation orderConfirmation; //create a new variable for the form
            orderConfirmation = new frmOrderConfirmation(order);

            //Open the form to use it.
            //orderConfirmation.Show(); // non - modal form, every form open and are independent of each other
            orderConfirmation.ShowDialog(); // modal form, message dialogous box. You have to work one form at a time
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing the frmMain and setting everything to default

            //Personal Information 
            txtNameEnter.Clear();
            txtAddressEnter.Clear();
            txtPhoneNumberEnter.Clear();

            //Order
            radDelivery.Checked = false;
            radPickUp.Checked = false;

            //Tip
            txtTip.Clear();

            //Qty
            txtQty.Clear();

            //Errors
            lblError.Text = "";

            //Meats
            ckbRoastBeef.Checked = false;
            ckbTuna.Checked = false;
            ckbTurkey.Checked = false;
            ckbMeatballs.Checked = false;
            ckbSalami.Checked = false;
            ckbPepperoni.Checked = false;
            ckbHam.Checked = false;
            ckbBacon.Checked = false;
            ckbChicken.Checked = false;
            ckbPastrami.Checked = false;

            //sauces
            clbSauces.ClearSelected();
            foreach (int i in clbSauces.CheckedIndices)
            {
                clbSauces.SetItemCheckState(i, CheckState.Unchecked);
            }

            //Cheeses
            clbCheeses.ClearSelected();
            foreach (int i in clbCheeses.CheckedIndices)
            {
                clbCheeses.SetItemCheckState(i, CheckState.Unchecked);
            }

            //Toppings
            clbToppings.ClearSelected();
            foreach (int i in clbToppings.CheckedIndices)
            {
               clbToppings.SetItemCheckState(i, CheckState.Unchecked);
            }

            //Premium
            clbPremium.ClearSelected();
            foreach (int i in clbPremium.CheckedIndices)
            {
                clbPremium.SetItemCheckState(i, CheckState.Unchecked);
            }

            //Sandwich Size
            cboSize.SelectedIndex = -1;

            //Type of Bread
            cboTypeOfBread.SelectedIndex = -1;
        }

        private void txtPhoneNumberEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameEnter_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
