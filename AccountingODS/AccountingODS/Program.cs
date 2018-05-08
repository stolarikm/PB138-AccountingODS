using System;
using Gtk;

namespace AccountingODS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
			MainWindow win = new MainWindow();
			win.Title = "AccountingODS";
            win.Show();
            Application.Run();
        }
    }
}
