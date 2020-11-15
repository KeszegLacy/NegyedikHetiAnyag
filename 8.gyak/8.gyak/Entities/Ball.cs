﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using _8.gyak.Abstractions;

namespace _8.gyak.Entities
{
   public class Toy: Abstractions.Toy
    {

        public Toy()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint+=Ball_Paint
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

        public void MoveBall() {

            Left += 1;
        }
    }
}
