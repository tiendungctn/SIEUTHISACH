using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiSach.DAL
{
    class DesignForm
    {
        public static Form vForm = null;
        public void EditCollum
            (ref DataGridView dt, string column, bool Vi, string NameCollum)
        {
            dt.Columns[column].Visible = Vi;
            dt.Columns[column].HeaderText = NameCollum;
        }
        public Button BtnChange;
        public void ColorChange(ref Button _vbutton)
        {
            if (_vbutton.BackColor == Color.Gainsboro)
                _vbutton.BackColor = Color.LightCoral;
            else _vbutton.BackColor = Color.Gainsboro;
            BtnChange = _vbutton;
        }

        public void AlignCenterToScreen()
        {
            Screen screen = Screen.FromControl(vForm);

            Rectangle workingArea = screen.WorkingArea;
            vForm.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - vForm.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - vForm.Height) / 2)
            };
        }
    }
}
