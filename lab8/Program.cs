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
            try
            {
                Set<string> set = new Set<string>();
                set.Add("a");
                set.Add("b");
                set.Add("c");
                set.Add("d");
                set.WriteToFile(set);

                Set<Exam> exams = new Set<Exam>();
                exams.Add(new Exam("Философия",12));
                exams.Add(new Exam("ООП", 21));
                exams.Add(new Exam("Математика", 17));
                exams.WriteToFile(exams);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.Read();
        }
    }

    public interface ICollection<T>
    {
        void Add(T t);
        void Delete(T item);
        T Get();
    }
}
