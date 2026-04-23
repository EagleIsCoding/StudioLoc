using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioLoc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool useLogin = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (useLogin)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new MainForm());

            }
        }
    }
}
