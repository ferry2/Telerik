using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProgram
{
    public class GSM
    {
        private string model;
        private string manifacturer;
        private int? price;
        private string owner;
        private Display display;
        private Battery battery;
        private Call call;
        private List<Call> callHistory = new List<Call>();
        private static GSM AppleIPhone4S = new GSM("IPhone4S","Apple",500,"Don Kihot");

        private int PRICE_PER_MINUTE = 5;

        public GSM(string model, string manifacturer) : this(model, manifacturer, null, null, null, null, null)
        { 
        }

        public GSM(string model, string manifacturer, int price) : this(model, manifacturer, price, null, null, null, null)
        {
        }

        public GSM(string model, string manifacturer, int price, string owner) : this(model, manifacturer, price, owner, null, null, null)
        {
        }

        public GSM(string model, string manifacturer, int price, string owner, Display display, Battery battery) : this(model, manifacturer, price, owner, display, battery, null)
        {
        }

        public GSM(string model, string manifacturer, int? price, string owner, Display display, Battery battery, Call call)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.Call = call;
        }
        
        public List<Call> CallHistory
        {
            get
            {
                if (this.callHistory.Count == 0)
                {
                    Console.WriteLine("No entry found");
                }
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public Call Call
        {
            get
            {
                return this.call;
            }
            set
            {
                this.call = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public int? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            set
            {
                this.manifacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return AppleIPhone4S;
            }
        }

        public void AddCall(Call call) 
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }
        
        public int? TotalPrice()
        {
            int? totalSum = 0;

            foreach (var item in CallHistory)
            {
                totalSum += item.duration * PRICE_PER_MINUTE;
            }
            return totalSum;
        }
        
        public override string ToString()
        {
            StringBuilder allData = new StringBuilder();
            if (this.Owner != null)
            {
                allData.AppendFormat("Owner is {0}\n", this.Owner);
            }

            if (this.Price != null)
            {
                allData.AppendFormat("Price is {0}\n", this.Price);
            }

            if (this.Manifacturer != null)
            {
                allData.AppendFormat("Manifacturer is {0}\n", this.Manifacturer);
            }

            if (this.Model != null)
            {
                allData.AppendFormat("Model is {0}\n", this.Model);
            }

            if (this.battery!=null && this.battery.HoursIdle != null)
            {
                allData.AppendFormat("Hours idled are {0}\n", this.battery.HoursIdle);
            }

            if (this.battery != null && this.battery.HoursTalk != null)
            {
                allData.AppendFormat("Hours talked are {0}\n", this.battery.HoursTalk);
            }

            if (this.battery != null && this.battery.CurrentBattery != null)
            {
                allData.AppendFormat("Battery model is: {0}", this.battery.CurrentBattery);
            }

            return allData.ToString();
        }
    }
}