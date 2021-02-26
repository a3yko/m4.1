using System;
using System.Collections.Generic;
using System.Text;

namespace M4._1
{
    class Date
    {

        struct Day{
           public int year;
           public int month;
           public int day;
        }
           private Day d = new Day();
           String[] items;
        public Date(int year, int month, int day)
        {
            d.day = day;
            d.year = year;
            d.month = month;
        }
        public Date(string dateString)
        {
            String[] items = dateString.Split('/');
            d.month = Int32.Parse(items[0]);
            d.day = Int32.Parse(items[1]);
            d.year = Int32.Parse(items[2]);
        }

        public void printInformation()
        {
            switch (d.month)
            {
                case 01:
                    Console.WriteLine("Today is Jan," + d.day + "," + d.year);
                    break;
                case 02:
                    Console.WriteLine("Today is Feb," + d.day + "," + d.year);
                    break;
                case 03:
                    Console.WriteLine("Today is Mar," + d.day + "," + d.year);
                    break;
                case 04:
                    Console.WriteLine("Today is Apr," + d.day + "," + d.year);
                    break;
                case 05:
                    Console.WriteLine("Today is May," + d.day + "," + d.year);
                    break;
                case 06:
                    Console.WriteLine("Today is Jun," + d.day + "," + d.year);
                    break;
                case 07:
                    Console.WriteLine("Today is Jul," + d.day + "," + d.year);
                    break;
                case 08:
                    Console.WriteLine("Today is Aug," + d.day + "," + d.year);
                    break;
                case 09:
                    Console.WriteLine("Today is Sep," + d.day + "," + d.year);
                    break;
                case 10:
                    Console.WriteLine("Today is Oct," + d.day + "," + d.year);
                    break;
                case 11:
                    Console.WriteLine("Today is Nov," + d.day + "," + d.year);
                    break;
                case 12:
                    Console.WriteLine("Today is Dec," + d.day + "," + d.year);
                    break;
            }
        }
    }
}
