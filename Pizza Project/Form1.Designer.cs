namespace Pizza_Project
{
    partial class MainForm
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
            this.MainTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.gbPizzaType = new System.Windows.Forms.GroupBox();
            this.rbSupreme = new System.Windows.Forms.RadioButton();
            this.rbMixedM = new System.Windows.Forms.RadioButton();
            this.rbSausage = new System.Windows.Forms.RadioButton();
            this.rbMushroom = new System.Windows.Forms.RadioButton();
            this.rbBeef = new System.Windows.Forms.RadioButton();
            this.rbChicken = new System.Windows.Forms.RadioButton();
            this.rbRanchChicken = new System.Windows.Forms.RadioButton();
            this.rbBBChicken = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnReselForm = new System.Windows.Forms.Button();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.Lb5 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lbToppingsType = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lblPizzaType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppinges = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbPizzaType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.Color.Silver;
            this.MainTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MainTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MainTitle.Location = new System.Drawing.Point(576, -14);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(602, 85);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Make Your Pizza";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSize
            // 
            this.gbSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbSize.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbSize.Location = new System.Drawing.Point(727, 167);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(150, 150);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.gbSizeBox_Enter);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(20, 39);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(66, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "40";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(20, 101);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(58, 23);
            this.rbLarge.TabIndex = 1;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "80";
            this.rbLarge.Text = "Larg";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(20, 72);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(83, 23);
            this.rbMedium.TabIndex = 0;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "60";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbToppings.BackColor = System.Drawing.Color.Silver;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbToppings.Location = new System.Drawing.Point(150, 364);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(344, 150);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.Toppings_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(163, 113);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(174, 23);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "10";
            this.chkGreenPeppers.Text = "GreenPeppers  : 10E";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.rbGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(163, 75);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(105, 23);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives : 5E";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.ckOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(163, 38);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(105, 23);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion : 5E";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.rbOnion_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(6, 113);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(141, 23);
            this.chkTomatos.TabIndex = 2;
            this.chkTomatos.Tag = "10";
            this.chkTomatos.Text = "Tomatoes : 10E";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.rbTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 75);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(144, 23);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms : 5E";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.rbMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(6, 38);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(145, 23);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees : 5E";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.rbExtraChees_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbCrustType.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbCrustType.Location = new System.Drawing.Point(727, 357);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(150, 100);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "CrustType";
            this.gbCrustType.Enter += new System.EventHandler(this.gbCrustType_Enter);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(15, 30);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(101, 23);
            this.rbThinCrust.TabIndex = 2;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Curst";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(15, 66);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(109, 23);
            this.rbThickCrust.TabIndex = 0;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "5";
            this.rbThickCrust.Text = "Think Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbWhereToEat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbWhereToEat.Location = new System.Drawing.Point(727, 497);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(300, 80);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat?";
            this.gbWhereToEat.Enter += new System.EventHandler(this.rbEat_Enter);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(15, 30);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(69, 23);
            this.rbEatIn.TabIndex = 2;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Checked = true;
            this.rbTakeOut.Location = new System.Drawing.Point(123, 33);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(92, 23);
            this.rbTakeOut.TabIndex = 0;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // gbPizzaType
            // 
            this.gbPizzaType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPizzaType.Controls.Add(this.rbSupreme);
            this.gbPizzaType.Controls.Add(this.rbMixedM);
            this.gbPizzaType.Controls.Add(this.rbSausage);
            this.gbPizzaType.Controls.Add(this.rbMushroom);
            this.gbPizzaType.Controls.Add(this.rbBeef);
            this.gbPizzaType.Controls.Add(this.rbChicken);
            this.gbPizzaType.Controls.Add(this.rbRanchChicken);
            this.gbPizzaType.Controls.Add(this.rbBBChicken);
            this.gbPizzaType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbPizzaType.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbPizzaType.Location = new System.Drawing.Point(150, 167);
            this.gbPizzaType.Name = "gbPizzaType";
            this.gbPizzaType.Size = new System.Drawing.Size(400, 179);
            this.gbPizzaType.TabIndex = 3;
            this.gbPizzaType.TabStop = false;
            this.gbPizzaType.Text = "Pizza Type";
            this.gbPizzaType.Enter += new System.EventHandler(this.gbPizzaType_Enter);
            // 
            // rbSupreme
            // 
            this.rbSupreme.AutoSize = true;
            this.rbSupreme.Location = new System.Drawing.Point(201, 142);
            this.rbSupreme.Name = "rbSupreme";
            this.rbSupreme.Size = new System.Drawing.Size(90, 23);
            this.rbSupreme.TabIndex = 7;
            this.rbSupreme.TabStop = true;
            this.rbSupreme.Tag = "60";
            this.rbSupreme.Text = "Supreme";
            this.rbSupreme.UseVisualStyleBackColor = true;
            this.rbSupreme.CheckedChanged += new System.EventHandler(this.rbSupreme_CheckedChanged);
            // 
            // rbMixedM
            // 
            this.rbMixedM.AutoSize = true;
            this.rbMixedM.Location = new System.Drawing.Point(199, 77);
            this.rbMixedM.Name = "rbMixedM";
            this.rbMixedM.Size = new System.Drawing.Size(113, 23);
            this.rbMixedM.TabIndex = 5;
            this.rbMixedM.TabStop = true;
            this.rbMixedM.Tag = "100";
            this.rbMixedM.Text = "Mixed Meats";
            this.rbMixedM.UseVisualStyleBackColor = true;
            this.rbMixedM.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbSausage
            // 
            this.rbSausage.AutoSize = true;
            this.rbSausage.Location = new System.Drawing.Point(20, 134);
            this.rbSausage.Name = "rbSausage";
            this.rbSausage.Size = new System.Drawing.Size(85, 23);
            this.rbSausage.TabIndex = 3;
            this.rbSausage.TabStop = true;
            this.rbSausage.Tag = "55";
            this.rbSausage.Text = "Sausage";
            this.rbSausage.UseVisualStyleBackColor = true;
            this.rbSausage.CheckedChanged += new System.EventHandler(this.rbSausage_CheckedChanged);
            // 
            // rbMushroom
            // 
            this.rbMushroom.AutoSize = true;
            this.rbMushroom.Location = new System.Drawing.Point(199, 110);
            this.rbMushroom.Name = "rbMushroom";
            this.rbMushroom.Size = new System.Drawing.Size(102, 23);
            this.rbMushroom.TabIndex = 6;
            this.rbMushroom.TabStop = true;
            this.rbMushroom.Tag = "30";
            this.rbMushroom.Text = "Mushroom";
            this.rbMushroom.UseVisualStyleBackColor = true;
            this.rbMushroom.CheckedChanged += new System.EventHandler(this.rbMushroom_CheckedChanged);
            // 
            // rbBeef
            // 
            this.rbBeef.AutoSize = true;
            this.rbBeef.Location = new System.Drawing.Point(199, 44);
            this.rbBeef.Name = "rbBeef";
            this.rbBeef.Size = new System.Drawing.Size(57, 23);
            this.rbBeef.TabIndex = 4;
            this.rbBeef.TabStop = true;
            this.rbBeef.Tag = "80";
            this.rbBeef.Text = "Beef";
            this.rbBeef.UseVisualStyleBackColor = true;
            this.rbBeef.CheckedChanged += new System.EventHandler(this.rbBeef_CheckedChanged);
            // 
            // rbChicken
            // 
            this.rbChicken.AutoSize = true;
            this.rbChicken.Checked = true;
            this.rbChicken.Location = new System.Drawing.Point(20, 39);
            this.rbChicken.Name = "rbChicken";
            this.rbChicken.Size = new System.Drawing.Size(79, 23);
            this.rbChicken.TabIndex = 0;
            this.rbChicken.TabStop = true;
            this.rbChicken.Tag = "50";
            this.rbChicken.Text = "chicken";
            this.rbChicken.UseVisualStyleBackColor = true;
            this.rbChicken.CheckedChanged += new System.EventHandler(this.rbChicken_CheckedChanged);
            // 
            // rbRanchChicken
            // 
            this.rbRanchChicken.AutoSize = true;
            this.rbRanchChicken.Location = new System.Drawing.Point(20, 105);
            this.rbRanchChicken.Name = "rbRanchChicken";
            this.rbRanchChicken.Size = new System.Drawing.Size(130, 23);
            this.rbRanchChicken.TabIndex = 2;
            this.rbRanchChicken.TabStop = true;
            this.rbRanchChicken.Tag = "55";
            this.rbRanchChicken.Text = "Ranch Chicken";
            this.rbRanchChicken.UseVisualStyleBackColor = true;
            this.rbRanchChicken.CheckedChanged += new System.EventHandler(this.rbRanchChicken_CheckedChanged);
            // 
            // rbBBChicken
            // 
            this.rbBBChicken.AutoSize = true;
            this.rbBBChicken.Location = new System.Drawing.Point(20, 72);
            this.rbBBChicken.Name = "rbBBChicken";
            this.rbBBChicken.Size = new System.Drawing.Size(151, 23);
            this.rbBBChicken.TabIndex = 1;
            this.rbBBChicken.TabStop = true;
            this.rbBBChicken.Tag = "60";
            this.rbBBChicken.Text = "Barbecue Chicken";
            this.rbBBChicken.UseVisualStyleBackColor = true;
            this.rbBBChicken.CheckedChanged += new System.EventHandler(this.rbBBChicken_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOrderPizza.Location = new System.Drawing.Point(692, 807);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(100, 40);
            this.btnOrderPizza.TabIndex = 7;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnReselForm
            // 
            this.btnReselForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReselForm.Enabled = false;
            this.btnReselForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReselForm.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReselForm.Location = new System.Drawing.Point(1015, 807);
            this.btnReselForm.Name = "btnReselForm";
            this.btnReselForm.Size = new System.Drawing.Size(100, 40);
            this.btnReselForm.TabIndex = 8;
            this.btnReselForm.Text = "Resel Form";
            this.btnReselForm.UseVisualStyleBackColor = true;
            this.btnReselForm.Click += new System.EventHandler(this.btnReselForm_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Lucida Bright", 30F);
            this.lblOrderSummary.Location = new System.Drawing.Point(1131, 167);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(327, 45);
            this.lblOrderSummary.TabIndex = 9;
            this.lblOrderSummary.Text = "Order Summary";
            this.lblOrderSummary.Click += new System.EventHandler(this.lbOrderSummary_Click);
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lb2.Location = new System.Drawing.Point(1131, 289);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(78, 28);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "Size : ";
            // 
            // Lb5
            // 
            this.Lb5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lb5.AutoSize = true;
            this.Lb5.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.Lb5.Location = new System.Drawing.Point(1132, 464);
            this.Lb5.Name = "Lb5";
            this.Lb5.Size = new System.Drawing.Size(184, 28);
            this.Lb5.TabIndex = 11;
            this.Lb5.Text = "Where To Eat : ";
            // 
            // lb3
            // 
            this.lb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lb3.Location = new System.Drawing.Point(1131, 345);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(142, 28);
            this.lb3.TabIndex = 12;
            this.lb3.Text = "Toppings : ";
            // 
            // lb4
            // 
            this.lb4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lb4.Location = new System.Drawing.Point(1131, 405);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(158, 28);
            this.lb4.TabIndex = 13;
            this.lb4.Text = "Crust Type : ";
            this.lb4.Click += new System.EventHandler(this.lbCrustType_Click);
            // 
            // lb6
            // 
            this.lb6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lb6.Location = new System.Drawing.Point(1124, 571);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(155, 28);
            this.lb6.TabIndex = 14;
            this.lb6.Text = "Total Price : ";
            this.lb6.Click += new System.EventHandler(this.lbTotalPrice_Click);
            // 
            // lbToppingsType
            // 
            this.lbToppingsType.AutoSize = true;
            this.lbToppingsType.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbToppingsType.Location = new System.Drawing.Point(1369, 304);
            this.lbToppingsType.Name = "lbToppingsType";
            this.lbToppingsType.Size = new System.Drawing.Size(0, 27);
            this.lbToppingsType.TabIndex = 16;
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lb1.Location = new System.Drawing.Point(1131, 234);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(158, 28);
            this.lb1.TabIndex = 17;
            this.lb1.Text = "Pizza Type : ";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPizzaType
            // 
            this.lblPizzaType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPizzaType.AutoSize = true;
            this.lblPizzaType.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lblPizzaType.Location = new System.Drawing.Point(1279, 234);
            this.lblPizzaType.Name = "lblPizzaType";
            this.lblPizzaType.Size = new System.Drawing.Size(102, 28);
            this.lblPizzaType.TabIndex = 18;
            this.lblPizzaType.Text = "chicken";
            this.lblPizzaType.Click += new System.EventHandler(this.lblPizzaType_Click);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lblSize.Location = new System.Drawing.Point(1201, 290);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(78, 28);
            this.lblSize.TabIndex = 19;
            this.lblSize.Text = "Small";
            // 
            // lblToppinges
            // 
            this.lblToppinges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToppinges.AutoSize = true;
            this.lblToppinges.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lblToppinges.Location = new System.Drawing.Point(1262, 345);
            this.lblToppinges.Name = "lblToppinges";
            this.lblToppinges.Size = new System.Drawing.Size(173, 28);
            this.lblToppinges.TabIndex = 20;
            this.lblToppinges.Text = "No Toopinges";
            // 
            // lblCrustType
            // 
            this.lblCrustType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lblCrustType.Location = new System.Drawing.Point(1272, 421);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(0, 28);
            this.lblCrustType.TabIndex = 21;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lblWhereToEat.Location = new System.Drawing.Point(1308, 464);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(79, 28);
            this.lblWhereToEat.TabIndex = 22;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.lblTotalPrice.Location = new System.Drawing.Point(1271, 574);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(42, 28);
            this.lblTotalPrice.TabIndex = 23;
            this.lblTotalPrice.Text = "90";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(198, 567);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 27);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblOrders.Location = new System.Drawing.Point(1425, 567);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(20, 23);
            this.lblOrders.TabIndex = 25;
            this.lblOrders.Text = "0";
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F);
            this.label1.Location = new System.Drawing.Point(1185, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Number Of Orders :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1802, 916);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblToppinges);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPizzaType);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbToppingsType);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.Lb5);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.btnReselForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbPizzaType);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.MainTitle);
            this.Name = "MainForm";
            this.Text = "PizzaHUT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbPizzaType.ResumeLayout(false);
            this.gbPizzaType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;

        private System.Windows.Forms.GroupBox gbSize;

        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;



        private System.Windows.Forms.GroupBox gbToppings;

        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;



        private System.Windows.Forms.GroupBox gbCrustType;

        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;


        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.GroupBox gbPizzaType;
        private System.Windows.Forms.RadioButton rbChicken;
        private System.Windows.Forms.RadioButton rbRanchChicken;
        private System.Windows.Forms.RadioButton rbBBChicken;
        private System.Windows.Forms.RadioButton rbMixedM;
        private System.Windows.Forms.RadioButton rbSausage;
        private System.Windows.Forms.RadioButton rbMushroom;
        private System.Windows.Forms.RadioButton rbBeef;
        private System.Windows.Forms.RadioButton rbSupreme;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnReselForm;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label Lb5;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lbToppingsType;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lblPizzaType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppinges;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label label1;
    }
}

