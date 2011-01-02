using System;
using System.Windows;

using Client.WPF.Views;

namespace Client.WPF
{
    public class App : Application
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new App().Run(new MainWindow());
        }
    }
}
