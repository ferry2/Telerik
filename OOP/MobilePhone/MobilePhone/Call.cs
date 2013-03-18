using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Call
    {
        private string date;
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        private string time;
        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        private int duration;
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }        

        public Call()
        {            
        }

        public Call(string _date, string _time, string _phoneNumber, int _duration)
        {
            this.date = _date;
            this.time = _time;
            this.phoneNumber = _phoneNumber;
            this.duration = _duration;            
        }        
    }
}
