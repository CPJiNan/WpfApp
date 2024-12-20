using System.ComponentModel;
using System.Runtime.CompilerServices;
using VitaServerLauncher.Views;

namespace VitaServerLauncher.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            CurrentView = new HomeView();
        }

        public void ShowHome()
        {
            CurrentView = new HomeView();
        }

        public void ShowConsole()
        {
            CurrentView = new ConsoleView();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
