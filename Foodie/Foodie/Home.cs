using System;
using System.Drawing;

namespace Foodie
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        /*
         * Global Variables  
         * 
         */

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

        }

        /* Add buttons for order bevrages
        */

        private void addbtnLemonade_Click(object sender, EventArgs e)
        {

        }

        private void addbtnGingerale_Click(object sender, EventArgs e)
        {

        }

        private void addbtnIcetea_Click(object sender, EventArgs e)
        {

        }

        private void addbtnWine_Click(object sender, EventArgs e)
        {

        }

        private void addbtnRedwine_Click(object sender, EventArgs e)
        {

        }

        private void addbtnCoke_Click(object sender, EventArgs e)
        {

        }

        /* Add buttons for order Appatizers
        */

        private void addbtnCalazone_Click(object sender, EventArgs e)
        {

        }

        private void addbtnFettuccine_Click(object sender, EventArgs e)
        {

        }

        private void addbtnNoodles_Click(object sender, EventArgs e)
        {

        }

        private void addbtnPizza_Click(object sender, EventArgs e)
        {

        }

        private void addbtnSpaghetti_Click(object sender, EventArgs e)
        {

        }

        private void addbtnSquid_Click(object sender, EventArgs e)
        {

        }

        /* Add buttons for order Desserts
        */

        private void addbtnbrownie_Click(object sender, EventArgs e)
        {

        }

        private void addbtnCakebb_Click(object sender, EventArgs e)
        {

        }

        private void addbtnChurros_Click(object sender, EventArgs e)
        {

        }

        private void addbtnCreampuff_Click(object sender, EventArgs e)
        {

        }

        private void addbtnOrangecake_Click(object sender, EventArgs e)
        {

        }

        private void addbtnItalianCake_Click(object sender, EventArgs e)
        {

        }

        /* Add buttons for order Entree
        */

        private void addbtnCalamari_Click(object sender, EventArgs e)
        {

        }

        private void addbtnChicken_Click(object sender, EventArgs e)
        {

        }

        private void addbtnMeatball_Click(object sender, EventArgs e)
        {

        }

        private void addbtnPastries_Click(object sender, EventArgs e)
        {

        }

        private void addbtnShrimp_Click(object sender, EventArgs e)
        {

        }

        private void addbtnTomatoes_Click(object sender, EventArgs e)
        {

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
