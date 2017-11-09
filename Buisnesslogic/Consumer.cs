using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buisnesslogic
{
    class Consumer
    {
        private ConcurrentQueue<BufferBlock> _dataQueue;

        public Consumer(ConcurrentQueue<BufferBlock> dataQeue)
        {
            _dataQueue = dataQeue;
        }

        public void Run()
        {
            while (true)
            {
                BufferBlock _buffer;

                while (!_dataQueue.TryDequeue(out _buffer))
                {
                    Thread.Sleep(0);
                }


            }
        }
    }
}
