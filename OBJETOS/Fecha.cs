
using System;

namespace Book
{
    using System;

    namespace Libro
    {
        class Program
        {
            static void Main(string[] args)
            {
                Book b1 = new Book("123");
                Book b2 = new Book("51341413");
                Date today = new Date();
                Date tomorrow = new Date();
                tomorrow.nextDay();

                Console.WriteLine(b1.toString());
                Console.WriteLine(b2.toString());

                b1.Loan();
                Console.WriteLine(b1.toString());
                b1.Return();
                Console.WriteLine(b1.toString());

            }
        }

        class Book
        {
            string isbn;
            string author;
            int pags;
            Date loandate;
            Date returndate;
           

            public Book()
            {
                isbn = "";
                author = "";
                pags = 1;
                loandate = null;
                returndate = null;
            }
            public Book(string isbn, string author, int pags, Date loandate, Date returndate)
            {
                this.isbn = isbn;
                this.author = author;
                this.pags = pags;
                this.loandate = loandate;
                this.returndate = returndate;
            }
            public Book(string isbn)
            {
                this.isbn = isbn;
                isbn = "";
                author = "";
                loandate = null;
                returndate = null;
                pags = 1;
            }
            public Book(string isbn, int pags)
            {
                this.isbn = isbn;
                isbn = "";
                author = "";
                loandate = null;
                returndate = null;
                this.pags = pags;
            }

            public bool Loan() 
            {
               
                if((loandate==null) || (loandate != null && returndate != null))
                {

                    loandate = new Date();
                    returndate = null;
                    return true;
                }else
                {
                    return false;
                }
                
            }
            public bool Loan(int year, int month, int day)
            {
                loandate = new Date(day, month, year);
                if (loandate.checkDate() != true)
                {
                    loandate = null;
                    return false;
                }
                return true;
            }
            public bool Return()
            {
                if(loandate!=null && returndate == null)
                {
                    returndate = new Date();
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool IsLoaned()
            {
                return loandate != null && returndate == null;
            }
            public bool IsAvailable()
            {
                return loandate == null || (loandate != null && returndate != null);
            }
            public bool Return(int year, int month, int day)
            {
                returndate = new Date(day, month, year);
                if (returndate.checkDate() != true)
                {
                    loandate = null;
                    return false;
                }
                return true;
            }
            public string toString()
            {
                if (loandate == null)
                {
                    return "el autor " + author + " con el isbn " + isbn + " con el numero de paginas " + pags + " .Nunca se ha prestado";

                }
                else
                {
                    if (returndate == null)
                    {
                        return "el autor " + author + " con el isbn " + isbn + " con el numero de paginas " + pags + " Se prestó en la fecha "
                            + loandate.toString() + " y no se ha devuelto";
                    }
                    else
                    {
                        return "el autor " + author + " con el isbn " + isbn + " con el numero de paginas " + pags + " Se prestó en la fecha "
                                                + loandate.toString() + " y se devolvio en la fecha " + returndate.toString();
                    }



                }
                
            }
            public string getIsbn()
            {
                return isbn;
            }

            public string getAuthor()
            {
                return author;
            }

            public int getPags()
            {
                return pags;
            }

            public Date getloanDate()
            {
                return loandate;
            }
            public Date getreturndate()
            {
                return returndate;
            }
            public void setloanDate(Date loandate)
            {
                this.loandate = loandate;
            }
            public void setreturnDate(Date returndate)
            {
                this.returndate = returndate;
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


                if (month <= 0 || month > 12)
                {
                    return false;
                }
                if (day < 0 || day > 31)
                {
                    return false;
                }

                switch (month)
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
                        if (IsLeap() == true)
                        {
                            if (day > 29) //es bisiesto
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

                return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }

            public void nextDay()
            {
                day = day + 1;
                if (month == 11 || month == 4 || month == 6 || month == 9) //30 dias
                {
                    if (day >= 31)
                    {
                        day = 1;
                        month = month + 1;
                    }

                }
                else 
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
}

