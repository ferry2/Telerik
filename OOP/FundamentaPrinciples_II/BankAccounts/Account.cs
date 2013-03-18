using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Abstract class that model bank account.
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Hold information about the customer.
        /// </summary>
        private Customer customer;

        /// <summary>
        /// Hold the balance of the customer's account.
        /// </summary>
        private decimal balance;

        /// <summary>
        /// Hold the interest rate of the account.
        /// </summary>
        private decimal interestRate;      

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class and sets values for customer, balance and interest rate.
        /// </summary>
        /// <param name="customer">The holder of the account.</param>
        /// <param name="balance">The balance of the account.</param>
        /// <param name="interestRate">The interest rate of the account.</param>
        public Account(Customer customer, decimal balance, decimal interestRate)           
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        /// <summary>
        /// Gets or sets Customer property.
        /// </summary>
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        /// <summary>
        /// Gets or sets Balance property.
        /// </summary>
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        /// <summary>
        /// Gets or sets InterestRate property.
        /// </summary>
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }        

        /// <summary>
        /// Virtual method that calculate the interest for a given period in months.
        /// </summary>
        /// <param name="months">The given period in months.</param>
        /// <returns>The interest for a given period.</returns>
        public virtual decimal CalculateInterest(decimal months)
        {
            return months * this.interestRate * this.balance;
        }        
    }
}
