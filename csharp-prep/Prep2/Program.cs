using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);
        string grade = "";
        string modifier = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent < 90 && percent >= 80)
        {
            grade = "B";
        }
        else if (percent < 80 && percent >= 70)
        {
            grade = "C";
        }
        else if (percent < 70 && percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("I am sorry, you did not pass.  I am sure you will do better next time you are in my class.");
        }
    }
}