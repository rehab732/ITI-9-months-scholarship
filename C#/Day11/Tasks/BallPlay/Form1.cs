namespace BallPlay
{
    public partial class Form1 : Form
    {
        Rectangle ball = new(100, 450, 150, 150);
        bool direc = false;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new(Color.Black,10);
            Pen pen2 = new(Color.HotPink, 5);
            //el wesh
            e.Graphics.DrawEllipse(pen, new(10, 10, 150, 150));
            e.Graphics.DrawEllipse(Pens.Black, new(40, 40, 30, 50));
            e.Graphics.DrawEllipse(Pens.Black, new(100, 40, 30, 50));
            //el gesm
            e.Graphics.DrawLine(pen2, new(85, 160), new(85, 400));
            //el eyeed
            e.Graphics.DrawLine(pen2, new(85, 250), new(150, 350));
            e.Graphics.DrawLine(pen2, new(85, 250), new(20, 350));
            //regl
            e.Graphics.DrawLine(pen2, new(85, 400), new(150, 500));
            e.Graphics.DrawLine(pen2, new(85, 400), new(20, 500));
            //////////////////////////////////////////////////////////////
            //el wesh
            e.Graphics.DrawEllipse(pen, new(600, 10, 150, 150));
            e.Graphics.DrawEllipse(Pens.Black, new(640, 40, 30, 50));
            e.Graphics.DrawEllipse(Pens.Black, new(700, 40, 30, 50));
            //el gesm
            e.Graphics.DrawLine(pen2, new(675, 160), new(675, 400));
            //el eyeed
            e.Graphics.DrawLine(pen2, new(675, 250), new(740, 200));
            e.Graphics.DrawLine(pen2, new(675, 250), new(610, 200));
            //regl
            e.Graphics.DrawLine(pen2, new(675, 400), new(740,500 ));
            e.Graphics.DrawLine(pen2, new(675, 400), new(610, 500));



    
            base.OnPaint(e);
        }
        private void Ball_Move(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(new SolidBrush(BackColor), ball);
            graphics.DrawEllipse(new Pen(BackColor), ball);


            if (ball.X == 500) direc = true;

            if (ball.X == 100) direc = false;

            if (direc)
                ball = new(ball.X - 50, ball.Y, 100, 100);
            else
                ball = new(ball.X + 50, ball.Y, 100, 100);

            graphics.FillEllipse(Brushes.Brown, ball);
            graphics.DrawEllipse(Pens.Brown, ball);

        }
    }
}