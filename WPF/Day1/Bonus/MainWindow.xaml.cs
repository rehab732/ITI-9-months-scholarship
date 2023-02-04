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

namespace Bonus
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

        private void set_text(object sender, RoutedEventArgs e)
        {
            rehab.Clear();
            rehab.Text="Replace default text with initial text value";

        }

        private void SelectAll(object sender, RoutedEventArgs e)
        {
            rehab.Focus();
            rehab.SelectAll();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            rehab.Clear();
        }

        private void PreAppend(object sender, RoutedEventArgs e)
        {
            rehab.Text="====PreAppend Text====="+rehab.Text;

        }

        private void Append(object sender, RoutedEventArgs e)
        {
            rehab.Text =  rehab.Text+ "====Appended Text=====";

        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            rehab.Text = "====Inserted Text=====" + rehab.Text;


        }

        private void Undo(object sender, RoutedEventArgs e)
        {
            rehab.Undo();
        }

        private void Cut(object sender, RoutedEventArgs e)
        {
            rehab.Cut();
        }

        private void Paste(object sender, RoutedEventArgs e)
        {
            rehab.Paste();
        }


      

        private void Edit(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Read Only":
                    rehab.IsReadOnly=true;
                    break;
                case "Editable":
                    rehab.IsReadOnly=false;
                    break;
            }
        }

            private void pos(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Left":
                    rehab.TextAlignment=TextAlignment.Left;
                    break;
                    case "Right":
                    rehab.TextAlignment = TextAlignment.Right;
                        break;
                case "Center":
                    rehab.TextAlignment = TextAlignment.Center;
                    break;


            }
        }
        }
}
