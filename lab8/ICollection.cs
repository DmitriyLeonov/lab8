using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public interface ICollection<T>
    {
        void Add(T t);
        void Delete(T item);
        T Get();
    }
}
