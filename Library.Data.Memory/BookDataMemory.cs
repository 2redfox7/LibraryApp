using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.IF;

namespace Library.Data.Memory
{
    public class BookMemoryData : IDataBook<IBook>
    {
        private readonly List<IBook> _books;

        public BookMemoryData()
        {
            _books = new List<IBook>();
        }

        public void Add(IBook item)
        {
            _books.Add(item);
        }

        public IEnumerable<IBook> ReadAll()
        {
            return _books;
        }
        public IEnumerable<IBook> FindGenre(Genre genre)
        {
            List<IBook> _booksOfGenre = new List<IBook>();
            foreach (IBook book in _books)
            {
                if (book.Genre == genre)
                {
                    _booksOfGenre.Add(book);
                }
            }
            return _booksOfGenre;
        }
        public IEnumerable<IBook> FindAuthor(string author)
        {
            List<IBook> _booksByAuthor = new List<IBook>();
            foreach (IBook book in _books)
            {
                if (book.Author == author)
                {
                    _booksByAuthor.Add(book);
                }
            }
            return _booksByAuthor;
        }
        public void Remove(IBook item)
        {
            _books.Remove(item);
        }
        public void Take(IBook item)
        {
            _books.First(x => x.Name == item.Name && x.Author == item.Author).isTaken = true;
        }
        public void Return(ICheck item)
        {
            _books.First(x => x.Name == item.Book.Name && x.Author == item.Book.Author).isTaken = false;
        }
        public IBook FindBook(string name, string author)
        {
            return _books.FirstOrDefault(x => x.Name == name && x.Author == author);
        }
        public void AddReview((int, string, string) review, string name, string author)
        {
            _books.FirstOrDefault(x => x.Name == name && x.Author == author).Reviews.Add(review);
        }
    }
}
