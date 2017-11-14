using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    public class DataAccesController : IDataAccesLogic
    {
        private LimitValues _limits;

        public DataAccesController()
        {
            _limits = new LimitValues();
        }

        public double ZPAVolt
        {
            get => _limits.ZPAVolt;
            set => _limits.ZPAVolt = value; 
        }

       






    }
}
