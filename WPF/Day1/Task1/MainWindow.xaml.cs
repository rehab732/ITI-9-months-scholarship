using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
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

        private void Change_color(object sender, RoutedEventArgs e)
        {
            switch(((RadioButton)sender).Content.ToString())
            {
                case "Red":
                    InkCan.DefaultDrawingAttributes.Color =Colors.Red;

                    break;
                case "Green":
                    InkCan.DefaultDrawingAttributes.Color = Colors.Green;

                    break;
                case "Blue":
                    InkCan.DefaultDrawingAttributes.Color = Colors.Blue;

                    break;
                case "Yellow":
                    InkCan.DefaultDrawingAttributes.Color =Colors.Yellow;

                    break;
                case "Orange":
                    InkCan.DefaultDrawingAttributes.Color = Colors.Orange;

                    break;
            }
        }

        private void Change_Ink(object sender, RoutedEventArgs e)
        {

            switch(((RadioButton)sender).Content.ToString())
            {
                case "Ink":
                    InkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Select":
                    InkCan.EditingMode = InkCanvasEditingMode.Select;

                    break;
                case "Erase":
                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;


                    break;
                case "Erase by strock":
                    InkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;

                    break;

            }
        }

        private void Change_shape(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ellipse":
                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
                case "Rectangle":
                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;
                

            }
        }

        private void Change_Size(object sender, RoutedEventArgs e)
        {
            
                 switch (((RadioButton)sender).Content.ToString())
                 {
                    case "Small":
                    InkCan.DefaultDrawingAttributes.Width = 3;
                    InkCan.DefaultDrawingAttributes.Height = 3;
                    break;
                    case "Normal":
                    InkCan.DefaultDrawingAttributes.Width = 7;
                    InkCan.DefaultDrawingAttributes.Height = 7;
                    break;
                case "Large":
                    InkCan.DefaultDrawingAttributes.Width = 10;
                    InkCan.DefaultDrawingAttributes.Height = 10;

                    break;

            }
        
        }

        private void New_page(object sender, RoutedEventArgs e)
        {
            //InkCan.Strokes=new StrokeCollection();
            InkCan.Strokes.Clear();
        }


        private StrokeCollection Strokes;
        private void Copy_shape(object sender, RoutedEventArgs e)
        {
            Strokes =InkCan.GetSelectedStrokes().Clone();
        }

        private void Save_page(object sender, RoutedEventArgs e)
        {
            /*
            //if i put an existing path
            FileStream file=new FileStream("E:/ITI/SD Mobile/WPF/canvas.ink",FileMode.OpenOrCreate,FileAccess.Write);
            InkCan.Strokes.Save(file);
            file.Close();*/
            

            //browse to save file
            Microsoft.Win32.SaveFileDialog saveFile= new Microsoft.Win32.SaveFileDialog();
            saveFile.Filter = "Ink Serialized Format (*.isf)|*.isf";
            if(saveFile.ShowDialog() == true)
            {
                using(FileStream file =new FileStream(saveFile.FileName,FileMode.OpenOrCreate))
                {
                    InkCan.Strokes.Save(file);
                }
            }

        }

        private void Cut_shape(object sender, RoutedEventArgs e)
        {
            Strokes = InkCan.GetSelectedStrokes().Clone();
            InkCan.Strokes.Remove(InkCan.GetSelectedStrokes());
        }

        private void Load_page(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog open=new Microsoft.Win32.OpenFileDialog();
            open.Filter = "Ink Serialized Format (*.isf)|*.isf";
            if(open.ShowDialog() == true)
            {
                using(FileStream file=new FileStream(open.FileName,FileMode.Open))
                {
                    StrokeCollection strokes = new(file);
                    InkCan.Strokes= strokes;
                }
            }

        }

        private void Paste_shape(object sender, RoutedEventArgs e)
        {
            if(Strokes!=null)
            {
                StrokeCollection n = InkCan.Strokes;
                n.Add(Strokes);
            }

        }
    }
}
