using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using Library.Bll;
using Library.IF;
using Library.Data.Memory;
using Library.Data.Sql;

namespace Library.Settings
{
    public class Configuration
    {
        public Container Container { get; }

        public Configuration()
        {
            Container = new Container();

            Setup();
        }

        public virtual void Setup()
        {
            Container.Register<IBook, Book>(Lifestyle.Transient);
            Container.Register<ICheck, Check>(Lifestyle.Transient);
            Container.Register<IUser, User>(Lifestyle.Transient);
            Container.Register<ILibrary, Bll.Library>(Lifestyle.Singleton);
            Container.Register<IDataBook<IBook>, BookSqlData>
                (Lifestyle.Singleton);
            Container.Register<IDataCheck<ICheck>, CheckSqlData>
                (Lifestyle.Singleton);
            Container.Register<IDataUser<IUser>, UserSqlData>
                (Lifestyle.Singleton);
        }

    }
}
