using CitizenPrinters.Core.Razor;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.Logging;

namespace CitizenPrinters.Winforms
{
    public partial class Main : Form
    {
        private readonly ILogger<Main> _logger;
        private readonly IServiceProvider serviceProvider;

        public Main(
            ILogger<Main> logger, 
            IServiceProvider serviceProvider
            )
        {
            InitializeComponent();
            _logger = logger;
            this.serviceProvider = serviceProvider;
            this.WindowState = FormWindowState.Maximized;
            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceProvider;
            blazorWebView1.RootComponents.Add<App>("#app");
        }
    }
}