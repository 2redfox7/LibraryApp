﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Library.IF;

namespace Library.Bll
{
    public class Library : ILibrary
    {
        private readonly IDataBook<IBook> _bookData;
        private readonly IDataCheck<ICheck> _checkData;
        private readonly IDataUser<IUser> _userData;
        public string Address { get; set; }
        public Library(IDataBook<IBook> bookData, IDataCheck<ICheck> checkData, IDataUser<IUser> userData)
        {
            _bookData = bookData ??
                throw new ArgumentNullException(nameof(bookData));
            _checkData = checkData ??
                throw new ArgumentNullException(nameof(checkData));
            _userData = userData ??
                throw new ArgumentNullException(nameof(userData));
        }
        public void AddBook(IBook book)
        {
            _bookData.Add(book);
        }
        public IBook GetBook(string name, string author)
        {
            return _bookData.FindBook(name, author);
        }

        public IEnumerable<IBook> FindBooksAuthor(string author)
        {
            return _bookData.FindAuthor(author);
        }

        public IEnumerable<IBook> FindBooksGenre(Genre genre)
        {
            return _bookData.FindGenre(genre);
        }

        public IEnumerable<IBook> GetAllBooks()
        {
            return _bookData.ReadAll();
        }
        public IEnumerable<ICheck> GetChecks(IUser user)
        {
            return _checkData.ReadAll(user);
        }

        public void ReturnBook(ICheck check)
        {
            _bookData.Return(check);
            _checkData.Remove(check);
        }

        public void TakeBook(ICheck check)
        {
            _bookData.Take(check.Book);
            _checkData.Add(check);
        }
        public bool Login(IUser user)
        {
            return _userData.Login(user);
        }
        public IUser GetUser(IUser user)
        {
            return _userData.GetUser(user);
        }
        public void Registration(IUser user)
        {
            _userData.Registration(user);
        }
        public void AddReview((int, string, string) review, string name, string author)
        {
            _bookData.AddReview(review, name, author);
        }
        public override string ToString()
        {
            return $"Добро пожаловать в библиотеку {Address}";
        }
    }
}
