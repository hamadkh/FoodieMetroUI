using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Foodie
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        /*
         * Global Variables  
         * 
         */

        /* table details*/
        private int tableNum = 1;
        int countnumOrders = 0;

        private double totalSumOrder=0;
        private double totalValueOrder=0;
        private double taxOver = 0;
        private double subtotalOver = 0;

        /*Bevrages price*/
        private double priceNonAlcBev = 1.99;
        private double priceWine = 6.50;
        /*app prices*/
        private double priceCalWingShrimp = 5.99;
        private double priceRavioli = 3.50;
        private double priceBreadTomato = 2.99;
        /*dessert prices*/
        private double priceCake = 4.99;
        private double priceChurrosCreampuffs = 3.99;
        /*Entree prices*/
        private double pricePizza = 11.99;
        private double priceCalazone = 13.99;
        private double priceFetticuni = 15.99;
        private double priceNoodlesSep = 9.99;
        private double priceSquid = 16.99;

        /* Totals */
        private double totalSum = 0;
        private double totalTax = 0;
        private double totalSubtotal = 0;
        public readonly double taxrate = 6.99;

        /*Events variables*/

        private bool _TypedIntoCVV;
        private bool _TypedIntoCard;
        private bool _TypedIntoName;
        private bool _TypedIntoZip;
        private bool _TypedIntoPhone;


        public Home()
        {
            InitializeComponent();
        }

        /* Tiles for the main menu options 
         * tab selects for each button
        */
        private void Home_Load(object sender, EventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#ffffff"); // this assumes an ARGB value 
            orderListView.BackColor = color;
            menuTab.SelectTab(0);
            waiterSpinner.Visible = false;
            waiterlbl.Visible = false;
            reqbtnComplete.Visible = false;

            for(int i=0;i<12;i++)
            {
                monthCombo.Items.Add(i+1);
            }

            for (int i = 2017; i < 2024; i++)
            {
                yearCombo.Items.Add(i + 1);
            }
        }

        private void bevTile_Click(object sender, EventArgs e)
        {
            menuTab.SelectTab(0);
        }

        private void appTile_Click(object sender, EventArgs e)
        {
            menuTab.SelectTab(1);
        }

        private void entTile_Click(object sender, EventArgs e)
        {
            menuTab.SelectTab(2);
        }

        private void dessertTile_Click(object sender, EventArgs e)
        {
            menuTab.SelectTab(3);
        }

        /*Check out tile & functionality */
        private void checkOutTile_Click(object sender, EventArgs e)
        {
            menuTab.SelectTab(5);
            fullnametxtBox.Text = "Full name";
            cardtxtBox.Text = "Card Number";
            zipcode.Text = "Zip code";
            cvvtxtBox.Text = "CVV/CVC";
            phonetxt.Text = "Phone Number";

            _TypedIntoCVV= _TypedIntoCard =_TypedIntoName = _TypedIntoZip=false;

            lblPaytotal.Text = lblSubtotalorder.Text;

        }

        /*****************************************************END OF CHECK OUT FUNCTIONALITY**************************************/

        /* Remove button for order
        */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in orderListView.SelectedItems)
            {
                orderListView.Items.Remove(eachItem);
            }
            totalCalculations();
        }

        private void btnclearListbox_Click(object sender, EventArgs e)
        {
            orderListView.Items.Clear();
            totalCalculations();
        }
        /* Add buttons for order bevrages
        */

        private void addbtnLemonade_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] {"Lemonade", priceNonAlcBev.ToString("0.00")}));
            totalCalculations();
        }

        private void addbtnGingerale_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Gingerale", priceNonAlcBev.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnIcetea_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Ice Tea", priceNonAlcBev.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnWine_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Wine", priceWine.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnRedwine_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Wine", priceWine.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnCoke_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Coke", priceNonAlcBev.ToString("0.00") }));
            totalCalculations();
        }

        /* Add buttons for order Entree
        */

        private void addbtnCalazone_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Calazone", priceCalazone.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnFettuccine_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Fettuccine", priceFetticuni.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnNoodles_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Noodles", priceNoodlesSep.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnPizza_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Pizza", pricePizza.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnSpaghetti_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Spagettie", priceNoodlesSep.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnSquid_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Squid", priceSquid.ToString("0.00") }));
            totalCalculations();
        }

        /* Add buttons for order Desserts
        */

        private void addbtnbrownie_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Brownie", priceCake.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnCakebb_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Blue Berry Cake", priceCake.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnChurros_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Churros", priceChurrosCreampuffs.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnCreampuff_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Cream Puffs", priceChurrosCreampuffs.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnOrangecake_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Orange Cake", priceCake.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnItalianCake_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Italian Cake", priceCake.ToString("0.00") }));
            totalCalculations();
        }


        /* Add buttons for order App
        */
        private void addbtnMeatball_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Ravioli", priceRavioli.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnCalamari_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Calamari", priceCalWingShrimp.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnChicken_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Wings", priceCalWingShrimp.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnShrimp_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Shrimp", priceCalWingShrimp.ToString("0.00") }));
            totalCalculations();
        }

        private void addbtnTomatoes_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Tomatoes", priceBreadTomato.ToString("0.00") }));
            totalCalculations();
        }

        private void btnBreadapp_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Calamari", priceBreadTomato.ToString("0.00") }));
            totalCalculations();
        }

        /* Waiter stuff
         */

        private void waiterTile_Click(object sender, EventArgs e)
        {
            menuTab.SelectTab(4);
        }

        private void callbtnWaiter_Click(object sender, EventArgs e)
        {
            try
            {
                Random waittime = new Random();
                int time = waittime.Next(1, 6);
                if (checkRefill.Checked == true || otherCheck.Checked == true || checkNapkins.Checked == true || saltpeppCheck.Checked == true)
                {
                    disableRequests();
                    waiterSpinner.Visible = true;
                    waiterlbl.Text = "Your request has been sent \nThe waiter will be at your table in " + time + " min" + "\n Press button below after waiter has arrived.";
                    waiterlbl.Visible = true;
                    reqbtnComplete.Visible = true;
                }
            }
            catch (Exception)
            {
            }
        }


        private void disableRequests()
        {
            checkNapkins.Enabled = false;
            checkRefill.Enabled = false;
            otherCheck.Enabled = false;
            saltpeppCheck.Enabled = false;
            callbtnWaiter.Enabled = false;
        }
        private void EnableRequests()
        {
            checkNapkins.Enabled = true;
            checkRefill.Enabled = true;
            otherCheck.Enabled = true;
            saltpeppCheck.Enabled = true;
            callbtnWaiter.Enabled = true;
        }

        private void reqbtnComplete_Click(object sender, EventArgs e)
        {
            EnableRequests();
            waiterlbl.Visible = false;
            waiterSpinner.Visible = false;
            reqbtnComplete.Visible = false;
        }
        /********************************** END OF WAITER STUFF ************************************************/

        private void totalCalculations()
        {
            double value = 0;
            totalSum = 0;
            try
            {
                foreach (ListViewItem o in orderListView.Items)
                {
                    if (double.TryParse(o.SubItems[1].Text, out value))
                    {
                        totalSum += value;
                    }

                }

                lbltotalcalc.Text = totalSum.ToString("$0.00");

                totalTax = Tax(totalSum);
                lbltaxcalc.Text = totalTax.ToString("$0.00");

                totalSubtotal = totalSum + totalTax;
                lblsubtotalcalc.Text = totalSubtotal.ToString("$0.00");

            }
            catch (Exception)
            {

          
            }
          
        }

        private void totalOderCalculation()
        {
          
            try
            {
                foreach (ListViewItem o in orderedItemslist.Items)
                {
                    if (double.TryParse(o.SubItems[1].Text, out totalValueOrder))
                    {
                        totalSumOrder += totalValueOrder;
                    }

                }

                lblorderTotal.Text = totalSumOrder.ToString("$0.00");

                taxOver = Tax(totalSumOrder);
                lblorderTax.Text = taxOver.ToString("$0.00");

                subtotalOver = totalSumOrder + taxOver;
                lblSubtotalorder.Text = subtotalOver.ToString("$0.00");

            }
            catch (Exception)
            {


            }
        }

        private double Tax(double total)
        {
            double taxedamount=0;
            taxedamount = (total / 100) * taxrate;
            return taxedamount;
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            fullnametxtBox.Text = "";
        }


        /*Events*/

        private void cvvtxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _TypedIntoCVV = true;
        }

        private void cardtxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _TypedIntoCard = true;

        }

        private void fullnametxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
            _TypedIntoName = true;
        }

        private void zipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _TypedIntoZip = true;
        }

        private void fullnametxtBox_TextChanged(object sender, EventArgs e)
        {
            _TypedIntoName = !String.IsNullOrEmpty(fullnametxtBox.Text);
            _TypedIntoName = true;
        }

        private void fullnametxtBox_Click(object sender, EventArgs e)
        {
            if (!_TypedIntoName) { fullnametxtBox.Text = ""; }
        }

        private void cardtxtBox_TextChanged(object sender, EventArgs e)
        {
            _TypedIntoCard = !String.IsNullOrEmpty(cardtxtBox.Text);
        }

        private void cvvtxtBox_TextChanged(object sender, EventArgs e)
        {
            _TypedIntoCVV = !String.IsNullOrEmpty(cvvtxtBox.Text);
        }

        private void zipcode_TextChanged(object sender, EventArgs e)
        {
            _TypedIntoZip = !String.IsNullOrEmpty(zipcode.Text);
        }

        private void cardtxtBox_Click(object sender, EventArgs e)
        {
            if (!_TypedIntoCard) { cardtxtBox.Text = ""; }
        }

        private void cvvtxtBox_Click(object sender, EventArgs e)
        {
            if (!_TypedIntoCVV) { cvvtxtBox.Text = ""; }
        }

        private void zipcode_Click(object sender, EventArgs e)
        {
            if (!_TypedIntoZip) { zipcode.Text = ""; }
        }

        private void phonetxt_Click(object sender, EventArgs e)
        {
            if (!_TypedIntoPhone) { phonetxt.Text = ""; }
        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {
            _TypedIntoPhone = !String.IsNullOrEmpty(phonetxt.Text);

        }

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            _TypedIntoPhone = true;
        }

        private void cvvtxtBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cvvtxtBox.Text.Length == 0) return;

            // Validate text, cancel when not valid and show error to user
            if (cvvtxtBox.Text.Length > 4)
            {
                e.Cancel = true;
                MessageBox.Show("CVV is only 4-digits");
            }
        }

        private void zipcode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (zipcode.Text.Length == 0) return;

            // Validate text, cancel when not valid and show error to user
            if (zipcode.Text.Length > 5)
            {
                e.Cancel = true;
                MessageBox.Show("CVV is only 4-digits");
            }
        }

        private void payTile_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want complete this transaction ?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               MessageBox.Show("Yor receipt will be texted to you! Thankyou !");
               endSession();
            }
        }

        /*ORDER STUFF*/
        private void orderTile_Click(object sender, EventArgs e)
        {
            if (orderListView.Items.Count == 0)
            {
                MessageBox.Show("Please order atleast 1 item before placing order !!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to place the Order?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    menuTab.SelectTab(6);
                    //orderedItemslist.Items.Add("THIS IS YOUR " + countnumOrders + " ORDER");
                    foreach (ListViewItem item in orderListView.Items)
                    {
                        orderedItemslist.Items.Add(new ListViewItem(new string[] {item.SubItems[0].Text, item.SubItems[1].Text }));
                    }
                    countnumOrders++;
                    orderListView.Items.Clear();
                    totalCalculations();
                    totalOderCalculation();
                }
            }

        }

        /*********************************************************************END OF ORDER ***********************************************************************/

        private void endSession()
        {
            string filename =  "receipt"+ tableNum + ".txt";
            using (StreamWriter writetext = new StreamWriter(filename))
            {
                writetext.WriteLine(DateTime.Now);
                writetext.WriteLine("Table No: "+tableNum);
                writetext.WriteLine("Total: " + totalSubtotal);
                writetext.WriteLine("Total payed with Tip: ");
                foreach (ListViewItem o in orderListView.Items)
                    {
                        writetext.WriteLine(o.ToString());
                        writetext.WriteLine(o.SubItems[1]);
                    }
            }
            tableNum++;
            menuTab.SelectTab(0);
            orderListView.Items.Clear();
            totalCalculations();
        }
    }
}
