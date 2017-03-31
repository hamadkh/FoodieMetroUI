namespace Foodie
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.metroUImanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.beveragesTile = new MetroFramework.Controls.MetroTile();
            this.appatizersTile = new MetroFramework.Controls.MetroTile();
            this.EntreeTile = new MetroFramework.Controls.MetroTile();
            this.dessertsTile = new MetroFramework.Controls.MetroTile();
            this.saladsTile = new MetroFramework.Controls.MetroTile();
            this.winecTiles = new MetroFramework.Controls.MetroTile();
            this.kidsTile = new MetroFramework.Controls.MetroTile();
            this.sidesTile = new MetroFramework.Controls.MetroTile();
            this.foodieTab = new MetroFramework.Controls.MetroTabControl();
            this.bevTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroUImanager)).BeginInit();
            this.foodieTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroUImanager
            // 
            this.metroUImanager.Owner = this;
            this.metroUImanager.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // beveragesTile
            // 
            this.beveragesTile.ActiveControl = null;
            this.beveragesTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beveragesTile.Location = new System.Drawing.Point(23, 101);
            this.beveragesTile.Name = "beveragesTile";
            this.beveragesTile.Size = new System.Drawing.Size(116, 40);
            this.beveragesTile.TabIndex = 4;
            this.beveragesTile.Text = "Beverages";
            this.beveragesTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.beveragesTile.UseSelectable = true;
            this.beveragesTile.Click += new System.EventHandler(this.beveragesTile_Click);
            // 
            // appatizersTile
            // 
            this.appatizersTile.ActiveControl = null;
            this.appatizersTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appatizersTile.Location = new System.Drawing.Point(23, 227);
            this.appatizersTile.Name = "appatizersTile";
            this.appatizersTile.Size = new System.Drawing.Size(116, 39);
            this.appatizersTile.TabIndex = 6;
            this.appatizersTile.Text = "Appatizers";
            this.appatizersTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appatizersTile.UseSelectable = true;
            this.appatizersTile.Click += new System.EventHandler(this.appatizersTile_Click);
            // 
            // EntreeTile
            // 
            this.EntreeTile.ActiveControl = null;
            this.EntreeTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntreeTile.Location = new System.Drawing.Point(23, 272);
            this.EntreeTile.Name = "EntreeTile";
            this.EntreeTile.Size = new System.Drawing.Size(116, 37);
            this.EntreeTile.TabIndex = 7;
            this.EntreeTile.Text = "Entree";
            this.EntreeTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EntreeTile.UseSelectable = true;
            this.EntreeTile.Click += new System.EventHandler(this.EntreeTile_Click);
            // 
            // dessertsTile
            // 
            this.dessertsTile.ActiveControl = null;
            this.dessertsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dessertsTile.Location = new System.Drawing.Point(23, 315);
            this.dessertsTile.Name = "dessertsTile";
            this.dessertsTile.Size = new System.Drawing.Size(116, 37);
            this.dessertsTile.TabIndex = 8;
            this.dessertsTile.Text = "Desserts";
            this.dessertsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dessertsTile.UseSelectable = true;
            this.dessertsTile.Click += new System.EventHandler(this.dessertsTile_Click);
            // 
            // saladsTile
            // 
            this.saladsTile.ActiveControl = null;
            this.saladsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saladsTile.Location = new System.Drawing.Point(23, 358);
            this.saladsTile.Name = "saladsTile";
            this.saladsTile.Size = new System.Drawing.Size(116, 42);
            this.saladsTile.TabIndex = 9;
            this.saladsTile.Text = "Salads";
            this.saladsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saladsTile.UseSelectable = true;
            this.saladsTile.Click += new System.EventHandler(this.saladsTile_Click);
            // 
            // winecTiles
            // 
            this.winecTiles.ActiveControl = null;
            this.winecTiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winecTiles.Location = new System.Drawing.Point(23, 147);
            this.winecTiles.Name = "winecTiles";
            this.winecTiles.Size = new System.Drawing.Size(116, 38);
            this.winecTiles.TabIndex = 10;
            this.winecTiles.Text = "Wine/Cocktails";
            this.winecTiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winecTiles.UseSelectable = true;
            this.winecTiles.Click += new System.EventHandler(this.winecTiles_Click);
            // 
            // kidsTile
            // 
            this.kidsTile.ActiveControl = null;
            this.kidsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kidsTile.Location = new System.Drawing.Point(23, 453);
            this.kidsTile.Name = "kidsTile";
            this.kidsTile.Size = new System.Drawing.Size(116, 40);
            this.kidsTile.TabIndex = 11;
            this.kidsTile.Text = "Kids";
            this.kidsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kidsTile.UseSelectable = true;
            this.kidsTile.Click += new System.EventHandler(this.kidsTile_Click);
            // 
            // sidesTile
            // 
            this.sidesTile.ActiveControl = null;
            this.sidesTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidesTile.Location = new System.Drawing.Point(23, 499);
            this.sidesTile.Name = "sidesTile";
            this.sidesTile.Size = new System.Drawing.Size(116, 37);
            this.sidesTile.TabIndex = 12;
            this.sidesTile.Text = "Sides";
            this.sidesTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sidesTile.UseSelectable = true;
            this.sidesTile.Click += new System.EventHandler(this.sidesTile_Click);
            // 
            // foodieTab
            // 
            this.foodieTab.Controls.Add(this.bevTab);
            this.foodieTab.Controls.Add(this.metroTabPage2);
            this.foodieTab.Controls.Add(this.metroTabPage1);
            this.foodieTab.Controls.Add(this.metroTabPage3);
            this.foodieTab.Controls.Add(this.metroTabPage4);
            this.foodieTab.Controls.Add(this.metroTabPage5);
            this.foodieTab.Controls.Add(this.metroTabPage6);
            this.foodieTab.Controls.Add(this.metroTabPage7);
            this.foodieTab.Location = new System.Drawing.Point(145, 65);
            this.foodieTab.Margin = new System.Windows.Forms.Padding(5);
            this.foodieTab.Name = "foodieTab";
            this.foodieTab.SelectedIndex = 0;
            this.foodieTab.Size = new System.Drawing.Size(972, 565);
            this.foodieTab.Style = MetroFramework.MetroColorStyle.Orange;
            this.foodieTab.TabIndex = 13;
            this.foodieTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodieTab.UseSelectable = true;
            // 
            // bevTab
            // 
            this.bevTab.HorizontalScrollbarBarColor = true;
            this.bevTab.HorizontalScrollbarHighlightOnWheel = false;
            this.bevTab.HorizontalScrollbarSize = 10;
            this.bevTab.Location = new System.Drawing.Point(4, 38);
            this.bevTab.Name = "bevTab";
            this.bevTab.Size = new System.Drawing.Size(964, 523);
            this.bevTab.TabIndex = 0;
            this.bevTab.VerticalScrollbarBarColor = true;
            this.bevTab.VerticalScrollbarHighlightOnWheel = false;
            this.bevTab.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage4.TabIndex = 4;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage5.TabIndex = 5;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage6.TabIndex = 6;
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(955, 499);
            this.metroTabPage7.TabIndex = 7;
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.Location = new System.Drawing.Point(23, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 33);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 629);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.foodieTab);
            this.Controls.Add(this.sidesTile);
            this.Controls.Add(this.kidsTile);
            this.Controls.Add(this.winecTiles);
            this.Controls.Add(this.saladsTile);
            this.Controls.Add(this.dessertsTile);
            this.Controls.Add(this.EntreeTile);
            this.Controls.Add(this.appatizersTile);
            this.Controls.Add(this.beveragesTile);
            this.Name = "Home";
            this.Text = "Foodie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroUImanager)).EndInit();
            this.foodieTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroUImanager;
        private MetroFramework.Controls.MetroTile beveragesTile;
        private MetroFramework.Controls.MetroTile sidesTile;
        private MetroFramework.Controls.MetroTile kidsTile;
        private MetroFramework.Controls.MetroTile winecTiles;
        private MetroFramework.Controls.MetroTile saladsTile;
        private MetroFramework.Controls.MetroTile dessertsTile;
        private MetroFramework.Controls.MetroTile EntreeTile;
        private MetroFramework.Controls.MetroTile appatizersTile;
        private MetroFramework.Controls.MetroTabControl foodieTab;
        private MetroFramework.Controls.MetroTabPage bevTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}

