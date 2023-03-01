using System.Drawing;

namespace DragDropRect
{

    public partial class Form1 : Form
    {
        public Graphics graph;
        public bool inn = false;

        Rectangle rect = new(20, 30, 400, 300);

        public Form1()
        {
            InitializeComponent();
            graph = CreateGraphics();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, rect);
            e.Graphics.DrawRectangle(Pens.Red, rect);
            base.OnPaint(e);
        }
        private void winMouseDown(object sender, MouseEventArgs e)
        {
            if (rect.Contains(e.Location))
            {
                inn = true;
            }

        }
        private void winMouseUp(object sender, MouseEventArgs e)
        {
            if (inn)
            {
                Invalidate();
                rect = new(e.X, e.Y, 400, 300);
                graph.FillRectangle(Brushes.Red, rect);
                graph.DrawRectangle(Pens.Black, rect);
            }
        }
    }
}