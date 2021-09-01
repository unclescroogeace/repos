using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    interface ICustomList<T>
    {
        int Count { get; }
        void Add(T item);
        bool Remove(T item);
        void Insert(int index, T item);
        T this[int index] { get; set; }
    }
}
