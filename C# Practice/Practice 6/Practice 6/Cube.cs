using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Cube : ThreeDim
    {
        public Cube(int size)
        {
            TYPE = 6;
            unit = size;
            calc_area();
            calc_vol();
        }
        public void calc_area()
        {
            area = unit * unit * 6;      
        }
        public void calc_vol()
        {
            volume = Math.Pow(unit, 3);
        }
    }
}
