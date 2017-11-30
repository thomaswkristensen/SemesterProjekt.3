using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ObserverPattern
{
    public class FilterContainer : FilterSubject
    {
        private Queue<double> _queue;

        public FilterContainer()
        {
            _queue = new Queue<double>();
            Fill(_queue);
        }

        private void Fill(Queue<double> queue)
        {
            for (int i = 0; i < 500; i++)
            {
                queue.Enqueue(0);
            }
        }

        public void SetSlidingWindow(List<double> list)
        {
            if (_queue.Count >= 1000)
            {
                _queue.DequeueElements(list.Count);
            }
            _queue.EnqueueElements(list);

            Notify();
        }

        public List<double> GetSlidingWindow()
        {
            return _queue.ToList();
        }
    }
}
