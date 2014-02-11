using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryTest1
{
    public class Functions
    {
        /// <summary>
        /// формула y = aX2 + bX + c
        /// </summary>
        /// <param name="a">параметр A</param>
        /// <param name="b">параметр B</param>
        /// <param name="c">параметр C</param>
        /// <param name="x">параметр X</param>
        /// <returns>возвращает double формула y = aX2 + bX + c</returns>
        public double Polinom(double a, double b, double c, double x)
        {
            double y = (a * a * x) + (b * x) + c;
            return y;
        }

        /// <summary>
        /// формула y = aX2 + bX + c + d
        /// </summary>
        /// <param name="a">параметр A</param>
        /// <param name="b">параметр B</param>
        /// <param name="c">параметр C</param>
        /// <param name="x">параметр X</param>
        /// <param name="d">параметр D</param>
        /// <returns>возвращает double формула y = aX2 + bX + c + d</returns>
        public double Polinom(double a, double b, double c, double x, double d)
        {
            double y = (a * a * x) + (b * x) + c + d;
            return y;
        }
    }
}
