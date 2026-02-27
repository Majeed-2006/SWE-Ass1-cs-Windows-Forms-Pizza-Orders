using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
            UpdateType();
            UpdateNumberOfOrders();
          
        }
        void UpdateNumberOfOrders()
        {
            numericUpDown1.Value = 1;
        }
        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }
        void UpdateType()
        {
            UpdateTotalPrice();
            if (rbChicken.Checked)
            {
                lblPizzaType.Text = "Chicken";
                return;
            }

            if (rbBBChicken.Checked)
            {
                lblPizzaType.Text = "Barbecue Chicken";
                return;
            }

            if (rbRanchChicken.Checked)
            {
                lblPizzaType.Text = "Ranch Chicken";
                return;
            }

            if (rbBeef.Checked)
            {
                lblPizzaType.Text = "Beef";
                return;
            }

            if (rbMixedM.Checked)
            {
                lblPizzaType.Text = "Mixed Meats";
                return;
            }

            if (rbSausage.Checked)
            {
                lblPizzaType.Text = "Sausages";
                return;
            }

            if (rbSupreme.Checked)
            {
                lblPizzaType.Text = "Supreme";
                return;
            }

            if (rbMushroom.Checked)
            {
                lblPizzaType.Text = "Mushroom";
                return;
            }
        }

        void UpdateToppings()
        {
         
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked )
            {
                
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked )
            {
              
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked )
            {
                
                sToppings += ", Olives";
            }

            if (chkTomatos.Checked )
            {
               
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
              
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
              
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
               
                sToppings = "No Toppings";
            }

         
            lblToppinges.Text = sToppings;
           
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }

        }
        float GetSelectedTypePrice()
        {
            if (rbChicken.Checked)
                return Convert.ToSingle(rbChicken.Tag);
            else if (rbBBChicken.Checked)
                return Convert.ToSingle(rbBBChicken.Tag);
            else if (rbRanchChicken.Checked)
                return Convert.ToSingle(rbRanchChicken.Tag);
            else if (rbBeef.Checked)
                return Convert.ToSingle(rbBeef.Tag);
            else if (rbMixedM.Checked)
                return Convert.ToSingle(rbMixedM.Tag);
            else if (rbSausage.Checked)
                return Convert.ToSingle(rbSausage.Tag);
            else if (rbSupreme.Checked)
                return Convert.ToSingle(rbSupreme.Tag);
            else 
                return Convert.ToSingle(rbMushroom.Tag);
            
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)

                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)

                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }


            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatos.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatos.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatos.Tag);
            }



            return ToppingsTotalPrice;



        }
        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbPizzaType.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatos.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset Types
            rbChicken.Checked = false;
            rbBBChicken.Checked = false;
            rbRanchChicken.Checked = false;
            rbBeef.Checked = false;
            rbMixedM.Checked = false;
            rbSausage.Checked = false;
            rbSupreme.Checked = false;
            rbMushroom.Checked = false;

            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;
            
            UpdateNumberOfOrders();

        }
        float GetSelectedCrutPrice()
        {
            if (rbThinCrust.Checked)

                return Convert.ToSingle(rbThinCrust.Tag);


            else
                return Convert.ToSingle(rbThickCrust.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice() + GetSelectedTypePrice();
        }

        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();

        }
      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void gbSizeBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void Toppings_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            UpdateType();
        }

        private void gbPizzaType_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbEat_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbChicken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateType();

        }

        private void rbBBChicken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void rbRanchChicken_CheckedChanged(object sender, EventArgs e)
        {

            UpdateType();
        }

        private void rbBeef_CheckedChanged(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void rbMushroom_CheckedChanged(object sender, EventArgs e)
        {

            UpdateType();
        }

        private void rbSupreme_CheckedChanged(object sender, EventArgs e)
        {

            UpdateType();
        }

        private void rbExtraChees_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void rbOnion_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void rbMushrooms_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void ckOlives_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void rbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void gbCrustType_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbSausage_CheckedChanged(object sender, EventArgs e)
        {

            UpdateType();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void lbCrustType_Click(object sender, EventArgs e)
        {

        }

        private void lbOrderSummary_Click(object sender, EventArgs e)
        {

        }

        private void lbTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbPizzaType.Enabled = false;
                btnReselForm.Enabled = true;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnReselForm_Click(object sender, EventArgs e)
        {
           ResetForm();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblOrders.Text = numericUpDown1.Value.ToString();
            float CurrentTotalPrice = CalculateTotalPrice()*(float) numericUpDown1.Value;
           
            lblTotalPrice.Text = CurrentTotalPrice.ToString();

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblPizzaType_Click(object sender, EventArgs e)
        {

        }
    }
}
