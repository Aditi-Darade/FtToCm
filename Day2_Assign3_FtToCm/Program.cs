using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assign3_FtToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("If you want to convert your height from feet and inches to centimeters please enter your height in feet, press a key and then enter the remaining inches.");

            System.Console.WriteLine("Please enter your height in feet:");
            string stringfeet = System.Console.ReadLine();
            int feet = Convert.ToInt32(stringfeet);

            System.Console.WriteLine("Please enter the remaining inches in your height:");
            string stringinches = System.Console.ReadLine();
            int inches = Convert.ToInt32(stringinches);

            System.Console.Clear();

            //double centimeters = (feet * 12) + inches * 2.54;

            System.Console.WriteLine(feet + " feet " + inches + " inches in centimeters is: " + ((feet * 12) + inches) * 2.54);

            System.Console.ReadKey();
        }
    }
}
