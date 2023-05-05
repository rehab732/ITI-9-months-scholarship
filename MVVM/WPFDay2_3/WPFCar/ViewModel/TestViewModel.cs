using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFCar.Commands;

namespace WPFCar.ViewModel
{
    public class TestViewModel
    {
       public ICommand NewCommand { get; set; }
       public TestViewModel()
        {
            NewCommand = new TestCommand(AddAlert, null);
        }

        private void AddAlert(object obj)
        {
            MessageBox.Show("Hello");
        }
    }
}
