using System;
using System.Collections.Generic;
using System.Text;

namespace CommonStandard.Models.Math
{
    public struct Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Point(double x, double y)
        {
            X = (float)x;
            Y = (float)y;
        }
    }
}
