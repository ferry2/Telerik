using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProgram
{
    public class Battery
    {
        public enum Type
        {
            LiIon,
            NiMH,
            NiCd
        }
        
        private int? hoursIdle;
        private int? hoursTalk;
        private Type currentBattery;

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than zero");
                }
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than zero");
                }

                this.hoursTalk = value;
            }
        }

        public Type CurrentBattery
        {
            get
            {
                return this.currentBattery;
            }
            set
            {
                this.currentBattery = value;
            }
        }

        public Battery() : this(null,null,Battery.Type.LiIon)
        {
        }

        public Battery(int? hoursIdle) : this(hoursIdle, null, Battery.Type.LiIon)
        {
        }

        public Battery(int? hoursIdle, int? hoursTalk) : this(hoursIdle, hoursTalk, Battery.Type.LiIon)
        {
        }

        public Battery(int? hoursIdle, int? hoursTalk, Type currentBattery)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.CurrentBattery = currentBattery;
        }
    }
}