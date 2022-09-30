using Lesson_2.Properties;

namespace Lesson_2
{
    public partial class Form1 : Form
    {
        private int X;
        private int Y;
        private int X_1;
        private int Y_1;
        private bool baku = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void Create(int X, int Y, int X_1, int Y_1)
        {

            Label l = new Label
            {
                Text = "Rectangle",
                BackColor = Color.Green,
                Location = new Point(X, Y),
                Size = new Size(10,10)
                
            };

            l.MouseClick += L_MouseClick;

            void L_MouseClick(object? sender, MouseEventArgs e)
            {
                Controls.Remove(l);
            }


            if (X > X_1 && Y > Y_1)
                l.Size = new Size(X - X_1, Y - Y_1);
            else if(X_1 > X && Y_1 > Y)
                l.Size = new Size(X_1 - X, Y_1 - Y);

            panel3.Controls.Add(l);
        }

        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();

            if (e.X > RunningBLock.Location.X && e.Y > RunningBLock.Location.Y)
            {
                if(e.X - RunningBLock.Location.X < 5 || e.Y - RunningBLock.Location.Y < 5)
                {
                    RunningBLock.Location = new Point(r.Next(10, panel1.Width), r.Next(10, panel1.Height));
                }
            }
            else if(e.X < RunningBLock.Location.X && e.Y < RunningBLock.Location.Y)
            {
                if(RunningBLock.Location.X - e.X < 5 || RunningBLock.Location.Y - e.Y < 5)
                {
                    RunningBLock.Location = new Point(r.Next(10, panel1.Width), r.Next(10, panel1.Height));

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baku == true)
            {
                panel2.BackColor = Color.Red;
                baku = false;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baku == false)
            {
                panel2.BackColor = Color.Green;
                baku = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            X_1 = e.X;
            Y_1 = e.Y;
            Create(X_1, Y_1, X_1, Y);
        }
    }
}