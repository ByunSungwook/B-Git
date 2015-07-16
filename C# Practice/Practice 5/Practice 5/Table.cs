using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5
{
    class Table
    {
        private int customer = 0;
        private ArrayList menu_ordered = new ArrayList();
        private ArrayList price_ordered = new ArrayList();
        private bool pay = false;

        public int CUSTOM
        {
            get { return customer; }
            set { customer = value; }
        }
        public ArrayList OMENU
        {
            get { return menu_ordered; }
            set { menu_ordered = value; }
        }
        public ArrayList OPRICE
        {
            get { return price_ordered; }
            set { price_ordered = value; }
        }
        public bool PAY
        {
            get { return pay; }
            set { pay = value; }
        }
    }
}
