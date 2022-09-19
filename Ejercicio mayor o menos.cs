using System;
internal class Program
{
    private static void Main(string[] args)
    {
       
        int num1;
        int num2;

        string num1totxt;
        string num2totxt;

        num1totxt = Console.ReadLine();
        num2totxt = Console.ReadLine();

        num1 = int.Parse(num1totxt);
        num2= int.Parse(num2totxt);

        if (num1> num2)
        {
            Console.WriteLine(num1);
        } else
        {
            Console.WriteLine(num2);
        }

        
    }
}
