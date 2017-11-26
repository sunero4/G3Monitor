using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public static class QueueExtensions
    {
        public static void DequeueMultipleElements<T>(this Queue<T> queue, int size)
        {
            for (int i = 0; i < size; i++)
            {
                queue.Dequeue();
            }
        }

        public static void EnqueueMultipleElements<T>(this Queue<T> queue, IEnumerable<T> values)
        {
            foreach (T t in values)
            {
                queue.Enqueue(t);
            }
        }

    }
}
