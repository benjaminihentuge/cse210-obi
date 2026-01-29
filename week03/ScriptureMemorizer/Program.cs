using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("scripture.txt");

 
        string[] referenceParts = lines[0].Split("|");

        string book = referenceParts[0];
        int chapter = int.Parse(referenceParts[1]);
        int startVerse = int.Parse(referenceParts[2]);
        int endVerse = int.Parse(referenceParts[3]);

        Reference reference = new Reference(book, chapter, startVerse, endVerse);

       
        string scriptureText = lines[1];

        Scripture scripture = new Scripture(reference, scriptureText);




        RunMemorizer(scripture);
    }

    static void RunMemorizer(Scripture scripture)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}
