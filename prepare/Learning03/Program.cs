using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(3);
        Fraction fraction2 = new Fraction(8, 11);

        Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}