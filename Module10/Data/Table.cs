using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Data
{
    public class Table<T> : IEnumerable<T> where T : class
    {
        private readonly List<T> _data;
        public string TableHeader { get; set; }

        public Table(int elementsAmount)
        {
            _data = new List<T>(elementsAmount);
        }
        public Table(IEnumerable<T> initialData)
        {
            _data = new List<T>(initialData);
        }
        public Table()
        {
            _data = new List<T>();
        }
        public void Add(T item)
        {
            _data.Add(item);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(TableHeader);
            stringBuilder.AppendJoin('\n', _data);
            return stringBuilder.ToString();
        }

        public void AddRange(IEnumerable<T> range)
        {
            _data.AddRange(range);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _data.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }
    }
}
