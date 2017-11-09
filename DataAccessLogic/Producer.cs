using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DataAccessLogic
{
    class Producer
    {
        private IData _data;
        private ConcurrentQueue<BufferBlock> _dataQueue;

        public Producer(ConcurrentQueue<BufferBlock> dataQueue)
        {
            _dataQueue = dataQueue;
            _data = new Data();
        }

        public void Run()
        {
            while(true)
            {
                BufferBlock _buffer = new BufferBlock();
                _buffer.Data = _data.getData();
                _dataQueue.Enqueue(_buffer);
                Thread.Sleep(1000);
            }
        }

        
}
