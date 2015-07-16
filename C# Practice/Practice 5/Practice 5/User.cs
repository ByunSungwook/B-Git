using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5
{
    public class User
    {
        List<Table> t1 = new List<Table>(10);
        POS p1 = new POS();
        Menu m1 = new Menu();

        public void Clerk_Order()
        {
            Console.Write("Check the table number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if ( t1[num].CUSTOM == 0)
            {
                Console.Write("First Ordered. How many customers are there? : ");
                int customer = Convert.ToInt32(Console.ReadLine());
                t1[num].CUSTOM = customer;
                Console.Write("Enter the menu : ");
                string menu_order = Console.ReadLine();
                t1[num].OMENU[0] = menu_order;
                for (int i = 0; i < 10; i++ )
                {
                    if (menu_order == m1.MENU[i])
                    {
                        t1[num].OPRICE[0] = m1.PRICE[i];
                    }
                }
                p1.Clerkmode();
            }
            else
            {
                Console.Write("Enter the menu : ");
                string menu_order = Console.ReadLine();
                t1[num].OMENU.Add(menu_order);
                for (int i = 0; i < 10; i++)
                {
                    if (menu_order == m1.MENU[i])
                    {
                        t1[num].OPRICE.Add(m1.PRICE);
                    }
                }
                p1.Clerkmode();
            }
            
            
        }
        public void Clerk_Checklist()
        {
            Console.WriteLine("1. Calculation / 2. back ");
            Console.Write("Choose function you want.");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the table number to caculate: ");
                        int tnum = Convert.ToInt32(Console.ReadLine());
                        int i=0;
                        int total = 0;
                        int amount = t1[num].OPRICE.Count;
                        while (i<amount)
                        {
                            total += Convert.ToInt32(t1[num].OPRICE[i]);
                            i++;
                        }
                        break;
                    }
                case 2:
                    {
                        p1.Clerkmode();
                        break;
                    }
            }

        }

        public void Admin_chkprofit()
        {

        }
        public void Admin_clrprofit()
        {

        }
    }
}
