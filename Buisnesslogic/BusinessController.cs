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
        private Zero_pointAdjusment _ZPA;

        public BusinessController(IDataAccesLogic DAL)
        {
            _DAL = DAL;
        }

        public void ZeroAdjust(List<double> dataList)
        {
            _DAL.SetZPA(_ZPA.Calculate(dataList));
        }

    }
}
