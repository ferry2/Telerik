using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        private string model = null;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private string manufacturer = null;
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        private decimal price = 0.00m;
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        private string owner = null;
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        private Battery batteryInfo = null;
        public Battery BatteryInfo
        {
            get { return this.batteryInfo; }
            set { this.batteryInfo = value; }
        }

        private Display displayInfo = null;
        public Display DisplayInfo
        {
            get { return this.displayInfo; }
            set { this.displayInfo = value; }
        }

        private List<Call> callHistory = new List<Call>();
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", 969, "Vladislav Nikolov Naydenov", 
            new Battery("cRU", 200, 8, BatteryType.LiIon), new Display(3.5, 16000000));        
        public static GSM IPhone4S
        {
            get { return iPhone4S; }                      
        } 
       
        public GSM()
        {            
        }
       
        public GSM(string _model, string _manufacturer)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
        } 

        public GSM(string _model, string _manufacturer, decimal _price)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = _price;
        }

        public GSM(string _model, string _manufacturer, decimal _price, string _owner)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = _price;
            this.owner = _owner;
        }

        public GSM(string _model, string _manufacturer, decimal _price, string _owner, Battery _batteryInfo)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = _price;
            this.owner = _owner;
            this.batteryInfo = _batteryInfo;
        }

        public GSM(string _model, string _manufacturer, decimal _price, string _owner, Battery _batteryInfo, Display _displayInfo)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = _price;
            this.owner = _owner;
            this.batteryInfo = _batteryInfo;
            this.displayInfo = _displayInfo;            
        }

        public GSM(string _model, string _manufacturer, decimal _price, string _owner, Battery _batteryInfo, Display _displayInfo, List<Call> _callHistory)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = _price;
            this.owner = _owner;
            this.batteryInfo = _batteryInfo;
            this.displayInfo = _displayInfo;
            this.callHistory = _callHistory;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: {0}", this.Model);
            Console.WriteLine("Manufacturer: {0}", this.Manufacturer);
            Console.WriteLine("Price: {0}", this.Price);
            Console.WriteLine("Owner: {0}", this.Owner);
            Console.WriteLine("Battery information:");
            Console.WriteLine("Model: {0}", this.BatteryInfo.Model);
            Console.WriteLine("Hours idle: {0}", this.BatteryInfo.HoursIdle);
            Console.WriteLine("Hours talk: {0}", this.BatteryInfo.HoursTalk);
            Console.WriteLine("Display information:");
            Console.WriteLine("Display size: {0}", this.DisplayInfo.Size);
            Console.WriteLine("Display colors: {0}", this.DisplayInfo.NumberOfColors);
        }

        public override string ToString()
        {
            return "Model: " + this.Model + "\n" + "Manufacturer: " + this.Manufacturer +
                "\n" + "Price: " + this.Price + "\n" + "Owner: " + this.Owner +
                "\n\n" + "Battery information:\n" + "Model: " + this.BatteryInfo.Model +
                "\n" + "Hours idle: " + this.BatteryInfo.HoursIdle + "\n" +
                "Hours talk: " + this.BatteryInfo.HoursTalk + "\n\n" + "Display information:\n" +
                "Display size: " + this.DisplayInfo.Size + "\n" + "Display colors: " + this.DisplayInfo.NumberOfColors + "\n";
        }

        public List<Call> AddCall(Call call)
        {
            callHistory.Add(call);
            return CallHistory;
        }

        public List<Call> DeleteCall(Call call)
        {
            callHistory.Remove(call);
            return CallHistory;
        }

        public List<Call> ClearCalls()
        {
            callHistory.Clear();
            return CallHistory;
        }

        public double TotalPrice(double price)
        {            
            double secondsToMinutes = 0.0;
            double total = 0;

            if (price > 0)
            {
                for (int i = 0; i < CallHistory.Count; i++)
                {
                    secondsToMinutes += callHistory[i].Duration / 60;
                    total += secondsToMinutes * price;
                }
            }

            return total;
        }
    }
}
