using System;

namespace Libro
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1= new Book();
            Book b2 = new Book("2132134213", "Alberto Calzada", 320);

        }
    }
    
    class Book
    {
        string isbn;
        string author;
        int pags;
        //puta vida

        public Book()
        {
            isbn = "";
            author = "";
            pags = 0;
        }
        public Book(string isbn, string author, int pags)
        {
            this.isbn = isbn;
            this.author = author;
            this.pags = pags;
        }

        public void Loan() //puta vida
        {

        }
        public void Devolution()
        {

        }
        public string toString()
        {
            return "";
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
    }
}
