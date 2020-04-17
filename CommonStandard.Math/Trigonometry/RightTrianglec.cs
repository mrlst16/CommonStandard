using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CommonStandard.Math.Trigonometry
{
    public static class RightTriangle
    {
        public static (float, float) CalulatePointFromDegreesAndHyptoneus(float degrees, float hypotenuse)
        {
            var radians = TrigHelper.Radians(degrees);

            float x = (float)System.Math.Cos(radians) * hypotenuse;
            float y = (float)System.Math.Sin(radians) * hypotenuse;
            return (x, y);
        }

        public static (float, float) CalulatePointFromDegreesAndHyptoneus(float degrees, double hypotenuse)
            => CalulatePointFromDegreesAndHyptoneus(degrees, (float)hypotenuse);
    }
}
