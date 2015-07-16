using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TwoDim> d2 = new List<TwoDim>();
            List<ThreeDim> d3 = new List<ThreeDim>();
            

            bool endsign =false;
            while(endsign)
            {
                Console.Write("몇차원의 도형인가요? : ");
                int num = Convert.ToInt16(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }
                else if (num == 2)
                {
                    Console.Clear();
                    Console.WriteLine("도형의 단위길이는 어떤가요? : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("원 : 2 / 삼각형 : 3 / 사각형 : 4 ");
                    Console.WriteLine("도형은 어떤 형태인가요? : ");
                    int shapetype = Int32.Parse(Console.ReadLine());
                    bool isExist = false;
                    foreach (var item in d2)
                    {
                        if (item.TYPE == shapetype && item.unit == amount)
                        {
                            isExist = true;
                            Console.WriteLine("이미 등록된 도형입니다.");
                            break;
                        }

                    }
                    //shapetype에 따라서
                    switch (shapetype)
                    {
                        case 2:
                            {
                                if (!isExist)
                                {
                                    TwoDim temp = new Circle(amount);
                                    d2.Add(temp);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (!isExist)
                                {
                                    TwoDim temp = new Triangle(amount);
                                    d2.Add(temp);
                                }
                                break;
                            }
                        case 4:
                            {
                                if (!isExist)
                                {
                                    TwoDim temp = new Square(amount);
                                    d2.Add(temp);
                                }
                                break;
                            }
                    }
                }
                else if (num == 3)
                {
                    Console.Clear();
                    Console.WriteLine("도형의 단위길이는 어떤가요?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("정육면체 : 6 / 구 : 7 ");
                    Console.WriteLine("도형은 어떤 형태인가요? : ");
                    int shapetype = Int32.Parse(Console.ReadLine());
                    bool isExist = false;
                    foreach (var item in d3)
                    {
                        if (item.TYPE == shapetype && item.unit == amount)
                        {
                            isExist = true;
                            Console.WriteLine("이미 등록된 도형입니다.");
                            break;
                        }
                    }

                    switch (shapetype)
                    {
                        case 6:
                            {
                                if (!isExist)
                                {
                                    ThreeDim temp = new Sphere(amount);
                                    d3.Add(temp);
                                } 
                                break;
                            }
                        case 7:
                            {
                                if (!isExist)
                                {
                                    ThreeDim temp = new Sphere(amount);
                                    d3.Add(temp);
                                }
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("유효하지 않은 입력값입니다. 다시 입력해주십시오.");
                }
            }
        }
    }
}
