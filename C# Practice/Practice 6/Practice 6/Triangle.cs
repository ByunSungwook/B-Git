using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Triangle : TwoDim// 둘레, 넓이
    {
        public Triangle(int size)
        {
            TYPE = 3;
            unit = size;
            calc_area();
            calc_peri();
        }
        public override double calc_area()
        {
            double area = unit * ((Math.Sqrt(3)) / 4);
            return area;
        }
        public override double calc_peri()
        {
            double length = unit * 3;
            return length;
        }
    }
}
