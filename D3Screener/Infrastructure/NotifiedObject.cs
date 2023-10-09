using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace D3Screener.Infrastructure
{
    public class NotifiedObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void SetProperty<T>(ref T target, T value, [CallerMemberName] string name = "")
        {
            target = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
