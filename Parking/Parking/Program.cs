using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    static class Constants
    {
        public const int Car = 500;
        public const int Truck = 1000;
        public const int Bus = 700;
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주차장에 오신것을 환영합니다.");
            while (true)
            {
                Console.WriteLine("승용차 : C , 트럭 : T , 버스 : B");
                Console.Write("차종을 입력하여 주십시오. : ");
                char car = char.Parse(Console.ReadLine());
                Console.Write("주차 시간을 입력하여주십시오. (단위: 분) : ");
                int time = Int16.Parse(Console.ReadLine());
                if ((car == 'c') || (car == 't') || (car == 'b'))
                {
                    farecheck(ref car, ref time);
                    break;
                }
                else if ((car == 'C') || (car == 'T') || (car == 'B'))
                {
                    car = char.ToLower(car);
                    farecheck(ref car, ref time);
                    break;
                }
                else if (time <= 30)
                {
                    time = 30;
                    farecheck(ref car, ref time);
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력하여 주십시오.");
                    continue;
                }
            }
        }

        public static void farecheck(ref char car, ref int time)
        {
            int num = time/30;
            switch (car)
            {
                case 'c':
                    {
                        Console.WriteLine("주차요금은 총 {0} 원입니다.", num * Constants.Car);
                        break;
                    }
                case 't':
                    {
                        Console.WriteLine("주차요금은 총 {0} 원입니다.", num * Constants.Truck);
                        break;
                    }
                case 'b':
                    {
                        Console.WriteLine("주차요금은 총 {0} 원입니다.", num * Constants.Bus);
                        break;
                    }
            }
        }
    }
}