using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(3);
        Fraction fraction2 = new Fraction(8, 11);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}