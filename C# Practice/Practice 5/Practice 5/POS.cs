using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5
{
    class POS
    {
        public void run()
        {
            login();
            List<Table> t1 = new List<Table>(10);
        }
        public void login()
        {
            bool endsign = false;
            while (!endsign)
            {
                Console.Write("Enter your ID : ");
                string id = Console.ReadLine();
                Console.Write("Enter your Password : ");
                string pw = Console.ReadLine();

                if (id == "2011101387" && pw == "1206")
                {
                    Console.Clear();
                    Clerkmode();
                }
                else if (id == "admin" && pw == "admin")
                {
                    Console.Clear();
                    Adminmode();
                }
                else
                {
                    Console.WriteLine("Invalid Value. Please Try Again.");
                }
            }
        }
        public void Clerkmode()
        {
            Console.WriteLine("<Clerk mode>");
            Console.WriteLine("1. Order / 2. Check List / 3. Log out ");
            Console.Write("Choose the function you want : ");
            int func = Convert.ToInt32(Console.ReadLine());

            User u1 = new User();
            bool endsign = false;

            while (!endsign)
            {
                switch (func)
                {
                    case 1:
                        {
                            u1.Clerk_Order();
                            break;
                        }
                    case 2:
                        {
                            u1.Clerk_Checklist();
                            break;
                        }
                    case 3:
                        {
                            clerk_Logout();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Value. Please Try Again)");
                            break;
                        }
                }
            }
        }
        public void Adminmode()
        {
            Console.WriteLine("<Administrator mode>");
            Console.WriteLine("1. Check profit / 2. Cancel profit / 3. Log out ");
            Console.Write("Choose the function you want : ");
            int func = Convert.ToInt32(Console.ReadLine());

            User u1 = new User();
            bool endsign = false;

            while (!endsign)
            {
                switch (func)
                {
                    case 1:
                        {
                            u1.Admin_chkprofit();
                            break;
                        }
                    case 2:
                        {
                            u1.Admin_clrprofit();
                            break;
                        }
                    case 3:
                        {
                            admin_Logout();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Value. Please Try Again)");
                            break;
                        }
                }
            }
        }

        public void clerk_Logout()
        {
            Console.Clear();
            bool endsign = false;
            while (!endsign)
            {
                Console.Write("Are you Sure? ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        {
                            endsign = true;
                            Console.Clear();
                            this.run();
                            break;
                        }
                    case "no":
                        {
                            endsign = true;
                            Console.Clear();
                            this.Clerkmode();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Value. Please Try Again.");
                            break;
                        }
                }
            }
        }
        public void admin_Logout()
        {
            Console.Clear();
            bool endsign = false;
            while (!endsign)
            {
                Console.Write("Are you Sure? ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        {
                            endsign = true;
                            Console.Clear();
                            this.run();
                            break;
                        }
                    case "no":
                        {
                            endsign = true;
                            Console.Clear();
                            this.Adminmode();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Value. Please Try Again.");
                            break;
                        }
                }
            }
        }
    }
}
