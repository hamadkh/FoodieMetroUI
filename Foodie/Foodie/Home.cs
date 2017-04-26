using System;
using System.Drawing;
using System.Windows.Forms;

namespace Foodie
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        /*
         * Global Variables  
         * 
         */

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

        /* Remove button for order
        */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in orderListView.SelectedItems)
            {
                orderListView.Items.Remove(eachItem);
            }
        }

        /* Add buttons for order bevrages
        */

        private void addbtnLemonade_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] {"Lemonade", priceNonAlcBev.ToString("$0.00")}));
        }

        private void addbtnGingerale_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Gingerale", priceNonAlcBev.ToString("$0.00") }));
        }

        private void addbtnIcetea_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Ice Tea", priceNonAlcBev.ToString("$0.00") }));
        }

        private void addbtnWine_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Wine", priceWine.ToString("$0.00") }));
        }

        private void addbtnRedwine_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Wine", priceWine.ToString("$0.00") }));
        }

        private void addbtnCoke_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Coke", priceNonAlcBev.ToString("$0.00") }));
        }

        /* Add buttons for order Entree
        */

        private void addbtnCalazone_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Calazone", priceCalazone.ToString("$0.00") }));
        }

        private void addbtnFettuccine_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Fettuccine", priceFetticuni.ToString("$0.00") }));
        }

        private void addbtnNoodles_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Noodles", priceNoodlesSep.ToString("$0.00") }));
        }

        private void addbtnPizza_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Pizza", pricePizza.ToString("$0.00") }));
        }

        private void addbtnSpaghetti_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Spagettie", priceNoodlesSep.ToString("$0.00") }));
        }

        private void addbtnSquid_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Squid", priceSquid.ToString("$0.00") }));
        }

        /* Add buttons for order Desserts
        */

        private void addbtnbrownie_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Brownie", priceCake.ToString("$0.00") }));
        }

        private void addbtnCakebb_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Blue Berry Cake", priceCake.ToString("$0.00") }));
        }

        private void addbtnChurros_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Churros", priceChurrosCreampuffs.ToString("$0.00") }));
        }

        private void addbtnCreampuff_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Cream Puffs", priceChurrosCreampuffs.ToString("$0.00") }));
        }

        private void addbtnOrangecake_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Orange Cake", priceCake.ToString("$0.00") }));
        }

        private void addbtnItalianCake_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Italian Cake", priceCake.ToString("$0.00") }));
        }


        /* Add buttons for order App
        */
        private void addbtnMeatball_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Ravioli", priceRavioli.ToString("$0.00") }));
        }

        private void addbtnCalamari_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Calamari", priceCalWingShrimp.ToString("$0.00") }));
        }

        private void addbtnChicken_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Wings", priceCalWingShrimp.ToString("$0.00") }));
        }

        private void addbtnShrimp_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Shrimp", priceCalWingShrimp.ToString("$0.00") }));
        }

        private void addbtnTomatoes_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Tomatoes", priceBreadTomato.ToString("$0.00") }));
        }

        private void btnBreadapp_Click(object sender, EventArgs e)
        {
            orderListView.Items.Add(new ListViewItem(new string[] { "Calamari", priceBreadTomato.ToString("$0.00") }));
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
    }
}
