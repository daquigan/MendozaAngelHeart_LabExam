// Program.cs
using System;
using System.Windows.Forms;

namespace StudentApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Student_Page());
        }
    }
}