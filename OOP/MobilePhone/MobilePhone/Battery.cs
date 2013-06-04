using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum BatteryType 
    { 
        LiPo, LiIon, NiMH, NiCd
    }

    public class Battery
    {
        private string model = null;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private double hoursIdle = 0;
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        private double hoursTalk = 0;
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
                
        public Battery()
        {            
        }

        public Battery(string _model, double _hoursIdle, double _hoursTalk)
        {
            this.model = _model;
            this.hoursIdle = _hoursIdle;
            this.hoursTalk = _hoursTalk;
        }

        public Battery(string _model, double _hoursIdle, double _hoursTalk, BatteryType _batteryType)
        {
            this.model = _model;
            this.hoursIdle = _hoursIdle;
            this.hoursTalk = _hoursTalk;
            _batteryType = new BatteryType();
        }
    }
}
