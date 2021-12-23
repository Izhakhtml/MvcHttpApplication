using MvcHttpApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcHttpApplication.Controllers.api
{
    public class ValuesController : ApiController
    {
        Random Random = new Random();
        // GET: api/Values
        public IHttpActionResult Get()
        {
            CreateAllWriters();
            return Ok(Book.BooksList);
        }

        // GET: api/Values/5
        public IHttpActionResult Get(int id)
        {
            CreateAllWriters();
            return Ok(Book.BooksList.Find(item => item.id == id));
        }

        // POST: api/Values
        public IHttpActionResult Post([FromBody]Book value)
        {
            CreateAllWriters();
            Book.BooksList.Add(value);
            return Ok(Book.BooksList);
        }

        // PUT: api/Values/5
        public IHttpActionResult Put(int id, [FromBody]Book value)
        {
            CreateAllWriters();
            Book newBook = Book.BooksList.Find(item => item.id == id);
            Book.BooksList[Book.BooksList.IndexOf(newBook)].writerName = value.writerName;
            Book.BooksList[Book.BooksList.IndexOf(newBook)].YearOfPublication = value.YearOfPublication;
            Book.BooksList[Book.BooksList.IndexOf(newBook)].numbersOfPages = value.numbersOfPages;
            return Ok(Book.BooksList);
        }
        // DELETE: api/Values/5
        public IHttpActionResult Delete(int id)
        {
            CreateAllWriters();
            Book itemDelete = Book.BooksList.Find(item => item.id==id);
            Book.BooksList.Remove(itemDelete);
            return Ok(Book.BooksList);
        }
        void CreateAllWriters()
        {

            Book.BooksList.AddRange(new Book[]
            {
                new Book("emanual",1994,Random.Next(100,500)),
                new Book("ezra",1887,Random.Next(100,500)),
                new Book("omar",1945,Random.Next(100,500)),
                new Book("ido",1978,Random.Next(100,500)),
                new Book("avrham",1967,Random.Next(100,500)),
                new Book("aliav",1990,Random.Next(100,500)),
                new Book("aviv",1989,Random.Next(100,500)),
                new Book("rauvam",1974,Random.Next(100,500)),
            });
        }
    }
}
