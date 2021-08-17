using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class AdminCenter : Form
    {
        public AdminCenter()
        {
            InitializeComponent();
            navHome.PerformClick();
        }

        void ResetSelectedNavItem(object sender, EventArgs e)
        {
            foreach (Guna2TileButton c in panelControlContainer.Controls)
            {
                c.ShadowDecoration.Enabled = false;
                c.Size = new Size(56, 53);
                c.ImageSize = new Size(40, 40);
                //235, 84, 92
                c.FillColor = Color.FromArgb(235, 84, 92);
            }
            (sender as Guna2TileButton).ShadowDecoration.Enabled = true;
            (sender as Guna2TileButton).Size = new Size(60,57);
            (sender as Guna2TileButton).ImageSize = new Size(45, 45);
            (sender as Guna2TileButton).FillColor = ColorTranslator.FromHtml("#FABC0A");
            
        }
    }
}
