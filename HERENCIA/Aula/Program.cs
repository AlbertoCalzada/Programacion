using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject programacion = new Subject();
            Subject entornos = new Subject();
            Subject bbdd = new Subject();
            Person oscar = new Teacher("Óscar", 30, "Masculino", programacion);
            Student[] students = new Student[10];
            ClassRoom classroom1 = new ClassRoom(001, programacion, 31);
            for (int i = 0; i < students.Length; i++)
            {

            }
            classroom1.GoClass(students);
        }
    }
    class Tuition
    {
        Subject subject;
        Student student;
        int calif;

        public Tuition(Subject subject, Student student)
        {
            this.student = student;
            this.subject = subject;
        }
    }

    class ClassRoom
    {
        int identifier;
        Subject subject;
        int size;
        //Personas
        public ClassRoom(int identifier, Subject s1, int size)
        {
            this.identifier = identifier;
            this.subject = s1;
            this.size = size;
        }

        public int GetIdentifier()
        {
            return identifier;
        }

        public void SetIdentifier(int value)
        {
            identifier = value;
        }

        public int GetSize()
        {
            return size;
        }

        public void SetSize(int value)
        {
            size = value;
        }

        public Subject GetSubject()
        {
            return subject;
        }

        public void SetSubject(Subject value)
        {
            subject = value;
        }

        public void GoClass(Person[] students)
        {

            students = new Student[30];
            Random random = new Random();
            double studentPr = 0.5;
            double teacherPr = 0.2;
            double randomNum = random.NextDouble();
            if (randomNum < teacherPr)
            {
                Console.WriteLine("El profesor no acude a clase");
            }
            else
            {
                Console.WriteLine("El profesor acude a clase");
            }
            for (int i = 0; i < students.Length; ++i)
            {
                randomNum = random.NextDouble();
                if (randomNum < studentPr)
                {
                    Console.WriteLine("El estudiante " + students[i].GetName() + " no acude a clase");
                }
                else
                {
                    Console.WriteLine("El estudiante " + students[i].GetName() + "  acude a clase");
                }
            }

            //if (n == 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //igual a 
            //return n==1
        }

        public void SeImparte()
        {

        }
    }
    class Subject
    {
        string name;

        public Subject()
        {

        }
    }
    class Person
    {
        string name;
        int age;
        string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public bool GoClass()
        {
            return true;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }
    // se puede recorrer el array pequeño para meterlo en uno mas grande si queremos aumentar el tamaño de este.
    //EN LA RELACION N:M SI TENEMOS ATRIBUTOS PODEMOS CREAR UNA NUEVA CLASE 
    class Student : Person
    {
        double calification;
        Tuition[] tuitions;
        public Student(string name, int age, string gender) : base(name, age, gender)
        {
            tuitions = new Tuition[5];
        }
    }
    class Teacher : Person
    {
        Subject subject;
        public Teacher(string name, int age, string gender, Subject subject) : base(name, age, gender)
        {
            this.subject = subject;
        }
        public Subject GetSubjectTeacher()
        {
            return subject;
        }

        public void SetSubjectTeacher(Subject value)
        {
            subject = value;
        }
    }
}
