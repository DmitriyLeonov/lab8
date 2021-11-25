using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Set<T> : ICollection<T> where T:class
    {
        private List<T> _items = new List<T>();
        private string path = @"d:\1.txt";
        public int Count => _items.Count;
        static Random rnd = new Random();

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_items.Contains(item))
            {
                throw new KeyNotFoundException("Элемент не найден");
            }
            _items.Remove(item);
        }

        public void WriteToFile(Set<T> item)
        {
            T[] file = item._items.ToArray();
            File.WriteAllLines(path, (IEnumerable<string>)item._items);
        }

        public List<string> ReadFromFile()
        {
            List<string> list = new List<string>();
            string[] file = File.ReadAllLines(path);
            foreach (string line in file)
            {
                list.Add(line);
            }
            return list;
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            if (set1 == null || set2 == null)
            {
                throw new ArgumentNullException();
            }

            var resultSet = new Set<T>();
            var items = new List<T>();
            if (set1._items != null && set1._items.Count > 0)
            {
                items.AddRange(new List<T>(set1._items));
            }

            if (set2._items != null && set2._items.Count > 0)
            {
                items.AddRange(new List<T>(set2._items));
            }
            resultSet._items = items.Distinct().ToList();
            return resultSet;
        }

        public static Set<T> Intersection(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            var resultSet = new Set<T>();

            if (set1.Count < set2.Count)
            {
                foreach (var item in set1._items)
                {
                    if (set2._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in set2._items)
                {
                    if (set1._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }

            return resultSet;
        }
        public static bool Subset(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            var result = set1._items.All(s => set2._items.Contains(s));
            return result;
        }
    }
}
