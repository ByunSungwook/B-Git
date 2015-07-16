using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    abstract class Shape // 넓이
    {
        protected double area;
        public int TYPE { get; set; }
        public int unit { get; set; }
        abstract void calc_area();
    }
}
