﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.shapes
{
    class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Draw Rectangle {X} {Y} {Width} {Height}");
        }
    }
}
