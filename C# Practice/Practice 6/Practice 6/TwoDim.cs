using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    abstract class TwoDim : Shape //둘레, 넓이
    {
        

        public override void calc_area()
        { }
        public abstract void calc_peri();
        protected double perimeter;

            /*
            switch (type)
            {
                case "triangle":
                    {
                        area = t1.calc_area(a);
                        Console.WriteLine("도형의 넓이 : {0}\n",area);
                        break;
                    }
                case "square":
                    {
                        area = s1.calc_area(a);
                        Console.WriteLine("도형의 넓이 : {0}\n", area);
                        break;
                    }
                case "circle":
                    {
                        area = c1.calc_area(a);
                        Console.WriteLine("도형의 넓이 : {0}\n", area);
                        break;
                    }
            }
            return area;
        }

        public override double calc_length(double a, string type)
        {
            switch (type)
            {
                case "triangle":
                    {
                        length = t1.calc_length(a);
                        Console.WriteLine("도형의 둘레 : {0}\n", area);
                        break;
                    }
                case "square":
                    {
                        length = s1.calc_length(a);
                        Console.WriteLine("도형의 둘레 : {0}\n", area);
                        break;
                    }
                case "circle":
                    {
                        length = c1.calc_length(a);
                        Console.WriteLine("도형의 둘레 : {0}\n", area);
                        break;
                    }
            }
            return area;
        }
             * */
    }
}
