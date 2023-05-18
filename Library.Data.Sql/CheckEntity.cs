using Library.IF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Sql
{
    public class CheckEntity : ICheck
    {
        public int Id { get; set; }
        public string LibraryAddress { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string IdUser { get; set; }
        [NotMapped]
        public IBook Book { get; set; }
        [NotMapped]
        public ILibrary Library { get; set; }
        public int Time { get; set; }
        [NotMapped]
        public IUser User { get; set; }
        public DateTime DateTime { get; set; }

        public CheckEntity() { }

        public CheckEntity(ICheck item)
        {
            Id = 0;
            Library = item.Library;
            LibraryAddress = item.Library.Address;
            Book = item.Book;
            BookName = item.Book.Name;
            BookAuthor = item.Book.Author;
            IdUser = item.User.Email;
            Time = item.Time;
            DateTime = item.DateTime;
            User = item.User;
        }
        public override string ToString()
        {
            return $"Книга {BookName} - {BookAuthor} \nвзята {DateTime} на {Time} дней";
        }
    }
}
