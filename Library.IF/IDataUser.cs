using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public interface IDataUser<T>
    { 
        void Registration(T item);
        bool Login(T item);
        //void Take(ICheck check);
        //void Return (ICheck check);
        T GetUser(T item);
    }
}
