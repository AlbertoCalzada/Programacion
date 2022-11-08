using System;
using System.Runtime.ConstrainedExecution;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Counter c2 = new Counter(5);
            Counter c3 = new Counter(c2);

            c1.setcounter(2);
            c1.increase();
            c1.increase();
            Console.WriteLine(c1.getcounter());
            c1.decrease();
            Console.WriteLine(c1.getcounter());
            Console.WriteLine();
            c2.increase();
            c2.decrease();
            c2.decrease();
            Console.WriteLine(c2.getcounter());
            Console.WriteLine();
            Console.WriteLine(c3.getcounter());

            

        }
    }

    class Counter
    {
        int counter;
        int add;

        int repetitions;
        public Counter()
        {
            counter = 0;
            add = 1;
            repetitions = 1;
        }
        public Counter(int counter, int add, int repetitions)
        {
            this.counter = counter;
            this.add = add;
            this.repetitions = repetitions;
        }

        public Counter(int counter, int add)
        {
            this.counter = counter;
            this.add = add;
            repetitions = 1;
        }
        public Counter(int add)
        {
            counter = 0;
            this.add = add;
            repetitions = 1;
        }
        public Counter(Counter copy) //constructor copia
        {
            this.counter = copy.counter;
            this.add = copy.add;
            this.repetitions = copy.repetitions;
        }
        public int getcounter()
        {
            return counter;
        }
        public void setcounter(int counter)
        {
            this.counter = counter;
        }

        public int getadd()
        {
            return add;
        }

        public int getrepetitions()
        {
            return repetitions;
        }
        public void setadd(int add)
        {
            this.add = add;
        }

        public void setrepetitions(int repetitions)
        {
            this.repetitions = repetitions;
        }


        public int increase()
        {
            counter = counter + add;
            return counter;
        }
        public void Run()
        {
            for (int i = 0; i < repetitions; i = i + 1)
            {
                increase();
            }
        }
        public void Run(int repetitions)
        {
            for (int i = 0; i < repetitions; i = i + 1)
            {
                increase();
            }
        }
        public int increase(int amount)
        {
            counter = counter + amount;
            return counter;
        }
        public int decrease()
        {
            counter = counter - add;
            return counter;
        }
        public int decrease(int amount)
        {
            counter = counter - amount;
            return counter;
        }
        public void Runbackwards()
        {
            for (int i = 0; i < repetitions; i = i + 1)
            {
                decrease();
            }
        }
        public void Runbackwards(int repetitions)
        {
            for (int i = 0; i < repetitions; i = i + 1)
            {
                decrease();
            }
        }

        public string tostring()
        {

            return "contador" + counter + " + " + add + "/" + repetitions;

        }
    }
}

