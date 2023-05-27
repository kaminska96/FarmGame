using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmGame
{
    public class Cash
    {
        private int money;
        public Cash()
        {
            money = 500;
        }
        public Cash(int x)
        {
            money = x;
        }
        public int getMoney() { return money; }
        public string cashUpdate()
        {
            return money.ToString();
        }
        public static Cash operator +(Cash c, int val) => new Cash(c.money + val);
        public static Cash operator -(Cash c, int val) => new Cash(c.money - val);
    }
}
