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
        private Calibration _calibration;

        public BusinessController(IDataAccesLogic DAL)
        {
            _DAL = DAL;
        }

        public void StartZPA(List<double> dataList)
        {
            _DAL.SetZPA(_ZPA.CalculateZPA(dataList));
        }

        public void StartCalibration(List<double> data, int value)
        {
            if (value == 10)
            {
               _calibration.CalculateP1(data); 
            }
            else if (value == 50)
            {
                _calibration.CalculateP2(data);
            }
            else if (value == 100)
            {
                _calibration.CalculateP3(data);
            }
        }

    }
}
