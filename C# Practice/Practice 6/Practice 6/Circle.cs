using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Circle : TwoDim // 둘레, 넓이;
    {
        public static double pi = 3.14;

        public Circle(int size)
        {
            TYPE = 2;
            unit = size;
            calc_area();
            calc_peri();
        }
        public void calc_area()
        {
            area = unit * unit * pi;
        }
        public void calc_peri()
        {
            perimeter = 2 * unit * pi;
        }

    }
}
