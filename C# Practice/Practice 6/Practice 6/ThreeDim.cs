using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    abstract class ThreeDim : Shape //겉넓이, 부피
    {
        public override void calc_area() { }
        public abstract void calc_vol();
        protected double volume;
       /* Cube c1 = new Cube();
        Sphere s1 = new Sphere();
        protected double area;
        protected double volume;

        public double area { get; set; }
        public double volume { get; set; }

        public override void calc_area(double a, string type)
        {
            switch (type)
            {
                case "sphere":
                    {
                        s1.calc_area(a);
                        break;
                    }
                case "cube":
                    {
                        c1.calc_area(a);
                        break;
                    }
            }
        }
        public override void calc_volume(double a, string type)
        {
            switch (type)
            {
                case "sphere":
                    {
                        s1.calc_volume(a);
                        break;
                    }
                case "cube":
                    {
                        c1.calc_volume(a);
                        break;
                    }
            }
        }
        * */
    }
}
