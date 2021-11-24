using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface ICommonInterface<T>
    {
        T Add();
        T Delete();
        T Get();
    }
}
