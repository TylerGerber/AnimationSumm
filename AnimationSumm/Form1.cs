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
using System.Media;

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
            SoundPlayer grenadeOut = new SoundPlayer(Properties.Resources.gout);
            SoundPlayer kapow = new SoundPlayer(Properties.Resources.boom);

            //Frame 1
            grenadeOut.Play();
            Graphics formGraphics = this.CreateGraphics();
            Pen blackPen  = new Pen(Color.Black, 2);
            SolidBrush grayFill = new SolidBrush(Color.Gray);
            SolidBrush blackFill = new SolidBrush(Color.Black);
            SolidBrush head = new SolidBrush(Color.Beige);
            SolidBrush bod = new SolidBrush(Color.Red);
            SolidBrush brown = new SolidBrush(Color.Chocolate);
            SolidBrush pelvisAndLeg = new SolidBrush(Color.Blue);
            SolidBrush red = new SolidBrush(Color.DarkRed);
            SolidBrush orange = new SolidBrush(Color.Orange);
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

            Thread.Sleep(1500);
            formGraphics.Clear(Color.Gray);
            //frame2

            //ball
            formGraphics.FillEllipse(blackFill, -10, 25, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 3

            //ball
            formGraphics.FillEllipse(blackFill, 0, 25, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //frame 4

            //ball
            formGraphics.FillEllipse(blackFill, 15, 25, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 5

            //ball
            formGraphics.FillEllipse(blackFill, 30, 25, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 6

            //ball
            formGraphics.FillEllipse(blackFill, 45, 45, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 7

            //ball
            formGraphics.FillEllipse(blackFill, 60, 65, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 8

            //ball
            formGraphics.FillEllipse(blackFill, 75, 85, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 9

            //ball
            formGraphics.FillEllipse(blackFill, 90, 105, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 10

            //ball
            formGraphics.FillEllipse(blackFill, 105, 125, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 11

            //ball
            formGraphics.FillEllipse(blackFill, 120, 145, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 12

            //ball
            formGraphics.FillEllipse(blackFill, 135, 165, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 13

            //ball
            formGraphics.FillEllipse(blackFill, 150, 200, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 14

            //ball
            formGraphics.FillEllipse(blackFill, 165, 225, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 14

            //ball
            formGraphics.FillEllipse(blackFill, 180, 245, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 15

            //ball
            formGraphics.FillEllipse(blackFill, 195, 265, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 16

            //ball
            formGraphics.FillEllipse(blackFill, 210, 285, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 17

            //ball
            formGraphics.FillEllipse(blackFill, 225, 305, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 18

            //ball
            formGraphics.FillEllipse(blackFill, 240, 325, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 19

            //ball
            formGraphics.FillEllipse(blackFill, 255, 345, 25, 25);

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

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 20

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion
            formGraphics.FillEllipse(red, 255, 345, 25, 25);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 22
            kapow.Play();

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion
            formGraphics.FillEllipse(red, 255, 325, 45, 45);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 23

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion
            formGraphics.FillEllipse(red, 255, 275, 65, 65);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 24

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion
            formGraphics.FillEllipse(red, 225, 255, 85, 85);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 25

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 225, 255, 85, 85);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 280, 35, 35);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 21

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 225, 255, 85, 85);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 280, 0, 0);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 22

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 225, 255, 100, 100);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 280, 50, 050);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 22

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 225, 225, 150, 150);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 260, 0, 0);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 22

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 225, 205, 200, 200);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 250, 130, 130);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 22

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 205, 175, 250, 250);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 250, 0, 0);

            Thread.Sleep(200);
            formGraphics.Clear(Color.Gray);
            //Frame 22

            //ball
            formGraphics.FillEllipse(blackFill, -30, 25, 25, 25);

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

            //explosion red
            formGraphics.FillEllipse(red, 205, 175, 250, 250);

            //explotion orange
            formGraphics.FillEllipse(orange, 250, 250, 0, 0);
        }
    }
}
