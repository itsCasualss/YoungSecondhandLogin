using System;
using System.Collections.Generic;

public class TemperaturesComparison : IAssignment 
{
    public void Run()
    {
        int[] temperatures = new int[5]; //declare the array to hold 5 values for temperature
        bool isValidTemperature; //variable to track if input is valid
        string input;//var to store user input


        

        Console.WriteLine("Use Farenheit between -30 to 130 degrees\n"+ "Use whole numbers only\n"); // print instructions once to user for desired input values


        
        
        //loop created to collect 5 valid temperatures
        for (int i = 0; i < temperatures.Length; i++)
        {
            do
            {
                Console.Write("Please enter a temperature: "); //prompt user for input
                
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out int temp) || temp < -30 || temp > 130) //parse input from user into an integer
                {
                    Console.WriteLine("\nInvalid temperature. Please enter a number between -30 and 130."); //if unable to parse or temp is out of range, ask for another value 

                    
                    isValidTemperature = false; //marks user input as false
                }
                else
                {
                    isValidTemperature = true;
                    temperatures[i] = temp;
                    //if input is valid, stores the input into the above array
                }
            } while (!isValidTemperature); //keep asking for values until 5 is met 
        }



        
        int sum = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            sum += temperatures[i];
        }
        //above for loop and integer creates a sum of all temperatures in the array

        
        double average = (double)sum / temperatures.Length;//calulates the average temps by adding all temps and dividing by the number of temps

        bool gettingWarmer = true;
        bool gettingCooler = true;
        //variables introduced to track if the temps are getting warmer or cooler
        

        
        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] >= temperatures[i - 1]) //if temp is > or = to the previous temp
            {
                gettingCooler = false;//temperatures are getting warmer
            }
            else if (temperatures[i] <= temperatures[i - 1])
            {
                gettingWarmer = false; //temperatures are getting cooler
            }
        }

        if (gettingCooler &&!gettingWarmer) //determines if warming up, getting cooler, or mixed temps 
        {
            Console.WriteLine("\nGetting Coolder.");
        }
        else if (!gettingCooler && gettingWarmer)
        {
            Console.WriteLine("\nGetting Warmer.");
        }
        else
        {
            Console.WriteLine("\nIt's a mixed bag!");
        }

        Console.WriteLine("\n5-day Temperature:");
        foreach (var temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine($"\nAverage temperature: {average}");//displays calculated averages
    }
}