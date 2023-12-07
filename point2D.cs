using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyCollection<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        // Method to add an item to the collection
        public void Add(T item)
        {
            items.Add(item);
        }

        // Implementation of IEnumerable<T> to support foreach iteration
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        // Explicit implementation of IEnumerable to support foreach iteration
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
