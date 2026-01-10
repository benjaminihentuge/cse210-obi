using System;

class Program
{
    static void Main(string[] args)
    {
        
        {
            string playAgain = "";

            do
            {
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 100);

                int count = 0;
                int userGuess;
                
                

                    do
                    {
                        Console.Write("What is your guess? ");
                        userGuess = int.Parse(Console.ReadLine());
                        count++;
                        
                        if (userGuess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }

                        else if(userGuess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }

                    
                    } while(userGuess != magicNumber);


                    
                    Console.WriteLine($"You Guessed it. It took you {count} trials");
                    Console.WriteLine("Do you want to play again?");
                    playAgain = Console.ReadLine();
            } while (playAgain == "yes");
            Console.WriteLine("Thanks for playing");        
       
        }
}
}





