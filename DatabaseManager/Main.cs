using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class Main : Form
    {
        ButtonSelectionSwitcher bss = new ButtonSelectionSwitcher();
        PanelSwitcher ps = new PanelSwitcher();
        SQLControl sql = new SQLControl();
        Control current, selected;

        public Main()
        {
            InitializeComponent();
            current = label2;


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            new ConnectToDatabase().ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        void switchButton(object sender, EventArgs e)
        {
            selected = (sender as Control);
            bss.switchSelected(current, selected);
            current = selected;

            switch ((sender as Control).Text)
            {
                case "QUERY":
                    ps.switchView(pnlSwitcher, new Query());
                    break;
                case "TABLES":
                    ps.switchView(pnlSwitcher, new Tables());
                    break;
                case "IMPORT DB":
                    String path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    MessageBox.Show(path);
                    Process.Start(path + "\\select_db_file.bat");
                    break;
                case "EXPORT DB":
                    break;
                case "RESET DATABASE":
                    break;

            }
        }
    }
}
