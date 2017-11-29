using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;

namespace Buisnesslogic
{
    class ThreadControllerBL
    {
        private Thread _consumerThread;
        private Consumer _consumer;

        public ThreadControllerBL(Consumer consumer)
        {
            _consumer = consumer;
        }
        public void CreateThread()
        {
            _consumer.State = true;
            _consumerThread = new Thread(_consumer.Run);
            _consumerThread.IsBackground = true;
            _consumerThread.Start();
        }

        public void StartThread()
        {
            _consumer.State = true;
            _consumerThread.Start();
        }

        public void StopThread()
        {
            _consumer.State = false;
        }

        
    }
}
