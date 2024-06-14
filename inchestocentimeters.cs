using System;

class Program{
   private const double CentimetersPerInch = 2.54;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a measurement in inches:");
            double inches = Convert.ToDouble(Console.ReadLine());

            double centimeters = InchesToCentimeters(inches);
            Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        }

        static double InchesToCentimeters(double inches)
        {
            return inches * CentimetersPerInch;}
    }  
