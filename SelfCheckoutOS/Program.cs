using System;
using System.Windows.Forms;

namespace SelfCheckoutOS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome()); // replace with your startup form
        }
    }
}
