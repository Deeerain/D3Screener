using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Drawing.Design;
using System.IO;
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
        [Category("Посленее сохраненные")]
        [DisplayName("Кнопка для отправки в окно")]
        [DefaultSettingValue("41")]
        public Keys KeyPressButton
        {
            get => GetProperty<Keys>();
            set => SetProperty(value);
        }

        [UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [DefaultSettingValue("5000")]
        [Category("Посленее сохраненные")]
        [DisplayName("Задержка страта")]
        public int StartWorkDelay
        {
            get => GetProperty<int>();
            set => SetProperty((int)value);
        }

        [UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [DefaultSettingValue("1")]
        [Category("Посленее сохраненные")]
        [DisplayName("Количество скриншотов")]
        public int ScreenCount
        {
            get => GetProperty<int>();
            set => SetProperty((int)value);
        }

        [UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [DefaultSettingValue("100")]
        [Category("Посленее сохраненные")]
        [DisplayName("Задержка между скриншотами")]
        public int ScreenDelay
        {
            get => GetProperty<int>();
            set => SetProperty((int)value);
        }

        private void SetProperty<T>(T value, [CallerMemberName] string name = "")
        {
            this[name] = value;
        }

        private T GetProperty<T>([CallerMemberName] string name = "")
        {
            return ((T)(this[name]));
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
