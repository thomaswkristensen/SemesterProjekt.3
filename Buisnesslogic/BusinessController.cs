using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

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

        public Patient_DTO getSSN(string SSN)
        {
            Patient_DTO patient;
            patient = _DAL.verifySSN(SSN);
            return patient;
        }
    }
}
