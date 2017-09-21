using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AnimationSumm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Start Up clean screen //
            BackgroundImage = null;
            name.Dispose();
            Refresh();
            
            //Frame 1
            Graphics formGraphics = this.CreateGraphics();
            Pen blackPen  = new Pen(Color.Black, 2);
            SolidBrush grayFill = new SolidBrush(Color.Gray);
            SolidBrush blackFill = new SolidBrush(Color.Black);
            SolidBrush head = new SolidBrush(Color.Beige);
            SolidBrush bod = new SolidBrush(Color.Red);
            SolidBrush brown = new SolidBrush(Color.Chocolate);
            SolidBrush pelvisAndLeg = new SolidBrush(Color.Blue);
            formGraphics.FillRectangle(grayFill, 0, 0, 600, 600);

            //ball
            formGraphics.FillEllipse(blackFill, -35, 25, 25, 35);


            //dude
            formGraphics.FillEllipse(brown, 258, 185, 58, 70);
            formGraphics.FillEllipse(bod, 257, 225, 55, 140);
            formGraphics.FillEllipse(pelvisAndLeg, 258, 335, 55, 30);
            formGraphics.FillEllipse(pelvisAndLeg, 257, 350, 20, 50);
            formGraphics.FillEllipse(pelvisAndLeg, 290, 350, 20, 50);
            formGraphics.FillEllipse(head, 257, 200, 55, 75);
            formGraphics.DrawArc(blackPen, 265, 240, 30, 20, 10, 130);
            formGraphics.FillEllipse(blackFill, 265, 225, 5, 5);
            formGraphics.FillEllipse(blackFill, 285, 225, 5, 5);

            Thread.Sleep(100);

            //ball
            formGraphics.FillEllipse(blackFill, 40, 25, 25, 25);

            //dude
            formGraphics.FillEllipse(brown, 258, 185, 58, 70);
            formGraphics.FillEllipse(bod, 257, 225, 55, 140);
            formGraphics.FillEllipse(pelvisAndLeg, 258, 335, 55, 30);
            formGraphics.FillEllipse(pelvisAndLeg, 257, 350, 20, 50);
            formGraphics.FillEllipse(pelvisAndLeg, 290, 350, 20, 50);
            formGraphics.FillEllipse(head, 257, 200, 55, 75);
            formGraphics.DrawArc(blackPen, 265, 240, 30, 20, 10, 130);
            formGraphics.FillEllipse(blackFill, 265, 225, 5, 5);
            formGraphics.FillEllipse(blackFill, 285, 225, 5, 5);


        }
    }
}
