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
        double ZPAVolt { get; set; }
        HP_DTO getLoginDatabase(string medarbejderID);

        Patient_DTO verifySSN(string ssn);

        bool SaveMeasurementDataAcces();
    }
}
