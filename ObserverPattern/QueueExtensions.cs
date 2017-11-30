using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public static class QueueExtensions
    {
        public static void DequeueElements(this Queue<double> queue, int length)
        {
            for (int i = 0; i < length; i++)
            {
                queue.Dequeue();
            }
        }

        public static void EnqueueElements(this Queue<double> queue, List<double> list)
        {
            foreach (var item in list)
            {
                queue.Enqueue(item);
            }
        }
    }
}
