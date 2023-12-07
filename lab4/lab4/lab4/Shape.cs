﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Shape
    {

        protected double X;
        protected double Y;
        protected double Height;
        protected double Width;

        public Shape()
        {
            X = 0;
            Y = 0;
            Height = 0;
            Width = 0;
        }

        public Shape(double x, double y, double height, double width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public virtual void Draw()
        {

        }



    }



}
