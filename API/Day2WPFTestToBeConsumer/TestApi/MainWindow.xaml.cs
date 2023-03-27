using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;

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

namespace TestApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //need to get data from provider by url
            //https://localhost:44340/api/Department

            HttpClient httpClient=new HttpClient();
            HttpResponseMessage resmass= await httpClient.GetAsync("http://localhost:44340/api/Department");
            if (resmass.IsSuccessStatusCode) {

              string msd=await  resmass.Content.ReadAsStringAsync();

             List<Department> depList=JsonSerializer.Deserialize<List<Department>>(msd)??new List <Department>();
                deplist.ItemsSource= depList;
            }
            else
            {
                MessageBox.Show("Sorry");
            }

        }
    }
}
