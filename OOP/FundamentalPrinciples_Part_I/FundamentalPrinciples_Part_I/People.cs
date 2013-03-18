using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrinciples_Part_I
{
    public class People
    {
        protected string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public People()
        {            
        }

        public People(string _name)
        {
            this.name = _name;
        }
    }
}
