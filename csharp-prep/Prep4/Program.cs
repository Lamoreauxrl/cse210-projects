using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        int num = -1;
        List<int> userinput = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            if (num != 0)
            {
                userinput.Add(num);
            }            
        }while (num != 0);

        int total = 0;
        int large = 0;
        
        foreach (int n in userinput)
        {
            total += n;

            if (n > large)
            {
                large = n;
            }
        }

        Console.WriteLine($"The sum is: {total}");

        int average = total / userinput.Count;

        Console.WriteLine($"The average is: {average}");
        
        Console.WriteLine($"The largest number is: {large}");

    }
}