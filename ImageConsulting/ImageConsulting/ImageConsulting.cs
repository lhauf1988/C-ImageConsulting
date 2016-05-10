//Lucas Hauf  
//POS409
//12/15/2015
//a project to process a sale for a business, add a tip, and get the total with tax


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConsulting
{
    public partial class frmImageConsulting : Form
    {
        public frmImageConsulting()
        {
            InitializeComponent();
        }      

       private void btnAddMakeover_Click(object sender, EventArgs e)
       {

           txtMakeover.Text = AddTotal(Int32.Parse(txtMakeover.Text)).ToString();
           GetTotal();
       }

       private void btnMinusMakeover_Click(object sender, EventArgs e)
       {

           txtMakeover.Text = MinusTotal(Int32.Parse(txtMakeover.Text)).ToString();
           GetTotal();
       }
    
        private void btnMinusManicure_Click(object sender, EventArgs e)
        {

            txtManicure.Text = MinusTotal(Int32.Parse(txtManicure.Text)).ToString();
            GetTotal();
        }

        private void btnAddManicure_Click(object sender, EventArgs e)
        {
            txtManicure.Text = AddTotal(Int32.Parse(txtManicure.Text)).ToString();
            GetTotal();
        }

        private void btnMinusHairStyling_Click(object sender, EventArgs e)
        {
            txtHairStyling.Text = MinusTotal(Int32.Parse(txtHairStyling.Text)).ToString();
            GetTotal();
        }
        private void btnAddHairStyling_Click(object sender, EventArgs e)
        {
            txtHairStyling.Text = AddTotal(Int32.Parse(txtHairStyling.Text)).ToString();
            GetTotal();
        }
        private void btnMinusPerminantMakeup_Click(object sender, EventArgs e)
        {          
            txtPerminantMakeup.Text = MinusTotal(Int32.Parse(txtPerminantMakeup.Text)).ToString();
            GetTotal();       
        }
        private void btnAddPerminantMakeup_Click(object sender, EventArgs e)
        {           
            txtPerminantMakeup.Text = AddTotal(Int32.Parse(txtPerminantMakeup.Text)).ToString();
            GetTotal();
        }
        private int AddTotal(int intAdd)
        {
            return intAdd + 1;//add one to the text boxes 
        }
        private int MinusTotal(int intMinus)
        {
            int intSubtract = intMinus;//take one away from the text boxes and stop taking integers away when the text box is 0
            if (intSubtract > 0)
            {
                intSubtract--;
            }
            intMinus = intSubtract;
            return intMinus;
        }
        
        private string GetTotal()//get the total of all serviecs selected and return to the button
        {
            int intTotal;
           
            intTotal = ((Int32.Parse(txtHairStyling.Text) * 60) + (Int32.Parse(txtPerminantMakeup.Text) * 200) + (Int32.Parse(txtManicure.Text) * 35) + (Int32.Parse(txtMakeover.Text) * 125));           
            return lblTotal.Text = intTotal.ToString("N2");
            
        }    
        private string Discount()//this gets the discount and adds it to the total
        {
            double dbl10 = .9;
            double dbl20 = .8;
            double dblLableTotal = double.Parse(lblTotal.Text);
            double dblTotal = 0;
            if (rdb10.Checked == true)
            {
                dblTotal = dbl10 * dblLableTotal;
            }
            else if(rdb20.Checked == true)
            {
                dblTotal = dbl20 * dblLableTotal;
            }
            return lblTotal.Text = dblTotal.ToString();
        }

        private void rdb10_CheckedChanged(object sender, EventArgs e)
        {
            GetTotal();
            Discount();
        }

        private void rdb20_CheckedChanged(object sender, EventArgs e)
        {
            GetTotal();
            Discount();
        }

        private void rdbNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes the application
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            if (txtHairStyling.Text  == "0")//this checks to see if a service has been selected
            {
                if ( txtMakeover.Text == "0" )
                {
                    if(txtManicure.Text == "0")
                    {
                        if(txtPerminantMakeup.Text == "0")
                        {
                            MessageBox.Show("Please Select a Service","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
           
            if (rdb10.Checked | rdb20.Checked | rdbNoDiscount.Checked == true)
            {//this checks to see if a radio button is selected
            }
            else
            {
                MessageBox.Show("Please Select a Discount","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            double dblTaxTip;
            double dblTotal = double.Parse(lblTotal.Text);
            double dblTip;
            try
            {
                 dblTip = double.Parse(txtTip.Text);//this makes sure the user enter a numerical value in the tip field
            }
            catch 
            {
                MessageBox.Show("Please Enter a Valid Dollar Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTip.Focus();
                return;
            }
          
            if (dblTip >= 100)//checks to makes sure the tip is correct
           {
               MessageBox.Show("Is the Tip Correct?","ImageConsulting",MessageBoxButtons.OK,MessageBoxIcon.Question);
               return;
           }
            
            
            const double dblTax = 1.08;//this section caluculates the tip, tax, and sum total and displays the result

            dblTaxTip = (dblTotal + dblTip ) * dblTax;
            lblTaxTip.Text = dblTaxTip.ToString("N2");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//clears all lables and text boxes
           
            txtPerminantMakeup.Text = "0";
            txtManicure.Text = "0";
            txtMakeover.Text = "0";
            txtHairStyling.Text = "0";
            
            lblTaxTip.Text = "0.00";
            txtTip.Text = "0.00";
            rdb10.Checked = false;
            rdb20.Checked = false;
            rdbNoDiscount.Checked = false;
            lblTotal.Text = "0.00";
        }
    }
}
