using DatabaseManager.User_Control;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class Tables : Form
    {

        SQLControl sql = new SQLControl();

        public Tables()
        {
            InitializeComponent();

        }

        //new Thread(() =>
        //    {
        //    this.Invoke(new MethodInvoker(delegate
        //    {

        //    })
        //    );
        //}).Start();
        private void Tables_Load(object sender, EventArgs e)
        {
            new Thread(() =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        sql.Query("SELECT TABLE_NAME FROM dbEAAATS.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");
                        if (sql.HasException(true)) return;
                        foreach (DataRow dr in sql.DBDT.Rows)
                        {
                            flpTablesList.Controls.Add(new Table(dr["TABLE_NAME"].ToString()));
                        }
                    })
                    );
                }).Start();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    flpTablesList.Controls.Clear();
                    foreach (Control c in flpTablesList.Controls)
                    {
                        c.Dispose();
                    }
                    sql.Query("SELECT TABLE_NAME FROM dbEAAATS.INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME LIKE '%" + txtSearch.Text + "%' AND TABLE_TYPE = 'BASE TABLE'");
                    if (sql.HasException(true)) return;
                    foreach (DataRow dr in sql.DBDT.Rows)
                    {
                        flpTablesList.Controls.Add(new Table(dr["TABLE_NAME"].ToString()));
                    }
                })
                );
            }).Start();
        }
    }
}
