using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Abstract class that model customer.
    /// </summary>
    public abstract class Customer
    {
        /// <summary>
        /// The name of the customer.
        /// </summary>
        protected string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="CUstomer" /> class and sets the name of the customer.
        /// </summary>
        /// <param name="name">The name of the customer.</param>
        public Customer(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets ot sets the name of the customer.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
