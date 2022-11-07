using System;
using System.Runtime.ConstrainedExecution;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter C1 = new Counter();
            Counter C2 = new Counter(5);
            Counter C3 = new Counter(C2);

            C1.setcounter(2);
            C1.increase();
            C1.increase();
            Console.WriteLine(C1.getcounter());
            C1.decrease();
            Console.WriteLine(C1.getcounter());
            Console.WriteLine();
            C2.increase();
            C2.decrease();
            C2.decrease();
            Console.WriteLine(C2.getcounter());
            Console.WriteLine();
            Console.WriteLine(C3.getcounter());
        }
    }

    class Counter
    {
        int counter;
        public Counter()
        {
            counter = 0;
        }
        public Counter(int counter)
        {
            this.counter = counter;
        }
        public Counter(Counter C3)
        {
            this.counter = C3.counter;
        }
        public int getcounter()
        {
            return counter;
        }
        public void setcounter(int counter)
        {
            this.counter = counter;
        }
        public void increase()
        {
            counter = counter + 1;
        }
        public void decrease()
        {
            counter = counter - 1;
        }
    }
}
