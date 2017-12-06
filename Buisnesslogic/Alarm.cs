using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    class Alarm
    {
        private Alarm_DTO _alarmDTO;
        public bool Tone { get; set; }


        public void Limits(Alarm_DTO alarmDTO)
        {
            _alarmDTO = alarmDTO;
        }


        public bool Check(HealthValues_DTO values)
        {
            if (CheckHeartRate(values) || CheckDia(values) || CheckSys(values))
            {
                AlarmTone();
                return true;
            }
            else
            {
                AlarmToneStop();
                return false;
            }
        }


        public bool CheckHeartRate(HealthValues_DTO values)
        {
            if (_alarmDTO.PulsLower > values.HeartRate || _alarmDTO.PulsUpper < values.HeartRate)
            {
                return true;
            }
            return false;
        }

        public bool CheckSys(HealthValues_DTO values)
        {
            if (_alarmDTO.SysLower > values.SysBP || _alarmDTO.SysUpper < values.SysBP)
            {
                return true;
            }
            return false;
        }

        public bool CheckDia(HealthValues_DTO values)
        {
            if (_alarmDTO.DiaLower > values.DiaBP || _alarmDTO.DiaUpper < values.DiaBP)
            {
                return true;
            }
            return false;
        }

        public void AlarmTone()
        {
            if (Tone)
            {
                
            }
        }

        private void AlarmToneStop()
        {
            
        }


    }
}
