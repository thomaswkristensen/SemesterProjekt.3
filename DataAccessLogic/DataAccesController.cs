using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void SetZPA(double ZPA)
        {
            _limits.ZPA = ZPA;
        }
    }
}
