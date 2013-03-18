using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Class that model individual type of customer. Derived from <see cref="Customer" /> class.
    /// </summary>
    public class Individual: Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Individual" /> class and sets a name for the customer.
        /// </summary>
        /// <param name="name"></param>
        public Individual(string name) : base(name)
        {            
        }
    }
}
