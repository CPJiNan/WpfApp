using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MahApps.Metro.IconPacks;
using VitaServerLauncher.ViewModels;

namespace VitaServerLauncher
{
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();
            DataContext = ViewModel;
            ViewModel.CurrentButton = "Home";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void CloseButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void FullscreenButton_Click(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void ShowHome_Click(object sender, RoutedEventArgs e)
        {
            Button oldButton = (Button)FindName(ViewModel.CurrentButton);
            oldButton.Style = (Style)Application.Current.Resources["menuButton_Normal"];

            Button newButton = sender as Button;
            newButton.Style = (Style)Application.Current.Resources["menuButton_Active"];

            ViewModel.CurrentButton = newButton.Name;
            ViewModel.ShowHome();
        }

        private void ShowConsole_Click(object sender, RoutedEventArgs e)
        {
            Button oldButton = (Button)FindName(ViewModel.CurrentButton);
            oldButton.Style = (Style)Application.Current.Resources["menuButton_Normal"];

            Button newButton = sender as Button;
            newButton.Style = (Style)Application.Current.Resources["menuButton_Active"];

            ViewModel.CurrentButton = newButton.Name;
            ViewModel.ShowConsole();
        }
    }
}
