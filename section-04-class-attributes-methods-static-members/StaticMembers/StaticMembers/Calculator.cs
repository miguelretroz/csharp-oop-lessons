//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Calculator
    {
        public static double Pi = 3.14;

        public static double Circumference(double radius)
        {
            return 2.0 * Pi * radius;
        }

        public static double Volume(double radius)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(radius, 3.0);
        }
    }
}
