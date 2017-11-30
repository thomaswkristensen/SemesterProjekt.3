﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic;
using Buisnesslogic;
using PresentationLogic;
using Interfaces;
using DTO;
using ObserverPattern;

namespace Main
{
    class Program
    {
        private DataAccesController DAC;
        private PresentationController PC;
        private BusinessController BC;
        private ConcurrentQueue<BufferBlock> _queue;
        private Consumer _consumer;
        private Producer _producer;
        private FilterContainer _filterContainer;
        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            _queue = new ConcurrentQueue<BufferBlock>();
            _consumer = new Consumer(_queue);
            _producer = new Producer(_queue);
            
            DAC = new DataAccesController(_producer);
            BC = new BusinessController(DAC, _consumer, _filterContainer);
            PC = new PresentationController(BC, _filterContainer);
            
            PC.Start();
        }
    }
}
