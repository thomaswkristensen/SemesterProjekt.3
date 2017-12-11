using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class LimitValues
    {
        private Alarm_DTO _alarmDTO;
        public LimitValues()
        {
            PulsUpper = 100;
            PulsLower = 50;
            DiaUpper = 110;
            DiaLower = 50;
            SysUpper = 180;
            SysLower = 100;
            _alarmDTO = new Alarm_DTO();
        }
        public double ZPAVolt { get; set; }
        public int PulsUpper { get; set; }
        public int PulsLower { get; set; }
        public int DiaUpper { get; set; }
        public int DiaLower { get; set; }
        public int SysUpper { get; set; }
        public int SysLower { get; set; }

        public void SetAlarmLimits(Alarm_DTO alarmDTO)
        {
            SysUpper = alarmDTO.SysUpper;
            SysLower = alarmDTO.SysLower;
            DiaUpper = alarmDTO.DiaUpper;
            DiaLower = alarmDTO.DiaLower;
            PulsUpper = alarmDTO.PulsUpper;
            PulsLower = alarmDTO.PulsLower;
        }

        public Alarm_DTO GetAlarmLimits()
        {
            _alarmDTO.SysUpper = SysUpper;
            _alarmDTO.SysLower = SysLower;
            _alarmDTO.PulsUpper = PulsUpper;
            _alarmDTO.PulsLower = PulsLower;
            _alarmDTO.DiaUpper = DiaUpper;
            _alarmDTO.DiaLower = DiaLower;

            return _alarmDTO;
        }


    }
}
