using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4
{
    class moneybook
    {
        List<product> st1 = new List<product>();
        private int total=0;
        public void run()
        {
            bool endsign = false;
            while (!endsign)
            {
                Console.WriteLine("0.Exit / 1. Add / 2. Show / 3. Search ");
                Console.Write("Choose function you want : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (num)
                {
                    case 0:
                    {
                        Console.WriteLine("Program will shut down. Press any key to continue....");
                        endsign = true;
                        break;
                    }
                    case 1:
                    {
                        add();
                        break;
                    }
                    case 2:
                    {
                        checkall();
                        break;
                    }
                    case 3:
                    {
                        search();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid value. Please try again.");
                        break;
                    }
                }
            }
        }
        private void add()
        {
            product p1 = new product();
            Console.Write("Enter the date : ");
            string day = Console.ReadLine();
            Console.Write("Enter the detail : ");
            string more = Console.ReadLine();
            Console.Write("Enter the amount of money : ");
            int amom = Convert.ToInt32(Console.ReadLine());
            p1.DATE = day;
            p1.DETAIL = more;
            p1.AMOUNT = amom;
            this.total += amom;
            st1.Add(p1);
            Console.WriteLine("Complete");
        }
        private void checkall()
        {
            foreach (product list in st1)
            {
                Console.WriteLine("DATE:{0}\tDETAIL:{1}\tAMOUNT:{2}\tTOTAL:{3}" , list.DATE, list.DETAIL, list.AMOUNT, this.total);
            }
        }
        private void search()
        {
            Console.WriteLine("Choose the year you looking for : ");
            string year = Console.ReadLine();
            if (year == "0")
            {
                checkall();
            }
            else
            {
                Console.WriteLine("Choose the month you looking for : ");
                string month = Console.ReadLine();
                if (month == "0")
                {

                }
                else
                {
                    Console.WriteLine("Choose the day you looking for : ");
                    string day = Console.ReadLine();
                    if (day == "0")
                    {

                    }
                    else
                    {
                        
                    }
                }
            }
        }
    }
}
