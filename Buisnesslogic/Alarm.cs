﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    public class Alarm
    {
        private Alarm_DTO _alarmDTO;
        public bool Tone { get; set; }
        private SoundPlayer SP;
        private Thread alarmThread;
        public bool AlarmStop { get; set; }

        public Alarm()
        {
            Tone = false;
            AlarmStop = false;
            SP = new SoundPlayer(@"C:\Users\Thomas\Documents\Skole\3. Semester\Semesterprojekt\Alarm.wav");
            alarmThread = new Thread(this.AlarmTone);


        }

        public void Limits(Alarm_DTO alarmDTO)
        {
            _alarmDTO = alarmDTO;

        }


        public bool Check(HealthValues_DTO values)
        {
            //alarmThread = new Thread(AlarmTone);
            if (!CheckHeartRate(values) && !CheckDia(values) && !CheckSys(values))
            {
                //Tone = false;
                return false;
            }
            else
            {
                //Tone = true;
                //alarmThread.Start();
                if (AlarmStop)
                {
                    return false;
                }
                return true;
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
            while (true)
            {
                SP.PlaySync();
            }
            
        }

       


    }
}
