using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace WpfApp
{
    public partial class ExploreCarsPage : Page
    {
        public ExploreCarsPage()
        {
            InitializeComponent();
            ListViewExploreCars.ItemsSource = DBEntities.GetContext().Vehicles.ToList();
            ListViewExploreCars.SelectedIndex = 0;
        }

        private void ListViewItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            ListViewItem viewItem = (ListViewItem)sender;
            MessageBox.Show(viewItem.Name);
        }
        public ImageSource ByteArrayToImageSource(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;

            using (var stream = new MemoryStream(imageData))
            {
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }
        private void ListViewExploreCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewExploreCars.SelectedItem is Vehicle selectedVehicle)
            {
                textBlockMakeModel.Text = $"{selectedVehicle.Make} {selectedVehicle.Model} {selectedVehicle.Year}";
                textBlockLicensePlate.Text = $"License: {selectedVehicle.LicensePlate}";
                textBlockDailyRate.Text = $"Daily Rate: {selectedVehicle.DailyRate:C}";

                if (selectedVehicle.VehicleImage != null)
                {
                    imageVehicle.Source = ByteArrayToImageSource(selectedVehicle.VehicleImage);
                }

                //VehicleImage.ImageSource = ByteArrayToImageSource(selectedVehicle.VehicleImage);
                //TextBlockMake.Text = $"Make: {selectedVehicle.Make}\nLicense Plate: {selectedVehicle.LicensePlate}";
            }
        }
    }
}