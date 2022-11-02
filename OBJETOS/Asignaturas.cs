using System;

namespace Asignatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s11 = new Subject(1);
            Subject s12 = new Subject(2);
            Subject s13 = new Subject(3);
            Subject s21 = new Subject(1);
            Subject s22 = new Subject(2);
            Subject s23 = new Subject(3);
            Subject s31 = new Subject(1);
            Subject s32 = new Subject(2);
            Subject s33 = new Subject(3);


            Student st1 = new Student(s11, s12, s13, "Paco", 100);
            Student st2 = new Student(s21, s22, s23, "Lola", 200);
            Student st3 = new Student(s31, s32, s33, "Reme", 300);

            Teacher teach1 = new Teacher("11111111A", "Lucas", "Informatica");


            teach1.ScoreAsign(st1);
            teach1.ScoreAsign(st2);
            teach1.ScoreAsign(st3);

            double av1 = teach1.AverageScore(st1);
            double av2 = teach1.AverageScore(st2);
            double av3 = teach1.AverageScore(st3);

            double maxAv = Max(av1, av2, av3);
            string maxAvName;

            if (av1 == maxAv)
            {

                maxAvName = st1.GetName();
            } else
            {
                if (av2 == maxAv)
                {

                    maxAvName = st2.GetName();
                }
                else
                {
                    maxAvName=st3.GetName();
                }
            }


            Console.WriteLine("Media de " + st1.GetName() +" es " + teach1.AverageScore(st1));
            Console.WriteLine("Media de " + st2.GetName() + " es " + teach1.AverageScore(st2));
            Console.WriteLine("Media de " + st3.GetName() + " es " + teach1.AverageScore(st3));

            Console.WriteLine("La media mas alta des la de " +maxAvName);


        }

        static double Max(double d1, double d2, double d3)
        {

            if (d1 > d2)
            {
                if (d1 > d3) //d1 es mas grande
                {
                    return d1; //tmnb mas grnade d3
                }
                else
                {
                    return d3; //no es mas grande que d3
                }

            }
            else
            {

                if (d2 > d3)
                {
                    return d2;
                }
                else
                {
                    return d3;
                }
            }
        }

        static double Max(double d1, double d2)
        {

            if (d1 > d2)
            {
                return d1;
            }
            else
            {
                return d2;
            }
        }

        static double Maxv2(double d1, double d2, double d3)
        {

            double daux = Max(d1, d2);
            double daux2 = Max(daux, d3);
            return daux2;
        }
    }

    class Subject
    {

        int identifier;
        float mark;


        public Subject(int identifier)
        {
            this.identifier = identifier;
            mark = 0;
        }

        public int GetIdentifier()
        {
            return identifier;

        }

        public float GetMark()
        {

            return mark;
        }

        public void SetMark(float mark)
        {
            this.mark = mark;

        }
    }

    


    class Student
    {
        Subject S1;
        Subject S2;
        Subject S3;
        string name;
        int tuition;

        public Student(Subject S1, Subject S2, Subject S3, string name, int tuition)
        {
            this.S1 = S1;
            this.S2 = S2;
            this.S3 = S3;
            this.name = name;
            this.tuition = tuition;

        }

        public Subject GetS1()
        {
            return S1;
        }
        public Subject GetS2()
        {
            return S2;
        }
        public Subject GetS3()
        {
            return S3;
        }

        public string GetName()
        {
            return name;
        }

        public int GetTuition()
        {

            return tuition;
        }
        
    }

    class Teacher
    {

        string nif;
        string name;
        string specialty;
        

        public Teacher(string nif, string name, string specialty)
        {
            this.nif = nif;
            this.name = name;
            this.specialty = specialty;
        }

        public void ScoreAsign(Student student)
        {
            Random r1 = new Random();
            
            //Console.WriteLine("Has sacado un " + r.Next(0, 11));
            //Console.WriteLine("Has sacado un " + r.Next(0, 11));
            //Console.WriteLine("Has sacado un " + r.Next(0, 11));

            int random1 = r1.Next(0, 11);
            int random2 = r1.Next(0, 11);
            int random3 = r1.Next(0, 11);
            Subject S1= student.GetS1();
            S1.SetMark(random1);
            Subject S2 = student.GetS2();
            S2.SetMark(random2);
            Subject S3 = student.GetS3();
            S3.SetMark(random3);
        }

        public double AverageScore(Student student)
        {
            Subject S1 = student.GetS1();
            Subject S2 = student.GetS2();
            Subject S3 = student.GetS3();
            double cal1 = S1.GetMark();
            double cal2 = S2.GetMark();
            double cal3 = S3.GetMark();

            return (cal1 + cal2 + cal3) / 3;


        }
    }







}
