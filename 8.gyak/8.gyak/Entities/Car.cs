using _8.gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gyak.Entities
{
    class Car : Abstractions.Toy
    {
        protected override void DrawImage(Graphics graphics)
        {
            Image imagefile = Image.FromFile("Images/auto.png");
            graphics.DrawImage(imagefile, new Rectangle(0, 0, Width, Height));


            
        }

    }
}
