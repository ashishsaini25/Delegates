﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void RectangleDelete(double Width, double Height);
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(@"Area is {0}", (Width * Height));
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelete rectDelegate = new RectangleDelete(rect.GetArea);
            rectDelegate += rect.GetPerimeter;
            rectDelegate(23.45, 67.89);
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);
            Console.ReadKey();
        }
    }
}
