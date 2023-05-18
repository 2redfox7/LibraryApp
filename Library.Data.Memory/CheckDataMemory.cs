using Library.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Memory
{
    public class CheckMemoryData : IDataCheck<ICheck>
    {
        private readonly List<ICheck> _checks;

        public CheckMemoryData()
        {
            _checks = new List<ICheck>();
        }

        public void Add(ICheck item)
        {
            _checks.Add(item);
        }

        public IEnumerable<ICheck> ReadAll(IUser user)
        {
            List<ICheck> checks = new List<ICheck>();
            foreach (ICheck check in _checks)
            {
                if (check.User == user)
                {
                    checks.Add(check);
                }
            }
            return checks;
        }

        public void Remove(ICheck item)
        {
            _checks.Remove(item);
        }
        public ICheck Find(IBook book) 
        {
            return _checks.FirstOrDefault(x => x.Book == book);
        }
    }
}
