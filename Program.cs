using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please,enter number seconds");
            string timeString;
            timeString = Console.ReadLine();
            int time = Convert.ToInt32(timeString);
            int minute = time / 60;
            int second = time - (minute * 60);
            int hour = minute / 60;
            minute = minute - (hour * 60);
            Console.WriteLine("hh=" + hour + " " + "mm=" + minute + " " + "ss=" + second);
        }
    }
}
