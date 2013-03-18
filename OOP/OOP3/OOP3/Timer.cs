using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP3
{
    /// <summary>
    /// Delegate Tick()
    /// </summary>
    public delegate void TickDelegate();

    public class Timer
    {
        private int ticks;
        public int Ticks
        {
            get { return this.ticks; }
            set { this.ticks = value; }
        }

        private int interval;
        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        /// <summary>
        /// Property of type delegate.
        /// </summary>
        public TickDelegate OnTimerTick { get; set; }

        public event TimerEventHandler RaiseTimer;
        
        public Timer(int _interval, int _ticks)
        {
            this.interval = _interval;
            this.ticks = _ticks;
        }

        private Thread _timerThread;
        private volatile bool _tStop;

        public void Run()
        {
            int _ticks = this.Ticks;
            while(_ticks > 0)
            {
                Thread.Sleep(this.Interval);
                _ticks--;
                OnRaiseTimer(_ticks);
            }
        }

        public Thread Start()
        {
            _tStop = false;
            _timerThread = new Thread(new ThreadStart(Run));
            _timerThread.IsBackground = true;
            _timerThread.Start();

            return _timerThread;
        }

        public void Stop()
        {
            _tStop = true;
            _timerThread.Join(1000);
            _timerThread.Abort();
        }

        protected void OnRaiseTimer(int _ticks)
        {
            TimerEventHandler handler = RaiseTimer;

            if (handler != null)
            {
                TimerEventArgs e = new TimerEventArgs(_ticks);
                handler(this, e);
            }
        }
    }
}
