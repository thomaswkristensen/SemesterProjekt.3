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
        private IData _data;
        private Alarm_DTO _alarmDTO;
        public DataAccesController(Producer producer)
        {
            _limits = new LimitValues();
            _pullData = new PullData();
            _alarmDTO = new Alarm_DTO();
            _saveData = new SaveData();
            _data  = new Data();
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
            _alarmDTO = alarmDTO;
            _limits.SysUpper = _alarmDTO.SysUpper;
            _limits.SysLower = _alarmDTO.SysLower;
            _limits.DiaUpper = _alarmDTO.DiaUpper;
            _limits.DiaLower = _alarmDTO.DiaLower;
            _limits.PulsUpper = _alarmDTO.PulsUpper;
            _limits.PulsLower = _alarmDTO.PulsLower;
        }

        public Alarm_DTO GetAlarmLimitsDataAcces()
        {
            _alarmDTO.SysUpper = _limits.SysUpper;
            _alarmDTO.SysLower = _limits.SysLower;
            _alarmDTO.PulsUpper = _limits.PulsUpper;
            _alarmDTO.PulsLower = _limits.PulsLower;
            _alarmDTO.DiaUpper = _limits.DiaUpper;
            _alarmDTO.DiaLower = _limits.DiaLower;

            return _alarmDTO;
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

        public void StopMeasuringDAL()
        {
            _threadController.StopThread();
        }

        public List<double> PullData()
        {
            return _data.getData();
        }

      
    }
}
