using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace Interfaces
{
    public interface IDataAccesLogic
    {
        double ZPA { get; set; }
        void SetCalibration(Calibration_DTO calibration);
        Calibration_DTO GetCalibration();


    }
}
