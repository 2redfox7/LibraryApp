using Library.IF;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Data.Sql
{
    public class BookSqlData : IDataBook<IBook>
    {
        public void Add(IBook item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                var book = new BookEntity(item);
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public IEnumerable<IBook> ReadAll()
        {
            using (LibraryContext db = new LibraryContext())
            {
                return db.Books.ToList();
            }
        }
        public IEnumerable<IBook> FindGenre(Genre genre)
        {
            using (LibraryContext db = new LibraryContext())
            {
                List<BookEntity> _booksOfGenre = new List<BookEntity>();
                foreach (BookEntity book in db.Books.ToList())
                {
                    if (book.Genre == genre)
                    {
                        _booksOfGenre.Add(book);
                    }
                }
                return _booksOfGenre;
            }
        }
        public IEnumerable<IBook> FindAuthor(string author)
        {
            using (LibraryContext db = new LibraryContext())
            {
                List<BookEntity> _booksByAuthor = new List<BookEntity>();
                foreach (BookEntity book in db.Books.ToList())
                {
                    if (book.Author.ToLower().IndexOf(author.ToLower()) > -1)
                    {
                        _booksByAuthor.Add(book);
                    }
                }
                return _booksByAuthor;
            }
        }
        public void Remove(IBook item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                var book = db.Books.SingleOrDefault(
                    x => x.Author.Equals(item.Author) &&
                    x.Name.Equals(item.Name));
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        public void Take(IBook item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                db.Books.First(x => x.Name == item.Name && x.Author == item.Author).isTaken = true;
                db.SaveChanges();
            }
        }
        public void Return(ICheck item)
        {
            using (LibraryContext db = new LibraryContext())
            {
      
                db.Books.First(x => x.Name == item.BookName && x.Author == item.BookAuthor).isTaken = false;
                db.SaveChanges();
            }
        }
        public IBook FindBook(string name, string author)
        {
            using (LibraryContext db = new LibraryContext())
            {
                IBook book = db.Books.FirstOrDefault(x => x.Name == name && x.Author == author);
                return book;
            }
        }
        public void AddReview((int, string, string) review, string name, string author)
        {
            using (LibraryContext db = new LibraryContext())
            {
                List<(int, string, string)> list = JsonConvert.DeserializeObject<List<(int, string, string)>>(db.Books.First(x => x.Name == name && x.Author == author).ReviewsJson);
                if (list == null)
                {
                    list = new List<(int, string, string)>();
                } 
                list.Add(review);
                db.Books.First(x => x.Name == name && x.Author == author).ReviewsJson = JsonConvert.SerializeObject(list);
                db.SaveChanges();
            }
        }
    }
}
