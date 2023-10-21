using D3Screener.Infrastructure.Utils;
using D3Screener.Views;
using Microsoft.Extensions.DependencyInjection;

namespace D3Screener.Infrastructure.Commands
{
    internal class StartWorkFlowCommand : Command
    {
        private readonly IScreenerWorkFlow _workFlow;
        private readonly int _count;

        public StartWorkFlowCommand(IScreenerWorkFlow workFlow, int count)
        {
            _workFlow = workFlow;
            _count = count;
        }

        public override void Execute(object? parameter)
        {
            var mainWindow = Program.AppHost?.Services.GetService<MainWindow>();
            var imageViewerWindow = Program.AppHost?.Services.GetService<ImageViewer>();
            imageViewerWindow.FolderPath = PathUtils.GetTemplateFolderPathByAssembly();


            mainWindow.WindowState = System.Windows.WindowState.Minimized;
            _workFlow.Run(_count);
            imageViewerWindow.ShowDialog();
            mainWindow.WindowState = System.Windows.WindowState.Normal;
        }
    }
}
