using System;

namespace M4._1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your input format:");
            String input = Console.ReadLine();

            if(Int32.Parse(input) == 1)
            {
                Console.WriteLine("Please enter the (year month day) in that format:");
                String[] oneI = Console.ReadLine().Split(' ');
                Date one = new Date(Int32.Parse(oneI[0]), Int32.Parse(oneI[1]), Int32.Parse(oneI[2]));
                one.printInformation();
            }
            else
            {
                Console.WriteLine("Please enter the (month/day/year) in that format:");
                Date two = new Date(Console.ReadLine());
                two.printInformation();
            }
            
        }
    }
}
