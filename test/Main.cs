using System;
using System.Windows;

namespace k11
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MainWindow startWindow = new MainWindow();
            startWindow.Show();

            Application app = new Application();
            app.Run();
        }
    }
}
