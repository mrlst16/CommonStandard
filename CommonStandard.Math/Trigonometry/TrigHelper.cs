using System;
using System.Collections.Generic;
using System.Text;

namespace CommonStandard.Math.Trigonometry
{
    public static class TrigHelper
    {
        public static float Radians(float degrees)
        {
            var rolledBackDegrees = degrees;
            while (rolledBackDegrees >= 360)
                rolledBackDegrees -= 360;

            return (float)((rolledBackDegrees * System.Math.PI) / 180);
        }
    }
}
