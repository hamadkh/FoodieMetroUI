using System;
using System.Drawing;
using System.Windows.Forms;


namespace Foodie
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
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
            WindowState = FormWindowState.Maximized;
            Color color = ColorTranslator.FromHtml("#1a1a1a"); // this assumes an ARGB value 
            this.BackColor = color;
            this.CancelButton = this.btnExit;
        }





        /*
         * MetroUI FrameWork tools implementations 
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.BackColor = Color.Red;
        }

        private void bevragesTile_Click(object sender, EventArgs e)
        {
            using (Bevrages frm = new Bevrages())
            {
                frm.ShowDialog();
            }
        }

        private void winecTiles_Click(object sender, EventArgs e)
        {

        }

        private void appatizersTile_Click(object sender, EventArgs e)
        {

        }

        private void EntreeTile_Click(object sender, EventArgs e)
        {

        }

        private void dessertsTile_Click(object sender, EventArgs e)
        {

        }

        private void saladsTile_Click(object sender, EventArgs e)
        {

        }

        private void kidsTile_Click(object sender, EventArgs e)
        {

        }

        private void sidesTile_Click(object sender, EventArgs e)
        {

        }


        /*
         * WinformUI common tools implementation  
         */



    }
}
