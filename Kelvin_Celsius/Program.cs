using Kelvin_Celsius.Model;
using System;

namespace Kelvin_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the celsius for convert to Kelvin");
            double a = Convert.ToDouble(Console.ReadLine());
            Celsius celsius = new Celsius(a);
            Kelvin kelvin = celsius;

            Console.WriteLine(kelvin.Degree);
           



        }
    }
}
