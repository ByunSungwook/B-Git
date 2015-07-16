using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4
{
    public class product
    {
        protected string date;
        protected string detail;
        protected int amount;

        public string DATE
        {
            get { return date; }
            set { date = value; }
        }
        public string DETAIL
        {
            get { return detail; }
            set { detail = value; }
        }
        public int AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
