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
        public double ZPA
        {
            get { return _limits.ZPA; }
            set { _limits.ZPA = value; }
        }

        public void SetCalibration(Calibration_DTO calibration)
        {
            _limits.P1 = calibration.P1;
            _limits.P2 = calibration.P2;
            _limits.P3 = calibration.P3;
            _limits.Slope = calibration.Slope;
        }

        public Calibration_DTO GetCalibration()
        {
            Calibration_DTO calibration = new Calibration_DTO();

            calibration.P1 = _limits.P1;
            calibration.P2 = _limits.P2;
            calibration.P3 = _limits.P3;
            calibration.Slope = _limits.Slope;

            return calibration;
        }






    }
}
