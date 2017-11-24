using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class QueueExtensions
    {
        public static IEnumerable<T> DequeueMultipleElements<T>(this Queue<T> queue, int size)
        {
            for (int i = 0; i < size; i++)
            {
                yield return queue.Dequeue();
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
