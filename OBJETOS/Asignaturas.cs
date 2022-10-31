using System;

namespace Asignatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Lengua= new Subject(1);
            Subject Historia = new Subject(2);
            Subject Química = new Subject(3);


            Student Lucia = new Student(Lengua, Historia, Química);
            Student Jorge = new Student(Lengua, Historia, Química);
            Student Sergio = new Student(Lengua, Historia, Química);

            Teacher Tch1 = new Teacher(5331231, "Rodrigo", "Historia");
            
            Tch1.PutMark(Lucia);
            Tch1.PutMark(Jorge);
            Tch1.PutMark(Sergio);

            
        }
    }

    class Subject
    {

        int identifier;
        float mark;


        public Subject(int identifier)
        {
            this.identifier = identifier;
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

        public Student(Subject S1, Subject S2, Subject S3)
        {
            this.S1 = S1;
            this.S2 = S2;
            this.S3 = S3;
            name = "Fernando";
            tuition = 5400;

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

        int nif;
        string name;
        string specialty;
        double average;

        public Teacher(int nif, string name, string specialty)
        {
            this.nif = nif;
            this.name = name;
            this.specialty = specialty;
        }

        public void PutMark(Student qualified)
        {
            Random r= new Random();
            Console.WriteLine("Has sacado un " +r.Next(0,11));
            Console.WriteLine("Has sacado un " + r.Next(0, 11));
            Console.WriteLine("Has sacado un " + r.Next(0, 11));

            
        }

        //public double CalculateAverage(Student S1)
        //{
        //    GetS1();
            
        //    return average;
          

        //}
    }

    





}
