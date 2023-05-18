using Library.IF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Library.Data.Sql
{
    public class BookEntity : IBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public bool isTaken { get; set; }
        [NotMapped]
        public List<(int, string, string)> Reviews { get; set; }
        public string ReviewsJson
        {
            get { return JsonConvert.SerializeObject(this.Reviews); }
            set { this.Reviews = JsonConvert.DeserializeObject<List<(int, string, string)>>(value); }
        }
        public BookEntity() { }

        public BookEntity(IBook item)
        {
            Id = 0;
            Name = item.Name;
            Author = item.Author;
            Genre = item.Genre;
            Reviews = item.Reviews;
        }
        public override string ToString()
        {
            return $"{Name} - {Author}, жанр {Genre}";
        }
    }
}
