public class MoveEstimator : IAssignment
{
    public void Run()
    {
        {
            double baserate;
            double hours;
            double miles;
            double num01;
            double num02;

            System.Console.Write("Please enter the number of hours for the move:"); //asks for input for number of hours

            num01 = System.Convert.ToDouble(System.Console.ReadLine()); //converts user input to double 
            
            System.Console.Write("Please enter the number of miles for the move: "); //asks user how far they are moving

            num02 = System.Convert.ToDouble(System.Console.ReadLine()); //converts user input to double

            baserate = 200; //creating a variable for the base rate
            hours = 150;
            miles = 2; 

            double result = baserate + (hours * num01) + (miles * num02); //multiplying the user
            string formattedResult = result.ToString("C"); // formatting the result to currency

            System.Console.WriteLine("The total cost for the move is: " + formattedResult); 
            
        }
        
    }
} 