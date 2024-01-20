using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Unesite rečenicu:");
        string recenica = Console.ReadLine();

        string[] rijeci = recenica.Split(' ');

        if (rijeci.Length > 0)
        {
            string prvaRijec = rijeci[0];
            string zadnjaRijec = rijeci[rijeci.Length - 1];

            Console.WriteLine("Prva riječ: " + prvaRijec);
            Console.WriteLine("Zadnja riječ: " + zadnjaRijec);
        }
        else
        {
            Console.WriteLine("Niste unijeli rečenicu.");
        }
    }
}