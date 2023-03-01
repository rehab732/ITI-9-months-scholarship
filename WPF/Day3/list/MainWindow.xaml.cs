using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace list
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>()
            {
                new Student(){Name="Rehab",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws.jpg"},
                new Student(){Name="Mahmoud",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws2.jpg"},
                new Student(){Name="Ahmed",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws3.jpg"},
                new Student(){Name="Ashraf",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf.jpg"},
                new Student(){Name="HAdeer",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf2.jpg"},
                new Student(){Name="Noura",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf3.jpg"},
                new Student(){Name="Rehab",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws.jpg"},
                new Student(){Name="Mahmoud",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws2.jpg"},
                new Student(){Name="Ahmed",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws3.jpg"},
                new Student(){Name="Ashraf",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf.jpg"},
                new Student(){Name="HAdeer",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf2.jpg"},
                new Student(){Name="Noura",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf3.jpg"},
                  new Student(){Name="Noura",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf3.jpg"},
                new Student(){Name="Rehab",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws.jpg"},
                new Student(){Name="Mahmoud",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws2.jpg"},
                new Student(){Name="Ahmed",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gws3.jpg"},
                new Student(){Name="Ashraf",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf.jpg"},
                new Student(){Name="HAdeer",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf2.jpg"},
                new Student(){Name="Noura",Id=10,Salary="4522",Description="Hi Ra7oob" ,Image="/gwsf3.jpg"},



            };
            list.ItemsSource= Students;
          
        }
    }
}
