using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int h;

        string htotxt;
        Console.WriteLine("Introduzca la hora en formato (24)");
        htotxt = Console.ReadLine();

        h = int.Parse(htotxt);

        if (h>=12)
        {

            Console.WriteLine((h - 12)+" PM "); 
        } else
        {
            Console.WriteLine(h + " AM ");


        }
    }
}
