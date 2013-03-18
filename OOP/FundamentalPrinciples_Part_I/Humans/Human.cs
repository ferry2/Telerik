using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public abstract class Human
    {
        private string fisrtName;
        public string FirstName
        {
            get { return this.fisrtName; }
            set { this.fisrtName = value; }
        }

        protected string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Human()
        {            
        }
        
        public Human(string _firstName, string _lastName)
        {
            this.fisrtName = _firstName;
            this.lastName = _lastName;
        }
    }
}
