using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public interface IDataCheck<T>
    {
        IEnumerable<T> ReadAll(IUser item);
        void Add(T item);
        void Remove(T item);
        ICheck Find(IBook book);
    }
}
