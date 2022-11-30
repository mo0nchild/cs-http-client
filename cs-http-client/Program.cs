using CSHttpClient.Controllers;
using CSHttpClient.NetworkTransfer;
using CSHttpClient.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace CSHttpClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services_list = new ServiceCollection().AddHttpClient()
                .AddTransient<NetworkTransfer.IHttpTransfer, NetworkTransfer.HttpTransfer>()
                .AddTransient<IProfileController, ProfileController>();

            var services_provider = services_list.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthorizationForm(services_provider));
        }
    }
}