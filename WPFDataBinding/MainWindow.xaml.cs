using System.Windows;
namespace WPFDataBinding
{

    public partial class MainWindow : Window
    {

        Geo geo = new Geo { Country = "Danmark", City = "Copenhagen" };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = geo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = geo.City + " er hovedstaden i " + geo.Country;
            MessageBox.Show(message);
        }
    }

    public class Geo
    {

        private string countryValue;
        
        public string Country
        {
            get { return countryValue; }
            set { countryValue = value; }
        }

        private string cityValue;

        public string City
        {
            get { return cityValue; }
           // set { cityValue = value; }
            set
            {
                if (value != cityValue)
                {
                    cityValue = value;
                }
            }
        }

    }
}
