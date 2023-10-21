using D3Screener.Infrastructure;
using D3Screener.Infrastructure.Commands;
using D3Screener.Infrastructure.ScreenerActions;
using D3Screener.Infrastructure.Utils;
using D3Screener.Model;
using D3Screener.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Imaging;
using System.Windows.Input;

namespace D3Screener.ViewModel
{
    public class MainViewModel: NotifiedObject
    {
        private WorkSettings _model;
        public ICommand StartWorkCommand { get; set; }

        public MainViewModel()
        {
            _model = new WorkSettings();
            var screenshotSaver = Program.AppHost?.Services.GetService<IScreenshotSaver>();

            var workFlow = new ScreenerWorkFlow(
                new ScreenshotAction(screenshotSaver, PathUtils.GetTemplateFolderPathByAssembly(), 
                    DateTime.Now.ToFileTime().ToString(), ImageFormat.Jpeg),
                new SendKeyAction(SelectedKey),
                new DelayAction(ScreenshotDelay)); ;

            StartWorkCommand = new StartWorkFlowCommand(workFlow, _model.ScreenCount);
        }

        public int StartDelay
        {
            get => _model.StartDelay;
            set => _model.StartDelay = value;
        }

        public int ScreenshotDelay
        {
            get => _model.ScreenshotDelay;
            set => _model.ScreenshotDelay = value;
        }

        public Keys SelectedKey
        {
            get => _model.SelectedKey;
            set => _model.SelectedKey = value;
        }

        public int ScreenCount
        {
            get => _model.ScreenCount;
            set => _model.ScreenCount = value;
        }
    }
}
