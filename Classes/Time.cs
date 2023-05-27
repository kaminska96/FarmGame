using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FarmGame
{
    public class Time
    {
        private int days;
        public Time()
        {
            days = 1;
        }
        public Time(int x)
        {
            days = x;
        }
        public int getDays() { return days; }
        public string daysUpdate()
        {
            return days.ToString();
        }
        public void increaseDays()
        {
            days++;
        }
        public void increaseDays(Label l)
        {
            days++;
            l.Text = daysUpdate();
            //return;
        }
        public static Time operator +(Time t, int val) => new Time(t.days + val);
    }
}
