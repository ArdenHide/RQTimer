using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RQTimer.Data.Models;

public class NotifyPropertyChanged : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string propName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
}
