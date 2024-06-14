public class InchesToCentimeters : IAssignment
{
    public void Run()
    {
    
       
                 {
            double num01;
            double num02;

            System.Console.Write("Enter a number in Inches: "); //asks user to type in a number

            num01 = System.Convert.ToDouble (System.Console.ReadLine()); 

            num02 = 2.54; // creating a variable

            double result = num01 * num02; // multiplying the user input 

            System.Console.WriteLine(num01 + " inches is equal to " + result + " centimeters");

            }

          }
    }
