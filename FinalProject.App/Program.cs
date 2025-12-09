using FinalProject.App.Infra;
using FinalProject.App.Others;

namespace FinalProject.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfigureServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}