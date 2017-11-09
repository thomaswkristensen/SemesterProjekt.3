using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Buisnesslogic
{
    public class BusinessController : IBusinessLogic
    {
        private IDataAccesLogic _DAL;

        public BusinessController(IDataAccesLogic DAL)
        {
            _DAL = DAL;
        }

    }
}
