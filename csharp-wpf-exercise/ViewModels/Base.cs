using System.ComponentModel;
using System.Runtime.CompilerServices;
using csharp_wpf_exercise.Annotations;

namespace csharp_wpf_exercise.ViewModels
{
    internal class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}