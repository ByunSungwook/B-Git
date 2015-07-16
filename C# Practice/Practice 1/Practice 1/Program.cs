using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    /* #2
class dog
{
    public void sound()
    {
        Console.WriteLine("월요일만 되면 짖는 개 월월월월월월월월");
    }
}
class cat
{
    public void sound()
    {
        Console.WriteLine("Meow~");
    }
}
*/


    /* #3
    class gugu
    {
        private int [,]arr = new int [9,3];
        public void setgugu(int a)
        {
            for (int i = 0; i < 9; i++ )
            {
                arr[i, 0] = a;
                arr[i, 1] = i + 1;
                arr[i, 2] = arr[i, 0] * arr[i, 1];

                Console.WriteLine(arr[i, 0] + " * " + arr[i, 1] + " = " + arr[i, 2]);
            }
        }
    }
    */

    static class consta
    {
        public const double pi = 3.14;
    }

    class circle
    {

        private double length(int a)
        {
            return 2 * a * consta.pi;
        }
        private double area(int a)
        {
            return a * a * consta.pi;
        }

        public void print(int a)
        {
            circle c1 = new circle();
            Console.WriteLine("둘레 : " + c1.length(a));
            Console.WriteLine("넓이 : " + c1.area(a));
        }
    }


    class Program
    {   
        static void Main(string[] args)
        {

            /* #1
            string a = Console.ReadLine();
            Console.WriteLine("Hello world! I'm "+ a );
             */

            
            /* #2
            Console.Write("어떤 동물의 울음소리를 듣고 싶으신가요? : " );
            string a = Console.ReadLine();
            if (a == "dog")
            {
                dog d1 = new dog();
                d1.sound();
            }
            else if (a == "cat")
            {
                cat c1 = new cat();
                c1.sound();
            }
            else 
            {
                Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
            }
             */

            /* #3
            Console.Write("구구단 중에 보고싶은 단을 골라주세요 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            gugu g1 = new gugu();
            g1.setgugu(a);
            */

            Console.Write("원의 반지름은? : ");
            int a = Convert.ToInt32(Console.ReadLine());
            circle c1 = new circle();
            c1.print(a);
        }
    }
}
