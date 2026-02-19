using System;

namespace EternalQuest
{
    class Program
    {
        static void Main()
        {
            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                manager.DisplayPlayerInfo();

                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Quit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": manager.CreateGoal(); break;
                    case "2": manager.ListGoalDetails(); break;
                    case "3": manager.RecordEvent(); break;
                    case "4": manager.SaveGoals(); break;
                    case "5": manager.LoadGoals(); break;
                    case "6": running = false; break;
                }
            }
        }
    }
}
