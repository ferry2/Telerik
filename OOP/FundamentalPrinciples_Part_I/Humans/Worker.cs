using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Worker : Human
    {
        private decimal weekSalary;
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        private decimal workHoursPerDay;
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker()
        {            
        }

        public Worker(string _firstName, string _lastName)
            : base(_firstName, _lastName)
        {            
        }

        public Worker(string _firstName, string _lastName, decimal _weekSalary)
            : base(_firstName, _lastName)
        {
            this.weekSalary = _weekSalary;
        }

        public Worker(string _firstName, string _lastName, decimal _weekSalary, decimal _workHoursPerDay)
            : base(_firstName, _lastName)
        {
            this.weekSalary = _weekSalary;
            this.workHoursPerDay = _workHoursPerDay;
        }

        public decimal MoneyPerHour(decimal _weekSalary, decimal _workHoursPerDay)
        {
            decimal hourMoney = 0;

            hourMoney = _weekSalary / (_workHoursPerDay * 5);

            return hourMoney;
        }
    }
}
