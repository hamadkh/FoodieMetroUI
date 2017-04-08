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


        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HomeSettings();

        }

        /*
         * Initial settings for home screen of applicaiton 
         * maximizes the windows form application
         * set color of background 
        */

        private void HomeSettings()
        {
            //WindowState = FormWindowState.Maximized;
            Color color = ColorTranslator.FromHtml("#1a1a1a"); // this assumes an ARGB value 
            this.BackColor = color;
            this.CancelButton = this.btnExit;
        }

        /*
         * MetroUI FrameWork tools implementations 
         */

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.BackColor = Color.Red;
        }

        private void beveragesTile_Click(object sender, EventArgs e)
        {
            foodieTab.SelectTab(0);
        }

        private void appatizersTile_Click(object sender, EventArgs e)
        {
            foodieTab.SelectTab(1);
        }

        private void EntreeTile_Click(object sender, EventArgs e)
        {
            foodieTab.SelectTab(2);
        }

        private void dessertsTile_Click(object sender, EventArgs e)
        {
            foodieTab.SelectTab(3);
        }

        /*
         * WinformUI common tools implementation  
         */



    }
}
