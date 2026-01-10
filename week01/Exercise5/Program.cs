using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    
        static void DisplayMessage()
            {
                Console.WriteLine("Welcome to the program!");

            }

        static string PromptUserName()
                {
                    Console.Write("Please enter your name: ");
                    return Console.ReadLine();
                    
                }


        static int PromptUserNumber()
                {
                    
                    Console.Write("Please enter your favourite number: ");
                    return int.Parse(Console.ReadLine());
                    
                }

        static int SquareNumber(int PromptUserNumber)

        {
            int squaredNumber = PromptUserNumber  * PromptUserNumber;
            return squaredNumber;
        }

        static void DisplayResult( string PromptUserName, int squaredNumber)
        {
            Console.WriteLine($"{PromptUserName}, the square of your number is {squaredNumber}");

        }



}