using System;

public class HomeSales2 : IAssignment
{
    public void Run()
    {
        string[] salespeople = { "Danielle", "Edward", "Francis" }; 
        char[] initials = { 'D', 'E', 'F' };
        decimal[] salesTotals = new decimal[3]; //Arrays created to store sales people name, initials, sales total 

        char initial; //variable to store input from user

        do
        {
            Console.Write("\nPlease enter the salesperson's first name initial: "); 
            initial = Console.ReadKey().KeyChar; //reads user input and stores it in initial variable

            initial = char.ToUpper(initial); // Convert the user's input to uppercase

            if (!char.IsLetter(initial) || !(initial == 'D' || initial == 'E' || initial == 'F')) // Validates input, (if input is not D/E/F)
            {
                Console.WriteLine("\nInvalid input. Please enter a valid initial.");
                continue; // Loops until valid input is detected 
            }

            Console.Write("\n\nEnter the amount of the sale for {0}: ", initial); // Prompt for the sale amount

            decimal saleAmount;

            while (!decimal.TryParse(Console.ReadLine(), out saleAmount)) // Parse the user's input as a decimal
            {
                Console.WriteLine("Please enter a valid numeric value for the sale amount:");
            }

            int index = Array.IndexOf(initials, initial); // Find the index of the initial in the initials array
            if (index >= 0) // If the initial is found in the array
            {
                salesTotals[index] += saleAmount; // Add the sale amount to the corresponding total
                Console.WriteLine($"\nSale processed for {salespeople[index]} with a sale amount of {saleAmount}.");
                Console.WriteLine("-----------------------------------------");
            }

        } while (initial != 'Z' && initial != 'z'); // Loop until 'Z' or 'z' is entered

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nSales Totals:");
        decimal grandTotal = 0m;
        int highestSellerIndex = -1;
        decimal highestTotal = 0m; 

        for (int i = 0; i < salespeople.Length; i++) // Iterate over each salesperson
        {
            Console.WriteLine($"{salespeople[i]} ({initials[i]}): {salesTotals[i]:C}");
            grandTotal += salesTotals[i]; // Add to grand total
            if (salesTotals[i] > highestTotal)
            {
                highestTotal = salesTotals[i]; // Update highest total
                highestSellerIndex = i; // Update index of the highest seller
            }
        }

        string formattedGrandTotal = grandTotal.ToString("C");
        string formattedHighestTotal = highestTotal.ToString("C");

        if (highestSellerIndex >= 0) // If there is a highest seller
        {
            Console.WriteLine($"\nGrand Total: {formattedGrandTotal}");
            Console.WriteLine($"Highest seller: {salespeople[highestSellerIndex]} ({initials[highestSellerIndex]}) with a total of {formattedHighestTotal}\n");
        }
    }
}