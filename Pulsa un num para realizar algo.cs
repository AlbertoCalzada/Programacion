using System;
internal class Program

{
    private static void Main(string[] args)
    {
        int operacion;
        int valor1;
        int valor2;
        int resultado;

        Console.WriteLine("Elige una opción: 1 para sumar, 2 para restar , 3 para multiplicar , 4 para dividir");
        string operaciontotxt=Console.ReadLine();
        operacion= int.Parse(operaciontotxt);

        if (operacion == 1)
        {
            Console.WriteLine("Dame el valor 1");

            string valor1totxt = Console.ReadLine();
            valor1= int.Parse(valor1totxt);


            Console.WriteLine("Dame el valor 2");

            string valor2totxt = Console.ReadLine();
            valor2 = int.Parse(valor2totxt);

            resultado = valor1 + valor2;

            Console.WriteLine("El resultado es " + resultado);


        }

        if (operacion == 2)
        {
            Console.WriteLine("Dame el valor 1");

            string valor1totxt = Console.ReadLine();
            valor1 = int.Parse(valor1totxt);


            Console.WriteLine("Dame el valor 2");

            string valor2totxt = Console.ReadLine();
            valor2 = int.Parse(valor2totxt);

            resultado = valor1 - valor2;

            Console.WriteLine("El resultado es " + resultado);

        }
        if (operacion == 3)
        {
            Console.WriteLine("Dame el valor 1");

            string valor1totxt = Console.ReadLine();
            valor1 = int.Parse(valor1totxt);


            Console.WriteLine("Dame el valor 2");

            string valor2totxt = Console.ReadLine();
            valor2 = int.Parse(valor2totxt);

            resultado = valor1 * valor2;

            Console.WriteLine("El resultado es " + resultado);

        }
        if (operacion == 4)
        {
            Console.WriteLine("Dame el valor 1");

            string valor1totxt = Console.ReadLine();
            valor1 = int.Parse(valor1totxt);


            Console.WriteLine("Dame el valor 2");

            string valor2totxt = Console.ReadLine();
            valor2 = int.Parse(valor2totxt);

            resultado = valor1 / valor2;

            Console.WriteLine("El resultado es " + resultado);

        }

        if (operacion > 4)
        {

            Console.WriteLine("Lo sentimos, la opción que elegistes no existe");

        }

        if (operacion < 1)
        {

            Console.WriteLine("Lo sentimos, la opción que elegistes no existe");

        }










    }
}
