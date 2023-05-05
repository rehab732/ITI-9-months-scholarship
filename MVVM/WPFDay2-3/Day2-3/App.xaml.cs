using Day2_3.DataService;
using Day2_3.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Day2_3.View;
namespace Day2_3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender ,StartupEventArgs e)
        {
            var student = new Student(new StudentViewModel(new StudentDataService()));
            student.Show();
        }
    }
}
