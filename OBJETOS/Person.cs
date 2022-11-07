using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Paco = new Person();
            Person Lucia = new Person("Lucia", 21, 'M');
            Person Lucas = new Person("Lucas", 35, 'H', 78, 1.85f);

            Console.WriteLine(Paco.Write());

            Console.WriteLine("El imc de " + Paco.GetName() + "es " + Paco.CalculateIMC());

            Lucia.SetWeight(200);
            Lucia.SetHeight(1.20f);

        }
    }

    class Person
    {

        string name;
        int age;
        string dni;
        char gender;
        float height;
        float weight;


        public Person()
        {
            this.dni = GenerateDNI();
            age = 0;
            gender = 'M';
            height = 0;
            weight = 0;
            name = "";

        }
        public void Birthday()
        {
            age = age + 1;
        }

        public Person(string name, int age, char gender)
        {
            this.dni = GenerateDNI();
            this.name = name;
            this.age = age;
            this.gender = gender;
            height = 0;
            weight = 0;

        }

        public Person(string name, int age,  char gender, float height, float weight)
        {

            this.name = name;
            this.age = age;
            this.dni = GenerateDNI();
            this.gender = gender;
            this.height = height;
            this.weight = weight;
        }

        public int CalculateIMC()
        {
            double imc = weight / Math.Pow(height, 2);
            if (imc < 20)
            {
                return -1;
            }
            else if (imc >= 20 && imc <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public bool BeAdult()
        {

            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckGender()
        {
            if (gender == 'M')
            {

                return true;
            }
            else
            {
                return false;

            }

        }

        public string Write()
        {
            
           

            return name + " de " + age + "con dni " + dni + "y peso" + weight;
        }

        public void SetName(string name)
        {
            this.name = name;

        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;

        }

        public int GetAge()
        {
            return age;
        }
        public string GenerateDNI()
        {
            Random rand = new Random();
            int numberDNI = rand.Next(0, 100000000);
            char leter = 'A';
            switch( numberDNI % 23)
            {
                case 0: leter = 'T'; break;
                case 1: leter = 'E'; break;
                case 2: leter = 'O'; break;
                case 3: leter = 'P'; break;
                case 4: leter = 'Q'; break;
                case 5: leter = 'W'; break;
                case 6: leter = 'A'; break;
                case 7: leter = 'S'; break;
                case 8: leter = 'D'; break;
                case 9: leter = 'F'; break;
                case 10: leter = 'G'; break;
                case 11: leter = 'H'; break;
                case 12: leter = 'J'; break;
                case 13: leter = 'K'; break;
                case 14: leter = 'L'; break;
                case 15: leter = 'L'; break;
                case 16: leter = 'L'; break;
                case 17: leter = 'L'; break;
                case 18: leter = 'L'; break;
                case 19: leter = 'L'; break;
                case 20: leter = 'L'; break;
                case 21: leter = 'L'; break;
                case 22: leter = 'L'; break;
                case 23: leter = 'L'; break;
                    
            }
            return numberDNI.ToString() + leter.ToString();


        }
        public void SetGender(char gender)
        {
            this.gender = gender;

        }

        public char GetGender()
        {
            return gender;
        }
        public void SetHeight(float height)
        {
            this.height = height;

        }

        public float GetHeight()
        {
            return height;
        }

        public void SetWeight(float weight)
        {
            this.weight = weight;

        }

        public float GetWeight()
        {
            return weight;
        }









    }
}
