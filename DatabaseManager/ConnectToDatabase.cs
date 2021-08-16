using System;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class ConnectToDatabase : Form
    {
        SQLControl sql = new SQLControl();
        public ConnectToDatabase()
        {
            InitializeComponent();
            gShadowForm.SetShadowForm(this);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerName = txtServer.Text;
            Properties.Settings.Default.DatabaseName = txtDatabase.Text;
            Properties.Settings.Default.UserName = txtUsername.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
