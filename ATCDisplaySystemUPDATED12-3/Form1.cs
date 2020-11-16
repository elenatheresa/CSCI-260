using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCDisplaySystem
{
    public partial class Form1 : Form
    {
        private int _cx, _cy, _ccx, _ccy, ppx, ppy, px, py, ppl, ppk; //planes

        Timer t = new Timer();

        int WIDTH = 300, HEIGHT = 300, HAND = 150;

        int u; // in degree
        int cx, cy; // center of the circle 
        int x, y;

        int tx, ty, lim = 20;
        int Lalt, Lknot, Ldeg, LOalt, LOknot, LOdeg; //landing num
        int TOalt, TOknot, TOdeg, TOFalt, TOFknot, TOFdeg; // take off num 
        int Talt, Tknot, Tdeg, TCalt, TCknot, TCdeg; // TCAS num
        int Calt, Cknot, Cdeg, COalt, COknot, COdeg; // Collision Num 

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics p = e.Graphics;

            //commercial plane
            p.FillRectangle(Brushes.White, _cx, _cy, 5, 5);
            p.FillRectangle(Brushes.White, _ccx, _ccy, 5, 5);

            //private plane
            p.FillRectangle(Brushes.Yellow, px, py, 5, 5);
            p.FillRectangle(Brushes.Red, ppx, ppy, 5, 5);
            p.FillRectangle(Brushes.Red, ppl, ppk, 5, 5);

        }

        private void PlaneTimer_Tick(object sender, EventArgs e)
        {
            //landing plane timer
            if (Lalt > 0)
            {
                Lalt -= 10;
                label3.Text = Lalt + "";
                label5.Text = LOalt + "";
            }
            if (Lknot > 0)
            {
                Lknot -= 5;
                label11.Text = Lknot + "";
                label9.Text = LOknot + "";
            }
            if (Ldeg > 180)
            {
                Ldeg -= 2;
                label12.Text = Ldeg + "";
                label10.Text = LOdeg + "";
            }
            label14.Text = "";

            Invalidate();
        }

        private void TCASTimer_Tick(object sender, EventArgs e)
        {
            _cx += 10;
            _ccx -= 10;
            Tdeg = 90;
            TCdeg = 180;
            label14.Text = "";
            if (_cx >= 350)
            {
                label14.Text = "Warning Potential Wreck";
            }
            if (_cy >= 270)
            {
                label14.Text = "";
            }

            if (_cx >= 360)
            {
                if (_ccx <= 380)
                {
                    _ccy -= 10;
                    _ccx += 10;
                    TCdeg = 0;
                    label10.Text = TCdeg + "";
                }
                _cx -= 10;
                _cy += 10;
                Tdeg = 180;
                label12.Text = Tdeg + "";
            }
            Invalidate();
        }

        private void LandingTimer_Tick(object sender, EventArgs e)
        {
            px += 5;
            py += 13;
            ppl -= 10;
            ppk -= 10;

            if (px >= 435)
            {
                px = 1000;
            }
            label14.Text = "";

            Invalidate();
        }

        private void TakeoffTimerNum_Tick(object sender, EventArgs e)
        {
            if (TOalt <= 100)
            {
                TOalt += 10;
                label3.Text = TOalt + "";
                label5.Text = TOFalt + "";
            }
            if (TOknot <= 60)
            {
                TOknot += 5;
                label11.Text = TOknot + "";
                label9.Text = TOFknot + "";
            }
            if (TOdeg <= 208)
            {
                TOdeg += 2;
                label10.Text = TOFdeg + "";
                label12.Text = TOdeg + "";
            }
            label14.Text = "";

            Invalidate();
        }

        private void CollisionTimer_Tick(object sender, EventArgs e)
        {
            _cx += 10;
            _ccx -= 10;
            label14.Text = "";

            if (_cx >= 370)
            {
                _cx = 1000;
                if (_ccx <= 370)
                {
                    _ccx = 1000;
                    label8.Text = "CRASH EMERGENCY";
                }
                label8.Text = "CRASH EMERGENCY";
            }
            label14.Text = "";

            Invalidate();
        }

        private void TakeoffTimer_Tick(object sender, EventArgs e)
        {
            px += 5;
            py += 13;
            ppx += 10;
            ppy -= 10;
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X + "; Y = " + e.Y;
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X + "; Y = " + e.Y;
        }

        private void Landing_Click(object sender, EventArgs e)
        {
            px = 373;
            py = 0;
            ppl = 373;
            ppk = 530;
            Lalt = 110;
            Lknot = 55;
            Ldeg = 202;
            LOalt = 110;
            LOknot = 55;
            LOdeg = 202;

            if (landingTimer.Enabled)
            {
                landingTimer.Stop();
            }
            else
            {
                landingTimer.Start();
            }

            if (planeTimer.Enabled)
            {
                planeTimer.Stop();
                label2.Text = "DL3564 MSP A";
                label4.Text = "AA2837 MOT ";
            }
            else
            {
                planeTimer.Start();
                label2.Text = "DL3564 MSP A";
                label4.Text = "AA2837 MOT ";

            }
        }

        private void TakeoffPlane_Click(object sender, EventArgs e)
        {
            px = 305;
            py = 370;
            ppx = 103;
            ppy = 268;
            TOalt = 0;
            TOknot = 0;
            TOdeg = 180;
            TOFalt = 398;
            TOFknot = 90;
            TOFdeg = 120;

            if (takeoffTimer.Enabled)
            {
                takeoffTimer.Stop();
            }
            else
            {
                takeoffTimer.Start();
            }
            if (takeoffTimerNum.Enabled)
            {
                takeoffTimerNum.Stop();
                label2.Text = "AA7836 ORD D";
                label4.Text = "DL2477 MSP";

            }
            else
            {
                takeoffTimerNum.Start();
                label2.Text = "AA7836 ORD D";
                label4.Text = "DL2477 MSP";

            }
        }

        private void planesColliding_Click(object sender, EventArgs e)
        {
            _cx = 103;
            _cy = 268;
            _ccx = 635;
            _ccy = 268;
            Calt = 200;
            Cknot = 145;
            Cdeg = 120;
            COalt = 200;
            COknot = 145;
            COdeg = 120;

            if (collisionTimer.Enabled)
            {
                collisionTimer.Stop();
            }
            else
            {
                collisionTimer.Start();
            }

            label2.Text = "DL7836 MOT D";
            label4.Text = "AA2938 MSP D";
            label3.Text = Calt + "";
            label5.Text = COalt + "";
            label11.Text = Cknot + "";
            label9.Text = COknot + "";
            label12.Text = Cdeg + "";
            label10.Text = COdeg + "";
        }

        private void TCAS_Click(object sender, EventArgs e)
        {
            _cx = 103;
            _cy = 268;
            _ccx = 635;
            _ccy = 268;
            Talt = 200;
            Tknot = 145;
            Tdeg = 90;
            TCalt = 200;
            TCknot = 145;
            TCdeg = 90;

            if (TCASTimer.Enabled)
            {
                TCASTimer.Stop();
            }
            else
            {
                TCASTimer.Start();
            }

            label2.Text = "DL3948 MSP D";
            label4.Text = "AA2938 MOT D";
            label3.Text = Talt + "";
            label5.Text = TCalt + "";
            label11.Text = Tknot + "";
            label9.Text = TCknot + "";
            label12.Text = Tdeg + "";
            label10.Text = TCdeg + "";
        }


        private void optionsMenuButton_Click(object sender, EventArgs e)
        {
            optionsMenu f2 = new optionsMenu();
            f2.ShowDialog(); // Shows optionsMenu form
        }

        Bitmap bmp;
        Pen p;
        Graphics g;


        public Form1()
        {
            InitializeComponent();
            //px = 373;
            //py = 0;
            //ppx = 373;
            //ppy = 0;
            //_cx = 103;
            //_cy = 268;
            //_ccx = 635;
            //_ccy = 268;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //background color
            this.BackColor = Color.Black;

            //center 
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //ititial degree of HAND
            u = 0;

            //timer 
            t.Interval = 5;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            //privatePlaneTimer.Enabled = true;
            //commercialPlaneTimer.Enabled = true;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //pen
            p = new Pen(Color.Green, 1f);

            //graphicss 
            g = Graphics.FromImage(bmp);

            //calculate x, y coordinate of HAND 
            int tu = (u - lim) % 360;
            
            if (u >= 0 && u <= 180)
            {
                //right half
                //tu in degree is converted into radian

                x = cx + (int)(HAND * Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }
            else
            {
                x = cx - (int)(HAND * -Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }

            if (tu >= 0 && tu <= 180)
            {
                //right half
                //tu in degree is converted into radian

                tx = cx + (int)(HAND * Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }
            else
            {
                tx = cx - (int)(HAND * -Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }

            //draw circle
            g.DrawEllipse(p, 0, 0, WIDTH, HEIGHT); //bigger circle
            g.DrawEllipse(p, 40, 40, WIDTH - 80, HEIGHT - 80);
            g.DrawEllipse(p, 80, 80, WIDTH - 160, HEIGHT - 160); //smaller  circle
            g.DrawEllipse(p, 120, 120, WIDTH - 240, HEIGHT - 240);

            //draw perpendicular line
            //bottom 
            g.DrawLine(p, new Point(cx + 10, HEIGHT - 10), new Point(cx + 10, HEIGHT)); //up-down
            g.DrawLine(p, new Point(cx - 10, HEIGHT - 10), new Point(cx - 10, HEIGHT));
            //top 
            g.DrawLine(p, new Point(cx + 10, 0), new Point(cx + 10, 10));
            g.DrawLine(p, new Point(cx - 10, 0), new Point(cx - 10, 10));
            //left 
            g.DrawLine(p, new Point(0, cy - 10), new Point(10, cy - 10));
            g.DrawLine(p, new Point(0, cy + 10), new Point(10, cy + 10));
            //Right
            g.DrawLine(p, new Point(350, cy - 10), new Point(WIDTH - 10, cy - 10));
            g.DrawLine(p, new Point(350, cy + 10), new Point(WIDTH - 10, cy + 10));

            //draw the landing strips
            //right side
            g.DrawLine(new Pen(Color.Green, 3f), new Point(cx + 30, 105), new Point(cx + 30, 195));
            g.DrawLine(new Pen(Color.Green, 3f), new Point(cx + 40, 105), new Point(cx + 40, 195));
            g.DrawLine(p, new Point(cx + 30, 90), new Point(cx + 30, 210));
            g.DrawLine(p, new Point(cx + 40, 90), new Point(cx + 40, 210));
            //left side
            g.DrawLine(new Pen(Color.Green, 3f), new Point(cx - 30, 105), new Point(cx - 30, 195));
            g.DrawLine(new Pen(Color.Green, 3f), new Point(cx - 40, 105), new Point(cx - 40, 195));
            g.DrawLine(p, new Point(cx - 30, 90), new Point(cx - 30, 210));
            g.DrawLine(p, new Point(cx - 40, 90), new Point(cx - 40, 210));

            //draw hand
            g.DrawLine(new Pen(Color.Black, 1f), new Point(cx, cy), new Point(tx, ty));
            g.DrawLine(p, new Point(cx, cy), new Point(x, y));

            //load bitmap in picturebox2
            pictureBox2.Image = bmp;

            //dispose
            p.Dispose();
            g.Dispose();

            //update
            u++;
            if (u == 360)
            {
                u = 0;
            }
        }
    }
}
