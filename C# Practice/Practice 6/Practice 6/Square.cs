using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Square : TwoDim //둘레, 넓이
    {
        public Square(int size)
        {
            TYPE = 4;
            unit = size;
            calc_area();
            calc_peri();
        }
        public override void calc_area()
        {
            area = unit * unit;
        }
        public override void calc_peri()
        {
            perimeter = unit * 4;
        }
        /*
        public double calc_area(double a)
        {
            double area = a * a;
            return area;
        }
        public double calc_length(double a)
        {
            double length = a * 4;
            return length;
        }
         * */
    }
}
