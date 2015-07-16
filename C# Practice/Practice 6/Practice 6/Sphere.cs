using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Sphere : ThreeDim
    {
        public static double pi = 3.14;
        public Sphere(int size)
        {
            TYPE = 7;
            unit = size;
            calc_area();
            calc_vol();
        }
        public void calc_area()
        {
            area = unit * unit * 4 * pi;
        }
        public void calc_volume()
        {
            volume = 4/3 * pi * (Math.Pow(unit, 3));
        }
    }
}
