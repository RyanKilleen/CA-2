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

namespace CA_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bike> allBikes = new List<Bike>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Making Some Bike Objects
            Bike aProduct = new Bike(1234, "Road Bike", 535.00m, Gender.Male);
            Bike bProduct = new Bike(1235, "Road Bike", 635.00m, Gender.Female);
            Bike cProduct = new Bike(1236, "Mountain Bike", 740.00m, Gender.Male);
            Bike dProduct = new Bike(1237, "Mountain Bike", 780.00m, Gender.Female);
            Bike eProduct = new Bike(1238, "Hybrid Bike", 155.00m, Gender.Male);
            Bike fProduct = new Bike(1239, "Hybrid Bike", 150.00m, Gender.Female);

            //Adding to List
            allBikes.Add(aProduct);
            allBikes.Add(bProduct);
            allBikes.Add(cProduct);
            allBikes.Add(dProduct);
            allBikes.Add(eProduct);
            allBikes.Add(fProduct);

            //Displying Them in The ListBox
            //This tells the ListBox That the source of the items is the List
            lbxProducts.ItemsSource = allBikes;



        }
    }
}
