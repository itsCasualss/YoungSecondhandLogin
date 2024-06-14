public class InchesToCentimeters : IAssignment
{
    public void Run()
    {
        { 
            double cm = 2.54; // creating constant variable
            double num01 = 5;
            double num02 = 50;
            double num03 = -15;
            double num04 = 15994;

            System.Console.WriteLine(num01 + " inches is equal to " + num01 * cm + " centimeters");
            System.Console.WriteLine(num02 + " inches is equal to " + num02 * cm + " centimeters");
            System.Console.WriteLine(num03 + " inches is equal to " + num03 * cm + " centimeters");
            System.Console.WriteLine(num04 + " inches is equal to " + num04 * cm + " centimeters");
    
            }  
    }
} 