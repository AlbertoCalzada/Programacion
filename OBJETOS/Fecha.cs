using System;

namespace Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Date d2 = new Date(17, 10, 1960);

            d2.setDay(21);
            d2.setMonth(11);
            d2.setYear(2020);
            Console.WriteLine(d2.toString() + "\n" + d2.checkDate());
            d2.nextDay();
            Console.WriteLine(d2.toString());
        }
    }

    class Date
    {
        int day;
        int month;
        int year;
        public Date()
        {
            DateTime today = DateTime.Today; //esto es una genialidad , la programacion is very easy
            day = today.Day;
            month = today.Month;
            year = today.Year;
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
        public string toString()
        {
            return "es el dia " + day + " del mes " + month + " del año " + year;
        }

        public bool checkDate()
        {
            

            if(month<=0 && month > 12)
            {
                return false;
            }
            if(day<0 && day > 31)
            {
                return false;
            }
            
            switch(month)
            {
                //meses de 30 dias
                case 4: if (day == 31) return false; break;
                case 6: if (day == 31) return false; break;
                case 9: if (day == 31) return false; break;
                case 11: if (day == 31) return false; break;
                //meses de 31
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10:
                case 12:
                    if (day == 31) return true; break;
                
                case 2: 
                    if(IsLeap()==true)
                    {
                        if (day>29) //es bisiesto
                        {
                            return false;
                        }
                        else
                        {
                            if (day > 28) //no lo es
                            {
                                return false;
                            }

                        }
                    }
                    break;

            }
            return true;
        }

        public bool IsLeap() //bisiesto
        {

            return (year % 400 == 0) || (year % 4==0 && year % 100 != 0);
        }

        public void nextDay()
        {
            day = day + 1;
            if(month==11 || month == 4 || month == 6 || month == 9) //30 dias
            {
                if (day >= 31)
                {
                    day = 1;
                    month = month + 1;
                }

            } else s
            if (month == 2)
            {
                if (day > 29) //es bisiesto
                {
                    day = day - 29;
                    month = month + 1;
                }
                else
                {
                    if (day > 28) //no lo es
                    {
                        day = day - 28;
                        month = month + 1;
                    }

                }
            }
            if (month > 12)
            {

                month = month - 12;
                year = year + 1;
            }

        }


    }
}
