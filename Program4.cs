using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene razmakom:");
        string unos = Console.ReadLine();
        string[] brojevi = unos.Split(' ');

        int x = int.Parse(brojevi[0]);
        double y = double.Parse(brojevi[1]);

        Console.WriteLine("Uneseni brojevi su:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
    }
}