
class Program
    {
        static void Main(string[] args)
        {

            Person p1= new Person();
            Person p2= new Person("Juan", 23, 'M');
            Person p3= new Person("Rocio", 17, "53905661", 'F', 1.67f, 120);
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
            age = 0;
            gender = 'M';
            height = 1.70f;
            weight = 80.5f;

            
        }

        public Person(string name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            height = 1.70f;
            weight = 80.5f;

        }

        public Person(string name, int age, string dni, char gender, float height, float weight)
        {

            this.name=name;
            this.age=age;
            this.dni = dni;
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
            } else if(imc>=20 && imc <= 25)
            {
                return 0;
            } else
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

            return "BLALBALBLLA";
        }

        public void SetName(string name)
        {
            this.name = name;

        }

        public void SetAge(int age)
        {
            this.age = age;

        }
        public void GenerateDNI(double dni)
        {

            
            double result = dni % 23;
            Console.WriteLine( "Comprueba la letra sabiendo que el resultado es " + result);


        }
        public void SetGender(char gender)
        {
            this.gender = gender;

        }
        public void SetHeight(float height)
        {
            this.height = height;

        }
        public void SetWeight(float weight)
        {
            this.weight = weight;

        }







        

    }
