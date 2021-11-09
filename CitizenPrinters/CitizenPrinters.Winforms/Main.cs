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
        }
    }
}