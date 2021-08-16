using System.Drawing;
using System.Windows.Forms;

namespace DatabaseManager
{
    class ButtonSelectionSwitcher
    {
        //Color col = ColorTranslator.FromHtml("#FFCC66");

        public Control switchSelected(Control current, Control selected)
        {

            current.BackColor = Color.FromArgb(73, 73, 73);
            current.ForeColor = Color.White;

            selected.ForeColor = Color.Black;
            selected.BackColor = Color.White;
            return selected;

        }
    }
}
