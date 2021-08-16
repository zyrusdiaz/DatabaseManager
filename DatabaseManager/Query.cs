using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class Query : Form
    {
        SQLControl sql = new SQLControl();
        public Query()
        {
            InitializeComponent();
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
        private void btnRun_Click(object sender, EventArgs e)
        {
            new Thread(() =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        try
                        {
                            if (txtQuery.Text.Trim() != "")
                            {
                                dgvQueryResult.DataSource = null;
                                sql.Query(txtQuery.Text);
                                if (sql.HasException(true)) return;
                                dgvQueryResult.DataSource = sql.DBDT;
                            }

                        }
                        catch (Exception) { }
                    })
                    );
                }).Start();

        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnRun.PerformClick();
            }
        }

        private void loadTablesOnListBox()
        {
            new Thread(() =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    sql.Query("SELECT TABLE_NAME FROM dbEAAATS.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");
                    if (sql.HasException(true)) return;
                    foreach (DataRow dr in sql.DBDT.Rows)
                    {
                        listBox1.Items.Add(dr["TABLE_NAME"].ToString());
                    }
                })
                );
            }).Start();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            loadTablesOnListBox();
        }
        //new Thread(() =>
        //    {
        //    this.Invoke(new MethodInvoker(delegate
        //    {

        //    })
        //    );
        //}).Start();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            new Thread(() =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        dgvQueryResult.DataSource = null;
                        string tableName = listBox1.GetItemText(listBox1.SelectedItem);
                        string query = "SELECT * FROM " + tableName;
                        sql.Query(query);
                        if (sql.HasException(true)) return;
                        dgvQueryResult.DataSource = sql.DBDT;
                        txtQuery.Text = query;
                    })
                    );
                }).Start();

        }
    }
}
