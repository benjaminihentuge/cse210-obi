using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int numb =0;
        int sum =0;
        double ave =0;

        List<int> nums = new List<int>();


        do
        {
           Console.Write("Enter your numbers ");
            numb = int.Parse(Console.ReadLine());
            if (numb!=0)nums.Add(numb);   
        
        }while(numb != 0); 
        
            int large = nums[0];
            int small = nums[0];
            
        
            foreach (int num in nums)
            {
                
         
            Console.WriteLine(num);
            sum += num;
            ave = sum / (double)nums.Count; 




            if (large < num)
            {
                large = num;
            }
            
            else if (num > 0 && num < small  )

            {
                small = num;
            }
           

                

            }
        Console.WriteLine($"The sum total is {sum}");   
        Console.WriteLine($"The average is {ave}");     
        Console.WriteLine($"The largest is {large}"); 
        Console.WriteLine($"The Smallest Positive number is {small}"); 
    




        

    }
}