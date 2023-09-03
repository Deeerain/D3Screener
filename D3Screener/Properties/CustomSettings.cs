using System.ComponentModel;
using System.Configuration;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace D3Screener.Properties
{
    internal sealed class CustomSettings : ApplicationSettingsBase
    {
        private static readonly CustomSettings defaultInstance = ((CustomSettings)Synchronized(new CustomSettings()));

        public static CustomSettings Default => defaultInstance;

        [UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCode()]
        [DisplayName("Путь сохранения")]
        [Category("Общие")]
        [Description("Путь сохранения для папок со скриншотами")]
        [Editor(typeof(FolderNameEditor), typeof(UITypeEditor))]
        public string SaveFolderPath
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        [UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCode()]
        [DefaultSettingValue("5000")]
        [DisplayName("Задержка перед стартом")]
        [Category("Скринер")]
        [Description("Запускает процесс с задеожкой")]
        public int StartDelay
        {
            get => GetProperty<int>();
            set => SetProperty(value);
        }


        private void SetProperty<T>(T value, [CallerMemberName] string name = "")
        {
            this[name] = value;
        }

        private T GetProperty<T>([CallerMemberName] string name = "")
        {
            return (T)this[name];
        }
    }

    public class FolderNameEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (value is string folderName && Directory.Exists(folderName))
            {
                folderBrowserDialog.SelectedPath = folderName;
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            else
            {
                return value;
            }
        }
    }
}
