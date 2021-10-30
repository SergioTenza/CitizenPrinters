using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.ComponentModel;

namespace CitizenPrinters.Winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Exception Delegates Handling
            //Winforms Exception Handling
            // Add handler to handle the exception raised by main threads
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            //Add handler to handle the exception raised by additional threads
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            #endregion
            #region DI CONFIG
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("Starting App");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {   
                    services.AddTransient<Main>();
                    
                })
                .UseSerilog()
                .Build();

            #endregion           
            ApplicationConfiguration.Initialize();
            var main = ActivatorUtilities.CreateInstance<Main>(host.Services);
            Application.Run(main);
        }
        #region DI Builder
        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("GRV_ENVIROMENT") ?? "Production"}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
        }
        #endregion
        #region EXCEPTION HANDLING
        static void Application_ThreadException
        (object sender, System.Threading.ThreadExceptionEventArgs e)
        {// All exceptions thrown by the main thread are handled over this method

            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException
            (object sender, UnhandledExceptionEventArgs e)
        {// All exceptions thrown by additional threads are handled in this method

            ShowExceptionDetails(e.ExceptionObject as Exception);

            //// Suspend the current thread for now to stop the exception from throwing.
            Thread.CurrentThread.Suspend();            
        }

        static void ShowExceptionDetails(Exception Ex)
        {
            // Do logging of exception details
            Log.Logger.Error("Message: " + Ex.Message + "\n" + "Source:" + Ex.Source);
        }

        #endregion
    }
}