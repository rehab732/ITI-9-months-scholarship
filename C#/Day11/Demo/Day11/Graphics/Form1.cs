namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += (sender, e) => Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Font myf = new Font(this.Font.FontFamily, 18);
            string str = "Hello Rehab";
            Brush MYbrush=new SolidBrush(Color.FromArgb(55,155,100));
            var textsize=e.Graphics.MeasureString(str, myf);
            e.Graphics.DrawString(str, myf, MYbrush, (ClientSize.Width-textsize.Width) / 2, (ClientSize.Height-textsize.Height) / 2);
            base.OnPaint(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}