using System;
internal class Program

{
    private static void Main(string[] args)
    {
        int kcar;
        
        Console.WriteLine("Introduzca los kilometros del coche");
        string kcartotxt;
        kcartotxt = Console.ReadLine();
        int moneytopay;
        moneytopay = 100;
        int money300to1000;
        kcar = 0;
        money300to1000 = moneytopay + kcar +10;

        kcar = int.Parse(kcartotxt);

        if (kcar<300)
        {
            Console.WriteLine(" Me tienes que pagar " + moneytopay + " euros "); 


        }
        if (kcar > 300  <=1000) {

            Console.WriteLine(" Me tienes que pagar " + money300to1000 + " euros ");


        }

        if (kcar>1000)
        {


        }
