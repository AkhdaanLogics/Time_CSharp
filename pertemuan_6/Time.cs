using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Time
    {
        public int year;
        public int month;
        public int date;
        public int hour;
        public int minute;
        public int second;

        public Time(int year, int month, int date, int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
