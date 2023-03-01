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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
            float x;
            float y;
            char op;
            public MainWindow()
            {
                InitializeComponent();
            }

            private void Btn(object sender, RoutedEventArgs e)
            {

                TBox.Text = ((Button)sender).Content.ToString();
                x = float.Parse(TBox.Text);


            }

            private void plus(object sender, RoutedEventArgs e)
            {
                y = float.Parse(TBox.Text);
                op = '+';
                TBox.Clear();
            }

            private void divide(object sender, RoutedEventArgs e)
            {
                y = float.Parse(TBox.Text);
                op = '/';
                TBox.Clear();

            }

            private void mutliply(object sender, RoutedEventArgs e)
            {
                y = float.Parse(TBox.Text);
                op = '*';
                TBox.Clear();

            }

            private void sub(object sender, RoutedEventArgs e)
            {
                y = float.Parse(TBox.Text);
                op = '-';
                TBox.Clear();
            }

            private void equal(object sender, RoutedEventArgs e)
            {
                x = float.Parse(TBox.Text);
                float result = 0;
                if (op == '+')
                {
                    result = x + y;
                }
                else if (op == '-')
                {
                    result = Math.Abs(x - y);
                }
                else if (op == '*')
                {
                    result = x * y;
                }
                else if (op == '/')
                {
                    result = x / y;
                }
                else if (TBox.Text == "0")
                {
                    TBox.Clear();
                }
                TBox.Text = result.ToString();
            }
        }
        }
    

