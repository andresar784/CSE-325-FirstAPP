using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create two variables to store your values
            string name = "Andres";
            string country = "Uruguay";
            //Output two WriteLine statements that display those two variables
            //with proper labels (My name is ... , I am from ...) using String Interpolation.
            string output = $"My name is name {name}, I am from {country}";
            Console.WriteLine(output);
            //Output the current date, but not the current time.
            DateTime localTime = DateTime.Now;
            //Give the format
            Console.WriteLine(localTime.ToString("MM / dd / yyyy"));
            //Output the number of days until Christmas this year and
            DateTime christmasThisYear = new DateTime(DateTime.Now.Year, 12, 25);
            // Calculate the number of days until Christmas
            TimeSpan timeUntilChristmas = christmasThisYear - DateTime.Now;
            int daysUntilChristmas = timeUntilChristmas.Days;
            Console.WriteLine("There are " + daysUntilChristmas + " days until Christmas this year.");
            //Add the program example from section 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            //Provide appropriate text labels when requesting dimensional input
            Console.Write("Enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            //// Pause the program by waiting for user input
            Console.WriteLine("Press Enter to exit...");
            Console.ReadKey();

        }
    }
}
