using Day2_3.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Day2_3.ViewModel;

namespace Day2_3.ViewModels
{
    public class TestViewModel: BasViewModel
    {
        int testprop;
        public int TestProp {
            get { return testprop; }
            set { 
                testprop = value;
                OnPropertyChanged("Test something");
            }
        }
        public ICommand NewCommand { get; set; }
        public TestViewModel()
        {
            NewCommand = new TestCommand(Test, null);
        }

        private void Test(object obj)
        {
            MessageBox.Show("Hi");
        }
    }
}
