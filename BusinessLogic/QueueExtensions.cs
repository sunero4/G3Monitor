using System.Collections.Generic;

namespace BusinessLogic
{
    public static class QueueExtensions
    {
        /// <summary>
        /// Extension method for dequeueing multiple elements
        /// </summary>
        /// <typeparam name="T">Generic type to allow extensibility</typeparam>
        /// <param name="queue">'this' parameter to make it an extension method for the Queue type</param>
        /// <param name="size">Amount of elements to dequeue</param>
        public static void DequeueMultipleElements<T>(this Queue<T> queue, int size)
        {
            for (int i = 0; i < size; i++)
            {
                queue.Dequeue();
            }
        }

        /// <summary>
        /// Extension method for enqueueing multiple elements
        /// </summary>
        /// <typeparam name="T">Generic type to allow extensibility</typeparam>
        /// <param name="queue">'this' parameter to make it an extension method for the Queue type</param>
        /// <param name="values">Values to enqueue</param>
        public static void EnqueueMultipleElements<T>(this Queue<T> queue, IEnumerable<T> values)
        {
            foreach (T t in values)
            {
                queue.Enqueue(t);
            }
        }

    }
}
