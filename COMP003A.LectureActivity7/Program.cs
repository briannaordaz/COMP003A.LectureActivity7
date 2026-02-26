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
        
        
        
    }
}
