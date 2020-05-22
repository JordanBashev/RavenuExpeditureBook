using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPart()); 
        }
    }
}
