﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_tesy_app
{
    public partial class funDrawing : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public funDrawing()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)

            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.ForeColor=Color.White;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
