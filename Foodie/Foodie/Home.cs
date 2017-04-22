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
    }
}
