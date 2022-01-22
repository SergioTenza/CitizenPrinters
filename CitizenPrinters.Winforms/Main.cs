using CitizenPrinters.Core.Razor;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.Logging;

namespace CitizenPrinters.Winforms
{
    public partial class Main : Form
    {
        private readonly ILogger<Main> _logger;

        public Main(ILogger<Main> logger)
        {
            InitializeComponent();
            _logger = logger;
            this.WindowState = FormWindowState.Maximized;
            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = Program.container.Services;
            blazorWebView1.RootComponents.Add<App>("#app");
        }
    }
}