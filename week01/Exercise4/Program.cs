using System;
using System.Collections.Generic; // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int inputNumber;
        do
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        } while (inputNumber != 0);

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Compute the average
        double average = (double)sum / numbers.Count;

        // Find the maximum
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
