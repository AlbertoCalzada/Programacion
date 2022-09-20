using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int kcar;
        
        Console.WriteLine("Introduzca los kilometros del coche");
        string kcartotxt;
        kcartotxt = Console.ReadLine();
        int moneytopay;
        moneytopay = 100;
        int money300to1000;
        kcar = int.Parse(kcartotxt);
        money300to1000 = moneytopay + ((kcar - 300) * 10);
        moneyover1000= moneytopay + ((kcar - 300) * 10)  


        

        if (kcar<300)
        {
            Console.WriteLine(" Me tienes que pagar " + moneytopay + " euros "); 


        }
        if (kcar > 300 &&  kcar <= 1000) {

            Console.WriteLine(" Me tienes que pagar " + money300to1000 + " euros ");


        }
    if (kcar>1000) {
        
        Console.WriteLine(" Me tienes que pagar " + money300to1000 + " euros ");
    }
        
    }
}
