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
    public class Consumer
    {
        private ConcurrentQueue<BufferBlock> _dataQueue;
        private Measurement_DTO _data;
        private Converter _converter;
        private BusinessController _BL;
        public bool State { private get; set; }


        public Consumer(ConcurrentQueue<BufferBlock> dataQeue)
        {
            _dataQueue = dataQeue;
            State = false;
            _data = new Measurement_DTO();
            
        }

        public void SetConverter(Converter converter)
        {
            _converter = converter;
        }

        public void Run()
        {
            while (State)
            {
                BufferBlock _buffer;
                
                while (!_dataQueue.TryDequeue(out _buffer))
                {
                    Thread.Sleep(0);
                }

                _data.RawData = _buffer.Data;
                _converter.Convert(_data);
                

            }
        }
    }
}
