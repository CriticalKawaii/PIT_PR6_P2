using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Pages.admin
{
    /// <summary>
    /// Interaction logic for AdminFramePage.xaml
    /// </summary>
    public partial class AdminFramePage : Page
    {
        public AdminFramePage()
        {
            InitializeComponent();
            frameAdmin.Navigate(new UsersOverviewPage());
        }

        private void ButtonUsersPage_Click(object sender, RoutedEventArgs e)
        {
            frameAdmin.Navigate(new UsersOverviewPage());
        }

        private void ButtonVehiclesPage_Click(object sender, RoutedEventArgs e)
        {
            frameAdmin.Navigate(new VehiclesOverviewPage());
        }

        private void ButtonBookingsPage_Click(object sender, RoutedEventArgs e)
        {
            frameAdmin.Navigate (new BookingsOverviewPage());
        }

        private void ButtonReviewsPage_Click(object sender, RoutedEventArgs e)
        {
            frameAdmin.Navigate(new ReviewsOverviewPage());
        }

        private void ButtonPaymentsPage_Click(object sender, RoutedEventArgs e)
        {
            frameAdmin.Navigate(new PaymentsOverviewPage());
        }
    }
}
