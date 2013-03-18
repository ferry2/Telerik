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
            set 
            {   
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Моля въведете модел телефон!");
                }
                this.model = value;                
            }
        }

        private string manufacturer = null;
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Моля въведете производител!");
                }                
                this.manufacturer = value; 
            }
        }

        private decimal price = 0.00m;
        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Моля въведете валидна цена!");
                } 
                this.price = value; 
            }
        }

        private string owner = null;
        public string Owner
        {
            get { return this.owner; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Моля въведете име на собственик!");
                } 
                this.owner = value; 
            }
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

        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", 969, "Владислав Николов Найденов", 
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

        public override string ToString()
        {
            return string.Format("Модел: {0} \nПроизводител: {1} \nЦена: {2} лв. \nСобственик: {3} \n\nИнформация за батерията: \nМодел: {4} \nРежим готовност: {5} ч. \nРежим на разговор: {6} ч. \n\nИнформация за дисплея: \nРазмер: {7} инча \nЦветове: {8}",
                this.Model, this.Manufacturer, this.Price, this.Owner, this.BatteryInfo.Model, this.BatteryInfo.HoursIdle,
                this.BatteryInfo.HoursTalk, this.DisplayInfo.Size, this.DisplayInfo.NumberOfColors);            
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
            double total = 0;

            if (price > 0)
            {
                for (int i = 0; i < CallHistory.Count; i++)
                {
                    total += (callHistory[i].Duration / 60) * price;                    
                }
            }

            return total;
        }
    }
}
