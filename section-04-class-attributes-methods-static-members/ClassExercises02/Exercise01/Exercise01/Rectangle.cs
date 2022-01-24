using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise01
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return Width * 2.0 + Height * 2.0;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2.0) + Math.Pow(Height, 2.0));
        }

        public override string ToString()
        {
            return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Perímetro = " + Perimeter().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
