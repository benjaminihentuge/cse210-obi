using System;

class Program
{
    static void Main(string[] args)
    {
        Journal jot = new Journal();
        PromptGenerator generator = new PromptGenerator();

        int action = 0;

        do
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");

            action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                jot.AddEntry(generator);
            }
            else if (action == 2)
            {
                jot.DisplayAll();
            }
            else if (action == 3)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                jot.LoadFromFile(filename);
                
            }
            else if (action == 4)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                jot.SaveToFile(filename);
            }
            else if (action == 5)
            {
                Console.WriteLine("Goodbye!");
            }

        } while (action != 5);
    }
}
