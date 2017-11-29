using System;
using System.Collections.Concurrent;
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
        private PullData _pullData;
        private SaveData _saveData;
        private Producer _producer;
        private ThreadControllerDAL _threadController;
        public DataAccesController(Producer producer)
        {
            _limits = new LimitValues();
            _pullData = new PullData();
            _saveData = new SaveData();
            _producer = producer;
            _threadController = new ThreadControllerDAL(_producer);

        }

        public double ZPAVolt
        {
            get => _limits.ZPAVolt;
            set => _limits.ZPAVolt = value; 
        }

        public Patient_DTO verifySSN(string ssn)
        {
            return _pullData.PullPatientInformation(ssn);
        }

        public bool SaveMeasurementDataAcces(Measurement_DTO measurementDTO, string ssn, string employeeID)
        {
            if (_saveData.SaveMeasurement(measurementDTO, ssn, employeeID))
            {
                return true;
            }
            return false;
        }

        public void SetAlarmLimitsDataAccess(Alarm_DTO alarmDTO)
        {
            _limits.SysUpper = alarmDTO.SysUpper;
            _limits.SysLower = alarmDTO.SysLower;
            _limits.DiaUpper = alarmDTO.DiaUpper;
            _limits.DiaLower = alarmDTO.DiaLower;
            _limits.PulsUpper = alarmDTO.PulsUpper;
            _limits.PulsLower = alarmDTO.PulsLower;
        }

        public void RunProducer()
        {
            
            _producer.Run();
        }

        public void CreateProducer(ConcurrentQueue<BufferBlock> queue)
        {
            _producer = new Producer(queue);
        }

        public HP_DTO getLoginDatabase(string username)
        {

            return _pullData.PullHPInformation(username);
        }

        public bool SaveCalibrationDataAcces(Calibration_DTO calibrationData)
        {
            if (_saveData.SaveCalibration(calibrationData))
            {
                return true;
            }
            return false;
        }

        public double PullSlope()
        {
            return _pullData.PullCalibration();
        }

        public void StartMeasuringDAL()
        {
            _threadController.CreateThread();

        }



    }
}
