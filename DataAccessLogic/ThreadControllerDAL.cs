using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    class ThreadControllerDAL
    {
        private Thread _producerThread;
        private Producer _producer;

        public ThreadControllerDAL(Producer producer)
        {
            _producer = producer;
        }
        public void CreateThread()
        {
            _producer.State = true;
            _producerThread = new Thread(_producer.Run);
            _producerThread.IsBackground = true;
            _producerThread.Start();
        }


        public void StopThread()
        {
            _producer.State = false;
        }
    }
}
