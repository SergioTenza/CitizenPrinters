using CitizenPrinters.WinUI.ViewModels;
using CitizenPrinters.WinUI.Views;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using System;

namespace CitizenPrinters.WinUI
{
    public partial class App : Application
    {
        

        public App()
        {   
            Ioc.Default.ConfigureServices(ConfigureServices());
        }
        
        private IServiceProvider ConfigureServices()
        {

            // TODO WTS: Register your services, viewmodels and pages here
            var services = new ServiceCollection();


            // Services

            // Core Services


            // Views and ViewModels
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainWindow>();
            return services.BuildServiceProvider();
        }
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window m_window;

    }
}
