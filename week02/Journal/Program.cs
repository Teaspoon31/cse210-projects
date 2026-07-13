using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity Upgrade: Added sorting by date and CSV save/load
        Journal journal = new Journal();
        Random random = new Random();

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string choice = "";
        while (choice != "7")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Display journal sorted by date");
            Console.WriteLine("4. Save the journal to a CSV file");
            Console.WriteLine("5. Load the journal from a CSV file");
            Console.WriteLine("6. Save the journal to a text file (basic)");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                journal.DisplayJournalSorted();
            }
            else if (choice == "4")
            {
                Console.Write("Enter CSV filename: ");
                string filename = Console.ReadLine();
                journal.SaveToCsv(filename);
            }
            else if (choice == "5")
            {
                Console.Write("Enter CSV filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromCsv(filename);
            }
            else if (choice == "6")
            {
                Console.Write("Enter text filename: ");
                string filename = Console.ReadLine();
                // fallback basic save (pipe-separated)
                journal.SaveToCsv(filename);
            }
        }
    }
}
