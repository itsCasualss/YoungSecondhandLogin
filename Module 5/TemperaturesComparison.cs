using System;
using System.Collections.Generic;

public class TemperaturesComparison : IAssignment 
{
    public void Run()
    {
        int[] temperatures = new int[5];
        bool isValidTemperature;
        string input;

        Console.WriteLine("Use Farenheit between -30 to 130 degrees\n"+ "Use whole numbers only\n");

        for (int i = 0; i < temperatures.Length; i++)
        {
            do
            {
                Console.Write("Please enter a temperature: ");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out int temp) || temp < -30 || temp > 130)
                {
                    Console.WriteLine("\nInvalid temperature. Please enter a number between -30 and 130.");
                    isValidTemperature = false;
                }
                else
                {
                    isValidTemperature = true;
                    temperatures[i] = temp;
                }
            } while (!isValidTemperature);
        }

        int sum = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            sum += temperatures[i];
        }

        double average = (double)sum / temperatures.Length;

        bool gettingWarmer = true;
        bool gettingCooler = true;

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] >= temperatures[i - 1])
            {
                gettingWarmer = false;
            }
            else if (temperatures[i] <= temperatures[i - 1])
            {
                gettingCooler = false;
            }
        }

        if (gettingWarmer &&!gettingCooler)
        {
            Console.WriteLine("\nGetting Coolder.");
        }
        else if (!gettingWarmer && gettingCooler)
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

        Console.WriteLine($"\nAverage temperature: {average}");
    }
}