using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApplication1
{
    sealed class MyMain
    {
        [STAThread()]
        public static void Main()
        {
            Context myContext = new Context();
            Application.Run(myContext);
        }
    }
}
