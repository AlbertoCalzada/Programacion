using System;

namespace Rational
{



    class Rational
    {

        int numerator;
        int denominator;


        public Rational()
        {
            denominator = 0;
            numerator = 1;
        }

        public Rational(int newnumerator, int newdenominator)
        {
            numerator = newnumerator;
            denominator = newdenominator;


        }


        public Rational Add(Rational r2)
        {
            Rational result;
            int numR1 = numerator * r2.denominator;
            

            int numR2 = r2.numerator * denominator;
            int den = r2.denominator * denominator;


            result = new Rational(numR1 + numR2, den);
            return result;

        }
        public Rational Subtract(Rational r2)
        {
            Rational result;
            int numR1 = numerator * r2.denominator;


            int numR2 = r2.numerator * denominator;
            int den = r2.denominator * denominator;


            result = new Rational(numR1 - numR2, den);
            return result;

        }

       
        public Rational Multiplication(Rational r2)
        {
            int newnum = numerator * r2.numerator;
            int newden = denominator * r2.denominator;
            Rational result = new Rational(newnum, newden);
            return result;
        }
        public Rational Divide(Rational r2)
        {
            int newnum = numerator * r2.denominator;
            int newden = denominator * r2.numerator;
            Rational result = new Rational(newnum, newden);
            return result;

        }
        public bool Compare(Rational r2)
        {
            float num1F = (float)numerator;
            float den1F = (float)denominator;
            float num2F = (float)r2.numerator;
            float den2F = (float)r2.denominator;
            
            float decimal1 = num1F / den1F;
            float decimal2 = num2F / den2F;
            bool result = decimal1 == decimal2;
            return result;
        }

        public string Write() //ToString
        {
            string result= numerator + "/" + denominator;
            return result;
        }
        public void Print() 
        {
            Console.WriteLine(numerator + "/" + denominator); 
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rational r0;
            r0 = new Rational();
            Rational r1;
            r1 = new Rational(1,2);
            Rational r2;
            r2 = new Rational(2, 3);
            Rational r3 = new Rational(2, 4);

            Rational rMult;
            Rational rDiv;
            Rational rAdd;
            Rational rSubtract;

            rMult = r1.Multiplication(r2);
            rAdd = r1.Add(r2);
            rSubtract = r1.Subtract(r2);
            bool b1=r1.Compare(r2); //FALSE
            bool b2=r1.Compare(r3); //TRUE
            rDiv=r1.Divide(r2);
            
            string s = r1.Write();
            r1.Print();

            Console.WriteLine("el resultado de la suma es " + rAdd.Write());
            Console.WriteLine("el resultado de la RESTA es " + rSubtract.Write());
            Console.WriteLine("el resultado de la multiplicacion es " + rMult.Write());
            Console.WriteLine("el resultado de la DIVISON es " + rDiv.Write());
            Console.WriteLine(r1.Write()+ "==" + r2.Write() + "=" + b1);
            Console.WriteLine(r1.Write() + "==" + r3.Write() + "=" + b2);
            Console.WriteLine("llamando a to string" +s);

            Console.WriteLine("Fin");
        }
    }
}
