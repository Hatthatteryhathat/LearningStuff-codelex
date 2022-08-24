using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return (double)length * (double)width;
        }

        public static double AreaOfTriangle(decimal ground, decimal height)
        {
            return 0.5 * (double)ground * (double)height;
        }
    }
}
