using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1 = new Fraction();          // default 1/1
        Fraction f2 = new Fraction(6);         // 6/1
        Fraction f3 = new Fraction(6, 7);      // 6/7

        Console.WriteLine(f1);
        Console.WriteLine(f2);
        Console.WriteLine(f3);

        Console.WriteLine($"fraction 1 is: {f1} (top = {f1.GetTop()}, bottom = {f1.GetBottom()})");
        Console.WriteLine($"fraction 2 is: {f2} (top = {f2.GetTop()}, bottom = {f2.GetBottom()})");
        Console.WriteLine($"fraction 3 is: {f3} (top = {f3.GetTop()}, bottom = {f3.GetBottom()})");


        //using setters to change value:
        f1.SetTop(7);
        f1.SetBottom(9);

        f2.SetTop(4);
        f2.SetBottom(15);

        f3.SetTop(33);
        f3.SetBottom(55);

        //checking again new values: 
        Console.WriteLine($"fraction 1 is: {f1} (top = {f1.GetTop()}, bottom = {f1.GetBottom()})");
        Console.WriteLine($"fraction 2 is: {f2} (top = {f2.GetTop()}, bottom = {f2.GetBottom()})");
        Console.WriteLine($"fraction 3 is: {f3} (top = {f3.GetTop()}, bottom = {f3.GetBottom()})");


        //now using the last methos GetFractionString and GetFractionValue
        Console.WriteLine($"Fraction using GetFractionString for fraction 1: {f1.GetFractionString()}");
        Console.WriteLine($"Fraction using GetFractionString for fraction 2: {f2.GetFractionString()}");
        Console.WriteLine($"Fraction using GetFractionString for fraction 3: {f3.GetFractionString()}");
        Console.WriteLine($"Fraction using GetFractionValue for fraction 1: {f1.GetFractionValue()}");
        Console.WriteLine($"Fraction using GetFractionValue for fraction 2: {f2.GetFractionValue()}");
        Console.WriteLine($"Fraction using GetFractionValue for fraction 3: {f3.GetFractionValue()}");


    }
}