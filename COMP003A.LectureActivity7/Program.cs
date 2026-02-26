// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        
        
        List<string> names = new List<string>();
        
        names.Add("Brianna");
        names.Add("Daniela");
        names.Add("Ashley");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }



        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }
        
        
        
        Console.WriteLine("Enter a number (1-3): ");
        string userInput = Console.ReadLine();
        
        if (int.TryParse(userInput, out int number))
        {


            if (number >= 1 && number <= 3)
            {
                Console.WriteLine("Number Successfully Entered!! ");
            }
            else
            {
                Console.WriteLine("Number Not Valid. ");
            }
        }
        else
        {
            Console.WriteLine("Not A Number. ");
        }


        try
        {
            int userInputInt = int.Parse(userInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer. ");
        }
        
        /*
         Why is input validation preferred over try-catch when possible?
            Input validation is preferred over try-catch when possible because try-catch usually runs after the error happened and input validation checks for errors before the errors are executed.
         
        Why is try-catch still necessary in some cases?
            try-catch is still necessary in some cases because it can prevent errors from crashing the program 
          
        How did debugging help you understand loop behavior?
            Debugging helped me understand loop behavior because it helped me see and understand each step after it's executed
        
        */
    }
}
