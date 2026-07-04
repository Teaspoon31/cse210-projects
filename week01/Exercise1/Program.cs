using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("     COURSE GRADE CALCULATOR");
        Console.WriteLine("=====================================");
        Console.ResetColor();

        // List to store all grades entered
        List<string> grades = new List<string>();

        string again;
        do
        {
            Console.Write("\nWhat is your grade percentage? ");
            int percent = int.Parse(Console.ReadLine());

            // Call function to get grade
            string finalGrade = GetLetterGrade(percent);

            // Store grade in list
            grades.Add(finalGrade);

            // Display result
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nYour grade is: {finalGrade}");
            Console.ResetColor();

            if (percent >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("🎉 Congratulations! You passed!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("💪 Better luck next time!");
            }
            Console.ResetColor();

            Console.Write("\nDo you want to enter another grade? (yes/no): ");
            again = Console.ReadLine().ToLower();

        } while (again == "yes");

        // Print all grades entered
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=====================================");
        Console.WriteLine("Grades entered this session:");
        Console.ResetColor();

        foreach (string g in grades)
        {
            Console.WriteLine($"- {g}");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("        PROGRAM COMPLETE");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    // Function to calculate letter grade with +/-
    static string GetLetterGrade(int percent)
    {
        string letter;
        string sign = "";

        if (percent >= 90) letter = "A";
        else if (percent >= 80) letter = "B";
        else if (percent >= 70) letter = "C";
        else if (percent >= 60) letter = "D";
        else letter = "F";

        int lastDigit = percent % 10;

        if (lastDigit >= 7) sign = "+";
        else if (lastDigit < 3) sign = "-";

        // Handle special cases
        if (letter == "A" && sign == "+") sign = "";
        if (letter == "F") sign = "";

        return $"{letter}{sign}";
    }
}
