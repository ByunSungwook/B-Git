using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Drink
    {
        protected string name;
        protected string property;
        protected string type;
    }

    class Wine : Drink
    {
        public Wine(string inputname, string inputproper, string inputtype)
        {
            name = inputname;
            property = inputproper;
            type = "Wine";
        }
    }

    class Soju : Drink
    {
        public Soju(string inputname, string inputproper, string inputtype)
        {
            name = inputname;
            property = inputproper;
            type = "Soju";
        }
    }

    class Beer : Drink
    {
        public Beer(string inputname, string inputproper, string inputtype)
        {
            name = inputname;
            property = inputproper;
            type = "Beer";
        }
    }

    class Refrigerator
    {
        private List<Drink> d1 = new List<Drink>();

        public void inputitem (string name, string property, string type)
        {

        }
        public void takeout(string name, string property, string type)
        {

        }
        public void showlist(string name, string property, string type)
        {

        }

        public void run()
        {
            while (true)
            {
                List<Drink> lists = new List<Drink>();

                string type;
                string name;
                string property;

                Console.WriteLine("0.종료 / 1. 물건 넣기 / 2. 물건 빼기 / 3. 물건 조회");
                Console.WriteLine("원하는 기능을 선택해 주세요 : ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                if (num == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다. 안녕히 가세요.");
                    break;
                }
                else if (num == 1)
                {
                    Console.WriteLine("넣기를 원하는 물건의 종류, 이름, 특징을 순서대로 적어주세요.");
                    Console.WriteLine("종류 : "); type = Console.ReadLine();
                    Console.WriteLine("이름 : "); name = Console.ReadLine();
                    Console.WriteLine("특징 : "); property = Console.ReadLine();
                    inputitem(name, property, type);
                    continue;
                }
                else if (num == 2)
                {
                    
                }
                else if (num == 3)
                {
                    
                }
                else
                {
                    Console.WriteLine("잘못된 입력값입니다. 다시 입력해 주십시오.");
                    continue;
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator r1 = new Refrigerator();
            r1.run();
        }
    }
}
