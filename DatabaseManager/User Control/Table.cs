using System;
using System.Windows.Forms;

namespace DatabaseManager.User_Control
{
    public partial class Table : UserControl
    {
        SQLControl sql = new SQLControl();
        String tableName;
        public Table(String tableName)
        {
            InitializeComponent();
            this.tableName = tableName;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            lblTableName.Text = tableName;
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Query("DELETE FROM " + tableName);
                if (sql.HasException(true)) return;
                MessageBox.Show("Wipe successful");
            }
            catch (Exception) { }
        }
    }
}
