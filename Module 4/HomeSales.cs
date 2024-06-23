using System;
using System.Collections.Generic; //importing namespace to be able to use dictionary 

public class HomeSales : IAssignment //change AssignmentName to program name


{
    public void Run()
    {
Dictionary<char, decimal> salesTotals = new Dictionary<char, decimal>(); // calls to dictionary to store sales totals in a list 
        char initial; // defined variable for intial of person

        do //establishing a loop to run the program until the user enters 'z' or 'Z'
        {
            Console.Write("\nPlease enter the salesperson's first name initial: ");
            initial = Console.ReadKey().KeyChar;

            initial = char.ToUpper(initial); //convert the users input to uppercase

            // Check if the initial is already present in the dictionary and if it's not an uppercase letter

            if (salesTotals.ContainsKey(initial) &&!char.IsUpper(initial))
            {
                Console.WriteLine("/nInvalid input. Please enter a valid initial.");
                continue;
            }

            if (!char.IsLetter(initial) ||!(initial == 'D' || initial == 'E' || initial == 'F')) //validates input to ensure its a key as defined
            {
                Console.WriteLine("\nInvalid input. Please enter a valid initial.");
                continue; //skips loop once valid input is detected
            }

            Console.Write("\n" + "\nEnter the amount of the sale for {0}: ", initial); //the sale has been processed.


            decimal saleAmount; //declares decimal variable to store the sales amount 

            while (!decimal.TryParse(Console.ReadLine(), out saleAmount)) //Tries to parse the user's input as a decimal. If unsuccessful, prompts the user again.

            {
                Console.WriteLine("Please enter a valid numeric value for the sale amount:");
            }

            if (!salesTotals.ContainsKey(initial))// Adds the sale amount to the corresponding initial in the dictionary. If the initial doesn't exist yet, initializes it to 0.

            {
                salesTotals[initial] = 0m;
            }

            salesTotals[initial] += saleAmount; // Adds the sale amount to the existing total for the initial.

            Console.WriteLine($"\nSale processed for {initial} with a sale amount of {saleAmount}.");
            Console.WriteLine("-----------------------------------------");

        } while (initial!= 'Z' && initial!= 'z');


        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nSales Totals:");
        decimal grandTotal = 0m;
        char highestSellerInitial = ' ';
        decimal highestTotal = 0m;

        // above initializes diff variables to track total sales, highest seller, and grand total

        foreach (var entry in salesTotals) // Iterates over each entry in the salesTotals dictionary.
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}"); // Displays the initial and its corresponding sales total.
            grandTotal += entry.Value;
            if (entry.Value > highestTotal)
            {
                highestTotal = entry.Value; // Updates the highest total if the current total is higher.
                highestSellerInitial = entry.Key; // Updates the initial of the highest seller.
            }
        }


        string formattedGrandTotal = grandTotal.ToString("C"); 
        string formattedHighestTotal = highestTotal.ToString("C");// Formatting grandTotal and highestTotal as currency

        Console.WriteLine($"\nGrand Total: " + formattedGrandTotal);
        Console.WriteLine($"Highest seller: {highestSellerInitial} with a total of " + formattedHighestTotal + "\n"); // Outputs the grand total and the details of the highest seller, formatted as currency.
    }
}







