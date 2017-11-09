using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    class Consumer
    {
        private ConcurrentQueue<BufferBlock> _dataQueue;
        private Measurement_DTO _data;

        public Consumer(ConcurrentQueue<BufferBlock> dataQeue)
        {
            _dataQueue = dataQeue;
        }

        public void Run()
        {
            while (true)
            {
                BufferBlock _buffer;
                _data = new Measurement_DTO();

                while (!_dataQueue.TryDequeue(out _buffer))
                {
                    Thread.Sleep(0);
                }

                _data.RawData = _buffer.Data;
            }
        }
    }
}
