using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public delegate void TimerEventHandler(object sender, TimerEventArgs e);

    public class TimerEventArgs : EventArgs
    {
        private int ticks;
        public int Ticks
        {
            get { return this.ticks; }
        }

        public TimerEventArgs(int _ticks)
        {
            this.ticks = _ticks;
        }
    }
}
