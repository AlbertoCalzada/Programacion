using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adn
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Person[] persons = new Person[5];
            persons[0] = new Person("John", "Brown");
            persons[1] = new Person("Matheu", "Gonzalez");
            persons[2] = new Person("Jordan", "Martín");
            persons[3] = new Person("David", "Salazar");
            persons[4] = new Person("Roberto", "Iglesias");
            string AdnAComparar = "";

            for (int i = 0; i < 20; i += 1)
            {
                AdnAComparar += Adn(rnd.Next(0, 4));
            }

            for (int i = 0; i < persons.Length; i += 1)
            {
                string newAdn = "";
                for (int j = 0; j < 20; j += 1)
                {
                    newAdn += Adn(rnd.Next(0, 4));
                }
                persons[i].SetAdn(newAdn);
            }
            Console.WriteLine(AdnAComparar);
            Console.WriteLine(persons[0].GetAdn());
            Console.WriteLine(persons[1].GetAdn());
            Console.WriteLine(persons[2].GetAdn());
            Console.WriteLine(persons[3].GetAdn());
            Console.WriteLine(persons[4].GetAdn());

            int[] counters = new int[persons.Length];

            for (int i = 0; i < persons.Length; i += 1)
            {
                for (int j = 0; j < 20; j += 1)
                {
                    if (persons[i].GetAdn()[j] == AdnAComparar[j])
                    {
                        counters[i] += 1;
                    }
                }
            }
            Console.WriteLine(counters[0]);
            Console.WriteLine(counters[1]);
            Console.WriteLine(counters[2]);
            Console.WriteLine(counters[3]);
            Console.WriteLine(counters[4]);

            int max = 0;
            int position = 0;
            for (int i = 0; i < persons.Length; i += 1)
            {
                if (max < counters[i])
                {
                    max = counters[i];
                    position = i;
                }
            }

            Console.WriteLine("El maximo es: " + max + " en la posición " + (position + 1));
            Console.WriteLine("El sospechoso es: " + persons[position].GetName() + " " + persons[position].GetSurName());

            Console.ReadLine();
        }

        static string Adn(int numRandom)
        {
            switch (numRandom)
            {
                case 0:
                    return "a";
                case 1:
                    return "g";
                case 2:
                    return "c";
                case 3:
                    return "t";
                default:
                    return "";
            }
        }
    }
}
