using System.Windows;
using System.Windows.Input;
using WpfApp.Classes;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        ExploreCarsPage ExploreCarsPage { get; set; }
        SignInPage SignInPage { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ExploreCarsPage = new ExploreCarsPage();
            SignInPage = new SignInPage();
            RadioButtonExplore.IsChecked = true;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) DragMove();
        }
        private void RadioButtonAccount_Checked(object sender, RoutedEventArgs e)
        {
            Dispatcher.InvokeAsync( () => {
                if (!SessionManager.IsLoggedIn)
                    frameMainWindow?.Navigate(SignInPage);
                else
                    frameMainWindow?.Navigate(ExploreCarsPage);
            } );
        }
        private void RadioButtonExplore_Checked(object sender, RoutedEventArgs e)
        {
            Dispatcher.InvokeAsync( () => { frameMainWindow?.Navigate(ExploreCarsPage); } );
        }
    }
}
