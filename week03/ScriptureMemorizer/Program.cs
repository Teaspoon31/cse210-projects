using System;
using System.Collections.Generic;

// Creativity Upgrade: Added ability to load a random scripture from a list.
// This helps users practice multiple scriptures instead of only one.

class Program
{
    static void Main(string[] args)
    {
        // Scripture library (CREATIVITY FEATURE)
        var scriptures = new List<(Reference, string)>
        {
            (new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding."),

            (new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")
        };

        Random rand = new Random();
        var chosen = scriptures[rand.Next(scriptures.Count)];

        Scripture scripture = new Scripture(chosen.Item1, chosen.Item2);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
