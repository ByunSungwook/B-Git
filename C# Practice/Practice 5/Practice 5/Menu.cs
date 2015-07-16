using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5
{
    public class Menu
    {
        private string[] menu = new string [10];
        private int[] price = new int [10];

        private void set_menu()
        {
            menu[0] = "Gyudon";   price[0] = 6500;
            menu[1] = "Gatsudon";   price[1] = 7000;
            menu[2] = "Ebidon";   price[2] = 7500;
            menu[3] = "Sakedon";   price[3] = 11000;
            menu[4] = "Hakata";   price[4] = 7500;
            menu[5] = "Akasaka";   price[5] = 7500;
            menu[6] = "Kyushu";   price[6] = 8000;
            menu[7] = "Yokohama";   price[7] = 8000;
            menu[8] = "Gyojamandu";   price[8] = 5000;
            menu[9] = "Bap";   price[9] = 1000;

        }

        public string[]  MENU
        {
            get { return menu; }
            set { menu = value; }
        }

        public int[] PRICE
        {
            get { return price; }
            set { price = value; }
        }

    }
}