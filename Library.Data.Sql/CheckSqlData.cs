using Library.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Sql
{
    public class CheckSqlData : IDataCheck<ICheck>
    {
        public void Add(ICheck item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                var check = new CheckEntity(item);
                db.Checks.Add(check);
                db.SaveChanges();
            }
        }

        public IEnumerable<ICheck> ReadAll(IUser user)
        {
            using (LibraryContext db = new LibraryContext())
            {
                List<CheckEntity> _checks = new List<CheckEntity>();
                foreach (CheckEntity check in db.Checks.ToList())
                {
                    if (check.IdUser == user.Email)
                    {
                        _checks.Add(check);
                    }
                }
                return _checks;
            }
        }

        public void Remove(ICheck item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                var check = db.Checks.SingleOrDefault(
                    x => x.BookName.Equals(item.BookName) &&
                    x.IdUser.Equals(item.IdUser));
                db.Checks.Remove(check);
                db.SaveChanges();
            }
        }
        public ICheck Find(IBook book)
        {
            using (LibraryContext db = new LibraryContext())
            {
                return db.Checks.SingleOrDefault(x => x.Book == book);
            }
        }
    }
}
