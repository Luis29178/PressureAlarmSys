using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PressureAlarmSys;

namespace MYOTests
{
    class MYOSensor : ISensor
    {
         public double pressure;
        public double QueryHardwareForPsiValue()
        {
            
            return pressure;
        }
    }
}
