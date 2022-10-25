class Person
    {
        string name;
        int age;

        public Person(string newName, int newAge)
        {
            name = newName;
            age = newAge;
        }

        public Person(string newName)
        {
            name = newName;
            age = 0;
        }

        public Person()
        {
            name = "";
            age = 0;
        }

        public void PrintName()
        {
            Console.WriteLine("El nombre de esta persona es: " + name);
        }

        public void Birthday()
        {
            age = age + 1;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        public int GetAge()
        {
            return age;
        }
    } 
class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Probando");

            Person Paco;
            Person Lucia;
            Person Juaquin;

            Paco = new Person("Paco",5);
            Lucia = new Person("Lucía");
            Juaquin = new Person();

            Paco.SetAge(5);
            Paco.SetName("Paco");
            //Console.WriteLine("La edad de "+ Paco.GetName() +" es: " + Paco.GetAge());
            Paco.Birthday();
            //Console.WriteLine("La edad de " + Paco.GetName() + " es: " + Paco.GetAge());

            Lucia.SetName("Lucía");
            Lucia.SetAge(16);
            //Console.WriteLine("La edad de "+ Lucia.GetName() +" es: " + Lucia.GetAge());
            Lucia = Paco;
            //Console.WriteLine("-->La edad de " + Lucia.GetName() + " es: " + Lucia.GetAge());

            Juaquin.SetName("Juaquín");
            Juaquin.SetAge(50);
            //Console.WriteLine("La edad de " + Juaquin.GetName() + " es: " + Juaquin.GetAge());
            Juaquin.SetAge(Paco.GetAge());
            //Console.WriteLine("La edad de " + Juaquin.GetName() + " es: " + Juaquin.GetAge());

            Paco.Birthday();
            Console.WriteLine("Paco: La edad de " + Paco.GetName() + " es: " + Paco.GetAge());
            Console.WriteLine("Lucía: La edad de " + Lucia.GetName() + " es: " + Lucia.GetAge());
            Console.WriteLine("Juaquín: La edad de " + Juaquin.GetName() + " es: " + Juaquin.GetAge());


            Console.WriteLine("Programa terminado. Pulse enter para finalizar");
            Console.ReadLine();
        }
}
