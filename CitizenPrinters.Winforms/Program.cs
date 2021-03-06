using CitizenPrinters.BlazorServer.Data;

namespace CitizenPrinters.Winforms
{
    public static class Program
    {   
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
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

            using (var container = BuildHost(args).Build())
            {
                ApplicationConfiguration.Initialize();
                var main = ActivatorUtilities.CreateInstance<Main>(container.Services);
                AppCenter.Start("d6c836c8-485a-4942-83e0-8b4af8b76b24",
                       typeof(Analytics), typeof(Crashes));
                Application.Run(main);
            }
            #endregion
            
        }
        #region DI Builder
        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("GRV_ENVIROMENT") ?? "Production"}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
        }

        static IHostBuilder BuildHost(string[] args)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<Main>();
                    services.AddBlazorWebView();
                    services.AddSingleton<WeatherForecastService>();
                })
                .UseSerilog();
        }
        #endregion
        #region EXCEPTION HANDLING
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // All exceptions thrown by the main thread are handled over this method
            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // All exceptions thrown by additional threads are handled in this method
            ShowExceptionDetails(e.ExceptionObject as Exception);

            // Suspend the current thread for now to stop the exception from throwing.
            //Thread.CurrentThread.Suspend();            
        }

        static void ShowExceptionDetails(Exception ex)
        {
            // Do logging of exception details
            Log.Logger.Error("Message: " + ex.Message + "\n" + "Source:" + ex.Source);
            MessageBox.Show("Message: " + ex.Message + "\n" + "Source:" + ex.Source);
        }

        #endregion
    }
}