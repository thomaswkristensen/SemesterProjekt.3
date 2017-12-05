using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;


namespace DataAccessLogic
{
    public class Producer
    {
        private IData _data;
        private ConcurrentQueue<BufferBlock> _dataQueue;
        public bool State { get; set; }

        public Producer(ConcurrentQueue<BufferBlock> dataQueue)
        {
            _dataQueue = dataQueue;
            _data = new Data();
            State = false;
        }

        public void Run()
        {
            while (State)
            {
                BufferBlock _buffer = new BufferBlock();
                _buffer.Data = _data.getData();
                _dataQueue.Enqueue(_buffer);

                

            }
        }

    }
}
