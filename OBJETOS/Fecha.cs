using System;

namespace Fecha
{
     class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Date d2 = new Date(17,10,1960);

            d2.setDay(21);
            d2.setMonth(11);
            d2.setYear(2020);
            Console.WriteLine(d2.Tostring() +"\n"+ d2.checkDate());
            d2.increaseDate();
            Console.WriteLine(d2.Tostring());
        }
    }

    class Date
    {
        int day;
        int month;
        int year;
        public Date()
        {
            day = 0;
            month = 0;
            year= 0;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {
            return month;
        }
        public int getYear()
        {
            return year;
        }
        
        public void setDay(int day)
        {
            this.day = day;
        }
        public void setMonth(int month)
        {
            this.month = month;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public string Tostring()
        {
            return "es el dia " + day + " del mes " + month + " del año " + year;
        }

        public bool checkDate()
        {
            if(day>0 && day<31 &&month>1 && month<=12 && year>0 && year <= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void increaseDate()
        {
            day = day + 1;

        }

        
    }
}
