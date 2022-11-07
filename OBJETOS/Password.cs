using System;

namespace Password
{
    
    
   class Program
        {
            static void Main(string[] args)
        {
            Password p1 = new Password();
            Password p2 = new Password();

            
            Console.WriteLine(" La contraseña " + p1.GetPassword()+ " es de la longitud " +p1.GetLength() + " es fuerte " + p1.IsStrong());
            Console.WriteLine(" La contraseña " + p2.GetPassword() + " es de la longitud " + p2.GetLength() + " es fuerte " + p2.IsStrong());

            p1.GeneratePassword();
            p2.GeneratePassword();

            Console.WriteLine(" La contraseña " + p1.GetPassword() + " es de la longitud " + p1.GetLength() + " es fuerte " + p1.IsStrong());
            Console.WriteLine(" La contraseña " + p2.GetPassword() + " es de la longitud " + p2.GetLength() + " es fuerte " + p2.IsStrong());


        }
    }
    
    
    class Password
    {

        int length;
        string password;

        public Password()
        {
            length = 8;
            GeneratePassword();

        }

        public Password(int length)
        {
            this.length = length;

        }

        public int GetLength()
        {

            return length;

        }

        public string GetPassword()
        {

            return password;
        }

        public void SetLength(int length)
        {

            this.length = length;
        }

        public void GeneratePassword() //generar contraseña con longitud correspondiente
        {
            Random rand = new Random();
            password = "";

            for (int counter=1; counter <= length; counter = counter + 1)
            {
                int number = rand.Next(42, 123);
                char c = Convert.ToChar(number);
                password = password + c;

            }
                 
        }

        public bool IsStrong()
        {
            //fuerte +2 mayus +1 minis +2 numeros
            int mayus = 0;
            int minus = 0;
            int numbers = 0;
            int special = 0;
            for (int position=0; position < length; position = position + 1)
            {

               if ( password[position] >='0' &&password[position]<= '9')
                {
                    numbers = numbers + 1;
                }
               else
                {
                    if(password[position]>= 'a' && password[position]< 'z')
                    {

                        minus = minus + 1;
                    }
                    else
                    {
                        if(password[position]>='A' && password[position]>= 'Z')
                        {
                            mayus = mayus + 1;
                        }
                        else
                        {
                           special= special + 1;
                        }
                    }
                }
            }

            bool result = (mayus > 2) && (minus > 1) && (numbers > 2);
            return result;
            
        }
        public bool IsStrong2(string password)
        {
            //fuerte +2 mayus +1 minis +2 numeros
            int mayus = 0;
            int minus = 0;
            int numbers = 0;
            int special = 0;
            for (int position = 0; position < length; position = position + 1)
            {

                if (password[position] >= '0' && password[position] <= '9')
                {
                    numbers = numbers + 1;
                }
                else
                {
                    if (password[position] >= 'a' && password[position] < 'z')
                    {

                        minus = minus + 1;
                    }
                    else
                    {
                        if (password[position] >= 'A' && password[position] >= 'Z')
                        {
                            mayus = mayus + 1;
                        }
                        else
                        {
                            special = special + 1;
                        }
                    }
                }
            }

            bool result = (mayus > 2) && (minus > 1) && (numbers > 2);
            return result;

        }
    }
}
