using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    class CreateCursor
    {
        public static Bitmap btm = new Bitmap((Properties.Resources.a), 48, 48);
        public static Cursor cur = new Cursor(btm.GetHicon());
    }
}
