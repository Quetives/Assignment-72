using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_72
{
    class Program
    {
        static void Main(string[] args)
        {
            string Co, Po, Fe, He;
            int Hr, Pg;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            Co = (Console.ReadLine());

            Console.WriteLine("What page number?");
            Pg = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            He = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Po = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Fe = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            Hr = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
