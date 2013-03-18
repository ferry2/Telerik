using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProgram
{
    public class Call
    {
        private DateTime dateAndTime;
        private string dialedPhone;
        public int? duration;

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            set
            {
                this.dialedPhone = value;
            }
        }

        public int? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than zero");
                }

                this.duration = value;
            }
        }

        public Call(DateTime dateAndTime, string dialedPhone, int? duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder allData = new StringBuilder();

            if (this.DialedPhone != null || this.Duration != null)
            {
                allData.AppendFormat("The call is made at {0},\nthe phone dialed is {1}\nand lasted for {2} seconds.\n", this.DateAndTime, this.DialedPhone,this.Duration);
            }
            else
            {
                allData.Append("No records found!");
            }

            return allData.ToString();
        }
    }
}