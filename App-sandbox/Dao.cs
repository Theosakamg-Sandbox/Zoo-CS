using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    public class Dao<T>
    {
        public T Get(int id)
        {
            return default(T);
        }

        public List<T> GetAll()
        {
            return null;
        }

        public void Create(T obj)
        {
            
        }

        public void Update(T obj)
        {
            
        }

        public void Delete(T obj)
        {
            
        }
    }
}
