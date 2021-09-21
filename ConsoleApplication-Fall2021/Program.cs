using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Fall2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // name
            string name; // = "Brother Thayne";
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            // location
            string location; // = "Rexburg, ID";
            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

            // output
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You are from: {location}");

            // date
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: { currentDate.ToString("d")}");


            Console.Write("Press any key to quit");
            Console.ReadKey();
        }
    }
}
