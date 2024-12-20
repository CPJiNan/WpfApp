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
            Button oldButton = (Button) FindName(ViewModel.CurrentButton);
            oldButton.Background = new SolidColorBrush(Colors.Transparent);
            oldButton.Foreground = new SolidColorBrush(Colors.Black);
            PackIconMaterial oldArrowIcon = (PackIconMaterial)FindName(ViewModel.CurrentButton + "_Arrow_Icon");
            oldArrowIcon.Visibility = Visibility.Hidden;

            Button newButton = sender as Button;
            ViewModel.CurrentButton = newButton.Name;

            newButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#02be68"));
            newButton.Foreground = new SolidColorBrush(Colors.White);
            PackIconMaterial newArrowIcon = (PackIconMaterial) FindName(ViewModel.CurrentButton + "_Arrow_Icon");
            newArrowIcon.Visibility = Visibility.Visible;

            ViewModel.ShowHome();
        }

        private void ShowConsole_Click(object sender, RoutedEventArgs e)
        {
            Button oldButton = (Button)FindName(ViewModel.CurrentButton);
            oldButton.Background = new SolidColorBrush(Colors.Transparent);
            oldButton.Foreground = new SolidColorBrush(Colors.Black);
            PackIconMaterial oldArrowIcon = (PackIconMaterial)FindName(ViewModel.CurrentButton + "_Arrow_Icon");
            oldArrowIcon.Visibility = Visibility.Hidden;

            Button newButton = sender as Button;
            ViewModel.CurrentButton = newButton.Name;

            newButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#02be68"));
            newButton.Foreground = new SolidColorBrush(Colors.White);
            PackIconMaterial newArrowIcon = (PackIconMaterial)FindName(ViewModel.CurrentButton + "_Arrow_Icon");
            newArrowIcon.Visibility = Visibility.Visible;

            ViewModel.ShowConsole();
        }
    }
}
