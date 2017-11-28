using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace Buisnesslogic
{
    class ShowData
    {
        private IDataAccesLogic _DAL;
        private ConcurrentQueue<BufferBlock> _queue;
        private Consumer _consumer;
        public ShowData(IDataAccesLogic DAL)
        {
            _DAL = DAL;
            _queue = new ConcurrentQueue<BufferBlock>();
            _consumer = new Consumer(_queue);
            _DAL.CreateProducer(_queue);

        }

        public void HandleData()
        {
            Thread producerThread = new Thread(_DAL.RunProducer);
            Thread consumeThread = new Thread(_consumer.Run);

            producerThread.Start();
            consumeThread.Start();

        }
    }
}
