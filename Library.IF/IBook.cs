using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public enum Genre
    {
        Adventure, Apocalyptic, Autobiography, Biography, Classics, Drama,
        Fantasy, Fiction, Folklore, Gothic, History, Horror, Humor, 
        Mystery, Mythology, Nonfiction, 
        Novels, Paranormal, Philosophy, Poetry,
        Psychology, RealisticFiction,
        Romance, ScienceFiction, ScienceFictionFantasy, ShortStories, SocialScience,
        Thriller, Writing, YoungAdult
    }
    public interface IBook
    {
        string Name { get; set; }
        string Author { get; set; }
        Genre Genre { get; set; }
        bool isTaken { get; set; }
        List<(int, string, string)> Reviews { get; set; }
        string ReviewsJson { get; set; }
    }
}
