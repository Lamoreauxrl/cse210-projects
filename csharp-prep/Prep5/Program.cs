using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int inputNumber = PromptUserNumber();

        int sqareNum = SquareNumber(inputNumber);

        DisplayResult(userName, sqareNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int num)
    {
        int squareNum = num * num;
        return squareNum;
    }

    static void DisplayResult (string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
    }
}