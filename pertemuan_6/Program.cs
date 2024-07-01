using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Time objTime = new Time(2005, 7, 8, 23, 50, 59);
            Console.WriteLine("Year : " + objTime.year);
            Console.WriteLine("Month : " + objTime.month);
            Console.WriteLine("Date : " + objTime.date);
            Console.WriteLine("Hour : " + objTime.hour);
            Console.WriteLine("Minute : " + objTime.minute);
            Console.WriteLine("Second : " + objTime.second);
        }
    }
}
