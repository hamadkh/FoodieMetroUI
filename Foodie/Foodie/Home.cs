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

        /* Add to Order buttons 
         */
        private void addbtnLemonade_Click(object sender, EventArgs e)
        {

        }

        private void btnaddGinger_Click(object sender, EventArgs e)
        {

        }

        private void addbtnIceTea_Click(object sender, EventArgs e)
        {

        }

        private void addbtnWhite_Click(object sender, EventArgs e)
        {

        }

        private void addbtnWine_Click(object sender, EventArgs e)
        {

        }

        private void addbtnCoke_Click(object sender, EventArgs e)
        {

        }

        /* Remove button for order
        */
        private void removeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
