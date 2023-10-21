using D3Screener.Infrastructure;
using D3Screener.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace D3Screener
{
    public class Program
    {
        public static IHost? AppHost { get; private set; }

        [STAThread]
        public static void Main(string[] args)
        {
            AppHost = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
            {
                services.AddSingleton<App>();
                services.AddSingleton<MainWindow>();
                services.AddSingleton<ImageViewer>();
                services.AddSingleton<IScreenshotSaver, DefaultScreenshotSaver>();
                services.AddSingleton<IScreenerWorkFlow, ScreenerWorkFlow>();
            }).Build();

            var app  = AppHost.Services.GetService<App>();
            app?.Run();
        }
    }
}
