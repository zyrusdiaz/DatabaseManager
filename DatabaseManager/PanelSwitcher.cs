using System.Windows.Forms;

namespace DatabaseManager
{
    class PanelSwitcher
    {
        public void switchView(Panel pnl, Form formToShow)
        {
            pnl.Controls.Clear();
            foreach (Control c in pnl.Controls)
            {
                c.Dispose();
            }
            formToShow.TopLevel = false;
            formToShow.AutoScroll = true;
            pnl.Controls.Add(formToShow);
            formToShow.Show();
        }
    }
}
