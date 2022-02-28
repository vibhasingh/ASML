// (C) ASML 2022 Submitted for Interview assignment
using System;
using System.Windows;

namespace ASML.InterviewTest.Runner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new App();
            var window = new MainWindow();
            var viewmodel = new MainViewModel();

            window.DataContext = viewmodel;

            var exitCode = app.Run(window);
            Environment.Exit(exitCode);
        }
    }
}
