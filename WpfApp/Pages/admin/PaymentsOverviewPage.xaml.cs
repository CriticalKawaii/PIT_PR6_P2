using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp.Pages.admin
{
    /// <summary>
    /// Interaction logic for PaymentsOverviewPage.xaml
    /// </summary>
    public partial class PaymentsOverviewPage : Page
    {
        public PaymentsOverviewPage()
        {
            InitializeComponent();
            DataGridPayments.ItemsSource = DBEntities.GetContext().Payments.ToList();
        }
    }
}
