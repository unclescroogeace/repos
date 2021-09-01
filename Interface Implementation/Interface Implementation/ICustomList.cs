using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implementation
{
    public interface ICustomList<T>
    {
        public int Count { get; }
        public void Add(T item);

        /// <summary>
        /// Removes the first occurrence of an item in the list.
        /// </summary>
        /// <param name="item">The item to remove</param>
        /// <returns>false if the item was not found true otherwise</returns>
        bool Remove(T item);
        void Insert(int index, T item);
        T this[int index] { get; set; }
    }
}
