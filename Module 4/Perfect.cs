public class Perfect : IAssignment //Assigned the class to the interface
{
    public void Run()
    {
                int number; // Variable to store the user's input

        
                bool isValidInput = false; // Flag to indicate if the input is valid
        
                while (!isValidInput) // Loop to keep asking for input until a valid number is entered
        
                {
                    System.Console.Write("Enter a number between 1 and 10000: ");
                    string input = System.Console.ReadLine();
                    if (int.TryParse(input, out number) && number >= 1 && number <= 10000)// Try to parse the input to an integer and check if it's within the valid range
            
                    {
                        isValidInput = true;
                        // Check if the number is perfect within the loop
                        if (IsPerfect(number))
                        {
                            System.Console.WriteLine("Perfect Number");
                        }
                        else
                        {
                            System.Console.WriteLine("Not a Perfect Number");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Please enter a valid number between 1 and 10000.");
                    }
                }
            }
            static bool IsPerfect(int num)  // Method to check if a number is perfect
            {
                int sumOfDivisors = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sumOfDivisors += i;
                    }
                }
                return sumOfDivisors == num;
            }
        }
    
// Unit Test Inputs: 496 68 5112 8128