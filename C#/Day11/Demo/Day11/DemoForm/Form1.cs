namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Resistration
            this.ResizeEnd += (sender, e) => this.Opacity = 1;
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
            this.Opacity = 0.5;
        }

        private void btnclick(object sender, EventArgs e)
        {
            this.Text = "Hello Rehab";
        }
    }
}