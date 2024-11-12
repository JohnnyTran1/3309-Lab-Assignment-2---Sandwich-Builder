
namespace Lab_Assignment_2___Sandwich_Builder
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboPersonalInformation = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumberEnter = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddressEnter = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameEnter = new System.Windows.Forms.TextBox();
            this.gboOrder = new System.Windows.Forms.GroupBox();
            this.radPickUp = new System.Windows.Forms.RadioButton();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboTypeOfBread = new System.Windows.Forms.ComboBox();
            this.clbSauces = new System.Windows.Forms.CheckedListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplaySauces = new System.Windows.Forms.Label();
            this.ckbTurkey = new System.Windows.Forms.CheckBox();
            this.ckbBacon = new System.Windows.Forms.CheckBox();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbMeatballs = new System.Windows.Forms.CheckBox();
            this.ckbTuna = new System.Windows.Forms.CheckBox();
            this.ckbSalami = new System.Windows.Forms.CheckBox();
            this.ckbChicken = new System.Windows.Forms.CheckBox();
            this.ckbRoastBeef = new System.Windows.Forms.CheckBox();
            this.ckbHam = new System.Windows.Forms.CheckBox();
            this.ckbPastrami = new System.Windows.Forms.CheckBox();
            this.gboMeats = new System.Windows.Forms.GroupBox();
            this.lblCheeses = new System.Windows.Forms.Label();
            this.clbCheeses = new System.Windows.Forms.CheckedListBox();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.clbPremium = new System.Windows.Forms.CheckedListBox();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.gboTip = new System.Windows.Forms.GroupBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTypeOfBread = new System.Windows.Forms.Label();
            this.lblSandwichSize = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.blOptional = new System.Windows.Forms.Label();
            this.gboPersonalInformation.SuspendLayout();
            this.gboOrder.SuspendLayout();
            this.gboMeats.SuspendLayout();
            this.gboTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPersonalInformation
            // 
            this.gboPersonalInformation.Controls.Add(this.lblPhoneNumber);
            this.gboPersonalInformation.Controls.Add(this.txtPhoneNumberEnter);
            this.gboPersonalInformation.Controls.Add(this.lblAddress);
            this.gboPersonalInformation.Controls.Add(this.txtAddressEnter);
            this.gboPersonalInformation.Controls.Add(this.lblName);
            this.gboPersonalInformation.Controls.Add(this.txtNameEnter);
            this.gboPersonalInformation.Location = new System.Drawing.Point(12, 12);
            this.gboPersonalInformation.Name = "gboPersonalInformation";
            this.gboPersonalInformation.Size = new System.Drawing.Size(200, 100);
            this.gboPersonalInformation.TabIndex = 0;
            this.gboPersonalInformation.TabStop = false;
            this.gboPersonalInformation.Text = "Personal Information";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 42);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumberEnter
            // 
            this.txtPhoneNumberEnter.Location = new System.Drawing.Point(94, 42);
            this.txtPhoneNumberEnter.Name = "txtPhoneNumberEnter";
            this.txtPhoneNumberEnter.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumberEnter.TabIndex = 12;
            this.txtPhoneNumberEnter.TextChanged += new System.EventHandler(this.txtPhoneNumberEnter_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddressEnter
            // 
            this.txtAddressEnter.Location = new System.Drawing.Point(94, 64);
            this.txtAddressEnter.Name = "txtAddressEnter";
            this.txtAddressEnter.Size = new System.Drawing.Size(100, 20);
            this.txtAddressEnter.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtNameEnter
            // 
            this.txtNameEnter.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameEnter.Location = new System.Drawing.Point(94, 20);
            this.txtNameEnter.Name = "txtNameEnter";
            this.txtNameEnter.Size = new System.Drawing.Size(100, 20);
            this.txtNameEnter.TabIndex = 10;
            this.txtNameEnter.TextChanged += new System.EventHandler(this.txtNameEnter_TextChanged);
            // 
            // gboOrder
            // 
            this.gboOrder.Controls.Add(this.radPickUp);
            this.gboOrder.Controls.Add(this.radDelivery);
            this.gboOrder.Location = new System.Drawing.Point(13, 119);
            this.gboOrder.Name = "gboOrder";
            this.gboOrder.Size = new System.Drawing.Size(200, 100);
            this.gboOrder.TabIndex = 1;
            this.gboOrder.TabStop = false;
            this.gboOrder.Text = "Order";
            // 
            // radPickUp
            // 
            this.radPickUp.AutoSize = true;
            this.radPickUp.Location = new System.Drawing.Point(9, 54);
            this.radPickUp.Name = "radPickUp";
            this.radPickUp.Size = new System.Drawing.Size(63, 17);
            this.radPickUp.TabIndex = 1;
            this.radPickUp.TabStop = true;
            this.radPickUp.Text = "Pick Up";
            this.radPickUp.UseVisualStyleBackColor = true;
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(9, 20);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(63, 17);
            this.radDelivery.TabIndex = 0;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra-large",
            "Party-size"});
            this.cboSize.Location = new System.Drawing.Point(561, 164);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 2;
            // 
            // cboTypeOfBread
            // 
            this.cboTypeOfBread.FormattingEnabled = true;
            this.cboTypeOfBread.Items.AddRange(new object[] {
            "Italian",
            "Rye",
            "Flatbread",
            "Wheat",
            "Multi-grain",
            "Sourdough"});
            this.cboTypeOfBread.Location = new System.Drawing.Point(561, 207);
            this.cboTypeOfBread.Name = "cboTypeOfBread";
            this.cboTypeOfBread.Size = new System.Drawing.Size(121, 21);
            this.cboTypeOfBread.TabIndex = 3;
            this.cboTypeOfBread.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clbSauces
            // 
            this.clbSauces.FormattingEnabled = true;
            this.clbSauces.Items.AddRange(new object[] {
            "Mayo",
            "Mustard",
            "Oil",
            "Vinegar",
            "BBQ Sauce",
            "Ketchup",
            "Hot Sauce",
            "Ranch"});
            this.clbSauces.Location = new System.Drawing.Point(688, 17);
            this.clbSauces.Name = "clbSauces";
            this.clbSauces.Size = new System.Drawing.Size(81, 124);
            this.clbSauces.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(412, 235);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 40);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(331, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisplaySauces
            // 
            this.lblDisplaySauces.AutoSize = true;
            this.lblDisplaySauces.Location = new System.Drawing.Point(688, -2);
            this.lblDisplaySauces.Name = "lblDisplaySauces";
            this.lblDisplaySauces.Size = new System.Drawing.Size(46, 13);
            this.lblDisplaySauces.TabIndex = 13;
            this.lblDisplaySauces.Text = "Sauces:";
            // 
            // ckbTurkey
            // 
            this.ckbTurkey.AutoSize = true;
            this.ckbTurkey.Location = new System.Drawing.Point(6, 36);
            this.ckbTurkey.Name = "ckbTurkey";
            this.ckbTurkey.Size = new System.Drawing.Size(59, 17);
            this.ckbTurkey.TabIndex = 14;
            this.ckbTurkey.Text = "Turkey";
            this.ckbTurkey.UseVisualStyleBackColor = true;
            // 
            // ckbBacon
            // 
            this.ckbBacon.AutoSize = true;
            this.ckbBacon.Location = new System.Drawing.Point(92, 82);
            this.ckbBacon.Name = "ckbBacon";
            this.ckbBacon.Size = new System.Drawing.Size(57, 17);
            this.ckbBacon.TabIndex = 15;
            this.ckbBacon.Text = "Bacon";
            this.ckbBacon.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Location = new System.Drawing.Point(92, 59);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(74, 17);
            this.ckbPepperoni.TabIndex = 16;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbMeatballs
            // 
            this.ckbMeatballs.AutoSize = true;
            this.ckbMeatballs.Location = new System.Drawing.Point(92, 36);
            this.ckbMeatballs.Name = "ckbMeatballs";
            this.ckbMeatballs.Size = new System.Drawing.Size(72, 17);
            this.ckbMeatballs.TabIndex = 17;
            this.ckbMeatballs.Text = "MeatBalls";
            this.ckbMeatballs.UseVisualStyleBackColor = true;
            // 
            // ckbTuna
            // 
            this.ckbTuna.AutoSize = true;
            this.ckbTuna.Location = new System.Drawing.Point(92, 13);
            this.ckbTuna.Name = "ckbTuna";
            this.ckbTuna.Size = new System.Drawing.Size(51, 17);
            this.ckbTuna.TabIndex = 18;
            this.ckbTuna.Text = "Tuna";
            this.ckbTuna.UseVisualStyleBackColor = true;
            // 
            // ckbSalami
            // 
            this.ckbSalami.AutoSize = true;
            this.ckbSalami.Location = new System.Drawing.Point(6, 59);
            this.ckbSalami.Name = "ckbSalami";
            this.ckbSalami.Size = new System.Drawing.Size(57, 17);
            this.ckbSalami.TabIndex = 19;
            this.ckbSalami.Text = "Salami";
            this.ckbSalami.UseVisualStyleBackColor = true;
            // 
            // ckbChicken
            // 
            this.ckbChicken.AutoSize = true;
            this.ckbChicken.Location = new System.Drawing.Point(6, 105);
            this.ckbChicken.Name = "ckbChicken";
            this.ckbChicken.Size = new System.Drawing.Size(65, 17);
            this.ckbChicken.TabIndex = 20;
            this.ckbChicken.Text = "Chicken";
            this.ckbChicken.UseVisualStyleBackColor = true;
            // 
            // ckbRoastBeef
            // 
            this.ckbRoastBeef.AutoSize = true;
            this.ckbRoastBeef.Location = new System.Drawing.Point(6, 13);
            this.ckbRoastBeef.Name = "ckbRoastBeef";
            this.ckbRoastBeef.Size = new System.Drawing.Size(79, 17);
            this.ckbRoastBeef.TabIndex = 21;
            this.ckbRoastBeef.Text = "Roast Beef";
            this.ckbRoastBeef.UseVisualStyleBackColor = true;
            // 
            // ckbHam
            // 
            this.ckbHam.AutoSize = true;
            this.ckbHam.Location = new System.Drawing.Point(6, 82);
            this.ckbHam.Name = "ckbHam";
            this.ckbHam.Size = new System.Drawing.Size(48, 17);
            this.ckbHam.TabIndex = 22;
            this.ckbHam.Text = "Ham";
            this.ckbHam.UseVisualStyleBackColor = true;
            this.ckbHam.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // ckbPastrami
            // 
            this.ckbPastrami.AutoSize = true;
            this.ckbPastrami.Location = new System.Drawing.Point(92, 105);
            this.ckbPastrami.Name = "ckbPastrami";
            this.ckbPastrami.Size = new System.Drawing.Size(66, 17);
            this.ckbPastrami.TabIndex = 23;
            this.ckbPastrami.Text = "Pastrami";
            this.ckbPastrami.UseVisualStyleBackColor = true;
            // 
            // gboMeats
            // 
            this.gboMeats.Controls.Add(this.ckbChicken);
            this.gboMeats.Controls.Add(this.ckbPepperoni);
            this.gboMeats.Controls.Add(this.ckbHam);
            this.gboMeats.Controls.Add(this.ckbBacon);
            this.gboMeats.Controls.Add(this.ckbTurkey);
            this.gboMeats.Controls.Add(this.ckbMeatballs);
            this.gboMeats.Controls.Add(this.ckbTuna);
            this.gboMeats.Controls.Add(this.ckbPastrami);
            this.gboMeats.Controls.Add(this.ckbSalami);
            this.gboMeats.Controls.Add(this.ckbRoastBeef);
            this.gboMeats.Location = new System.Drawing.Point(520, 12);
            this.gboMeats.Name = "gboMeats";
            this.gboMeats.Size = new System.Drawing.Size(162, 127);
            this.gboMeats.TabIndex = 24;
            this.gboMeats.TabStop = false;
            this.gboMeats.Text = "Meats";
            // 
            // lblCheeses
            // 
            this.lblCheeses.AutoSize = true;
            this.lblCheeses.Location = new System.Drawing.Point(691, 148);
            this.lblCheeses.Name = "lblCheeses";
            this.lblCheeses.Size = new System.Drawing.Size(48, 13);
            this.lblCheeses.TabIndex = 25;
            this.lblCheeses.Text = "Cheeses";
            // 
            // clbCheeses
            // 
            this.clbCheeses.FormattingEnabled = true;
            this.clbCheeses.Items.AddRange(new object[] {
            "American",
            "Cheddar",
            "Swiss",
            "Provolone",
            "Mozzarella"});
            this.clbCheeses.Location = new System.Drawing.Point(688, 164);
            this.clbCheeses.Name = "clbCheeses";
            this.clbCheeses.Size = new System.Drawing.Size(81, 79);
            this.clbCheeses.TabIndex = 26;
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Lettuce",
            "Tomatoes",
            "Onions",
            "Pickles",
            "Green Peppers",
            "Red Peppers",
            "Jalapenos",
            "Spinach",
            "Cucumbers",
            "Banana Peppers"});
            this.clbToppings.Location = new System.Drawing.Point(688, 262);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(104, 154);
            this.clbToppings.TabIndex = 28;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(688, 246);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(51, 13);
            this.lblToppings.TabIndex = 27;
            this.lblToppings.Text = "Toppings";
            // 
            // clbPremium
            // 
            this.clbPremium.FormattingEnabled = true;
            this.clbPremium.Items.AddRange(new object[] {
            "Extra Cheese",
            "Extra Meat",
            "Vegan Bacon",
            "Avocado",
            "Sundried Tomato",
            "Feta Cheese",
            "Pesto Sauce",
            "Olives",
            "Guacamole",
            "Sliced Egg"});
            this.clbPremium.Location = new System.Drawing.Point(578, 262);
            this.clbPremium.Name = "clbPremium";
            this.clbPremium.Size = new System.Drawing.Size(104, 154);
            this.clbPremium.TabIndex = 30;
            this.clbPremium.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Location = new System.Drawing.Point(578, 246);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(47, 13);
            this.lblPremium.TabIndex = 29;
            this.lblPremium.Text = "Premium";
            this.lblPremium.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(7, 21);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(66, 13);
            this.lblTip.TabIndex = 31;
            this.lblTip.Text = "Tip the staff:";
            // 
            // gboTip
            // 
            this.gboTip.Controls.Add(this.txtTip);
            this.gboTip.Controls.Add(this.lblTip);
            this.gboTip.Location = new System.Drawing.Point(12, 225);
            this.gboTip.Name = "gboTip";
            this.gboTip.Size = new System.Drawing.Size(200, 50);
            this.gboTip.TabIndex = 2;
            this.gboTip.TabStop = false;
            this.gboTip.Text = "Tip";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(94, 14);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 32;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(305, 157);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 34;
            this.lblQty.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(308, 173);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(65, 20);
            this.txtQty.TabIndex = 35;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(251, 196);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(98, 13);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "Error (place Holder)";
            this.lblError.Visible = false;
            // 
            // lblTypeOfBread
            // 
            this.lblTypeOfBread.AutoSize = true;
            this.lblTypeOfBread.Location = new System.Drawing.Point(558, 191);
            this.lblTypeOfBread.Name = "lblTypeOfBread";
            this.lblTypeOfBread.Size = new System.Drawing.Size(74, 13);
            this.lblTypeOfBread.TabIndex = 38;
            this.lblTypeOfBread.Text = "Type of Bread";
            // 
            // lblSandwichSize
            // 
            this.lblSandwichSize.AutoSize = true;
            this.lblSandwichSize.Location = new System.Drawing.Point(558, 148);
            this.lblSandwichSize.Name = "lblSandwichSize";
            this.lblSandwichSize.Size = new System.Drawing.Size(77, 13);
            this.lblSandwichSize.TabIndex = 39;
            this.lblSandwichSize.Text = "Sandwich Size";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(153, 289);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(411, 13);
            this.lblInstruction.TabIndex = 40;
            this.lblInstruction.Text = "Customer must select at least one ingredient from each category, name, order and " +
    "qty.";
            // 
            // blOptional
            // 
            this.blOptional.AutoSize = true;
            this.blOptional.Location = new System.Drawing.Point(153, 317);
            this.blOptional.Name = "blOptional";
            this.blOptional.Size = new System.Drawing.Size(209, 13);
            this.blOptional.TabIndex = 41;
            this.blOptional.Text = "Optional: Tip, Phone Number and Address!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blOptional);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblSandwichSize);
            this.Controls.Add(this.lblTypeOfBread);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.gboTip);
            this.Controls.Add(this.clbPremium);
            this.Controls.Add(this.lblPremium);
            this.Controls.Add(this.clbToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.clbCheeses);
            this.Controls.Add(this.lblCheeses);
            this.Controls.Add(this.gboMeats);
            this.Controls.Add(this.lblDisplaySauces);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.clbSauces);
            this.Controls.Add(this.cboTypeOfBread);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.gboOrder);
            this.Controls.Add(this.gboPersonalInformation);
            this.Name = "frmMain";
            this.Text = "Johnny Tran - Sandwich Builder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gboPersonalInformation.ResumeLayout(false);
            this.gboPersonalInformation.PerformLayout();
            this.gboOrder.ResumeLayout(false);
            this.gboOrder.PerformLayout();
            this.gboMeats.ResumeLayout(false);
            this.gboMeats.PerformLayout();
            this.gboTip.ResumeLayout(false);
            this.gboTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //internal

        private System.Windows.Forms.GroupBox gboPersonalInformation;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gboOrder;
        private System.Windows.Forms.RadioButton radPickUp;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboTypeOfBread;
        private System.Windows.Forms.CheckedListBox clbSauces;
        private System.Windows.Forms.TextBox txtPhoneNumberEnter;
        private System.Windows.Forms.TextBox txtAddressEnter;
        private System.Windows.Forms.TextBox txtNameEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplaySauces;
        private System.Windows.Forms.CheckBox ckbTurkey;
        private System.Windows.Forms.CheckBox ckbBacon;
        private System.Windows.Forms.CheckBox ckbPepperoni;
        private System.Windows.Forms.CheckBox ckbMeatballs;
        private System.Windows.Forms.CheckBox ckbTuna;
        private System.Windows.Forms.CheckBox ckbSalami;
        private System.Windows.Forms.CheckBox ckbChicken;
        private System.Windows.Forms.CheckBox ckbRoastBeef;
        private System.Windows.Forms.CheckBox ckbHam;
        private System.Windows.Forms.CheckBox ckbPastrami;
        private System.Windows.Forms.GroupBox gboMeats;
        private System.Windows.Forms.CheckedListBox clbPremium;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblCheeses;
        private System.Windows.Forms.CheckedListBox clbCheeses;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox gboTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTypeOfBread;
        private System.Windows.Forms.Label lblSandwichSize;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label blOptional;
    }
}

