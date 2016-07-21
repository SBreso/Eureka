using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace WpfApplication1
{
    class Context:ApplicationContext
    {
        public Context()
        {
            MainWindow win = new MainWindow();
            ElementHost.EnableModelessKeyboardInterop(win);
            win.Show();
        }
    }
}
