using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
namespace Micky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0,100, 100);
            path.AddEllipse(ClientSize.Width-100,0, 100,100);
            e.Graphics.FillPath(Brushes.Brown, path);
            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            path.FillMode = FillMode.Winding;


            Pen pen = new Pen(Color.Brown, 2);
            Rectangle ellipseRect = new Rectangle(120, 100, 60, 80);

            e.Graphics.DrawEllipse(pen, ellipseRect);

            Rectangle ellipseRect2 = new Rectangle(350, 100, 60, 80);

            e.Graphics.DrawEllipse(pen, ellipseRect2);
           

            this.Region = new Region(path);

            base.OnPaint(e);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}