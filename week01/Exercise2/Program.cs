using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percetage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        
        string letter = "";
        string gradeSign = "";



            if (gradePercentage < 0 || gradePercentage > 100)
            { 
                if (gradePercentage > 100)
                {
                    string above = gradePercentage.ToString(); 
                }              
                Console.WriteLine($"Please input a valid score. your score {gradePercentage}, is above the valid score");
            }


            else if (gradePercentage >= 90 )

            {
                
                int ff = gradePercentage % 10;
                if (ff >=7  )
                {
                    gradeSign = "";
                }
                else if (ff <= 3)
                {
                    gradeSign = "-";
                }
                letter = "A";
            }
            
            

            else if (gradePercentage >= 80)
            
            {
                int ff = gradePercentage % 10;
                if (ff >=7  )
                {
                    gradeSign = "+";
                }
                else if (ff <= 3)
                {
                    gradeSign = "-";
                }
                letter = "B";
            }


            else if (gradePercentage >= 70)

            {
                int ff = gradePercentage % 10;
                if (ff >=7  )
                {
                    gradeSign = "+";
                }
                else if (ff <= 3)
                {
                    gradeSign = "-";
                }
                letter = "C";
            }
            else if (gradePercentage >= 60)

            {
                int ff = gradePercentage % 10;
                if (ff >=7  )
                {
                    gradeSign = "+";
                }
                else if (ff <= 3)
                {
                    gradeSign = "-";
                }
                letter = "D";
            }

            else if(gradePercentage  < 60 || gradePercentage !<0 )

            {
                letter = "F";
            }

        
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Congratulations! you passed Your Grade Score is {letter}{gradeSign}");
        }
        else if (letter == "D" || letter == "F")
        {
            Console.WriteLine($"Unfortunately, you did not pass. Your Grade Score is {letter}{gradeSign}");
        }

    }
}


