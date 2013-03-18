using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Model a company. Inherits from <see cref="Customer" /> class.
    /// </summary>
    public class Company : Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class and sets the name of the company.
        /// </summary>
        /// <param name="name">Name of the company.</param>
        public Company(string name) : base(name)
        {            
        }
    }
}
