using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureAlarmSys
{
    public class PressureAlarm
    {
        private const double lowPressureThreshold = 15;
        private const double highPressureThreshold = 32;
        ISensor Isensor = null;
        bool alarm = false;

        public PressureAlarm(ISensor sensor)
        {
            Isensor = sensor;
        }

        public void Check()
        {
            double pressure = Isensor.QueryHardwareForPsiValue();
            if (pressure < lowPressureThreshold || highPressureThreshold < pressure)
            {
                alarm = true;
            }
        }

        public bool Alarm
        {
            get { return alarm; }
        }
    }
}
