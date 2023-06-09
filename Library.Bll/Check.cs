﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.IF;

namespace Library.Bll
{
    public class Check : ICheck
    {
        public IBook Book { get; set; }
        public ILibrary Library { get; set; }
        public int Time { get; set; }
        public IUser User { get; set; }
        public DateTime DateTime { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string IdUser { get; set; }
        public override string ToString()
        {
            return $"Книга {Book} \nвзята {DateTime} на {Time} дней";
        }
    }
}
