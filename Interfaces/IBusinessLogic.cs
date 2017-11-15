using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface IBusinessLogic
    {
        void ZeroAdjust(List<double> dataList);
        Patient_DTO getSSN(string SSN);
        void StartZPA(List<double> dataList);
        void StartCalibration(List<double> data, int value);
        Calibration_DTO ViewCalibration();
        Calibration_DTO ChangeSlope(double slope);
    }
}
