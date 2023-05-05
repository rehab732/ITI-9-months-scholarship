using Day2_3.ViewModel;
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
using System.Windows.Shapes;

namespace Day2_3.View
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public StudentViewModel studentVM;
        public Student(StudentViewModel studentvm)
        {
            studentVM = studentvm;
            DataContext= studentVM;
            InitializeComponent();
            Loaded += studentLoad;
        }
        private void studentLoad(object sender, RoutedEventArgs e)
        {
            studentVM.GetData();
        }
    }
}
