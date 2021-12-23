using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHttpApplication.Models
{
    public class Book
    {
        public string writerName;
        public int YearOfPublication;
        public int numbersOfPages;
        public int id;
        static int counter = 0;
        public static List<Book> BooksList = new List<Book>();
        public Book(string writerName, int YearOfPublication, int numbersOfPages)
        {
            this.id = counter++;
            this.writerName = writerName;
            this.YearOfPublication = YearOfPublication;
            this.numbersOfPages = numbersOfPages;
        }
         public Book() { }
     
    }
}