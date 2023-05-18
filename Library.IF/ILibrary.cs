using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public interface ILibrary
    {
        string Address { get; set; }
        IEnumerable<IBook> GetAllBooks();

        IEnumerable<ICheck> GetChecks(IUser user);
        void TakeBook(ICheck check);
        IBook GetBook(string name, string author);
        IEnumerable<IBook> FindBooksAuthor(string author);
        IEnumerable<IBook> FindBooksGenre(Genre genre);
        void ReturnBook(ICheck check);
        void AddBook(IBook book);
        bool Login(IUser user);
        void Registration(IUser user);
        void AddReview((int, string, string) review, string name, string author);
        IUser GetUser(IUser user);
    }
}
