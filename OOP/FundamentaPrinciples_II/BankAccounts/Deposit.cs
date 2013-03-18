using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Class that model bank deposit account. Derived from <see cref="Account" /> class.
    /// </summary>
    public class Deposit : Account, IDepositable, IWithDraw
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deposit" /> class and sets values for customer, balance and interest rate.
        /// </summary>
        /// <param name="customer">The holder of the deposit account.</param>
        /// <param name="balance">The balance of the deposit account.</param>
        /// <param name="interestRate">The interest rate of the deposit account.</param>
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {            
        }

        /// <summary>
        /// Method that calculate balance after deposit is made.
        /// </summary>
        /// <param name="amount">The deposited amount.</param>
        public void Deposite(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount for deposit must be positive number greater than 0. ");
            }
            else
            {
                this.Balance += amount;
            }
        }

        /// <summary>
        /// Method that calculate balance after withdraw is made.
        /// </summary>
        /// <param name="withDrawAmount">The withdraw ammount.</param>
        public void WithDraw(decimal withDrawAmount)
        {
            if (withDrawAmount <= 0)
            {
                throw new ArgumentException("The withdrawal amount must be positive number greater than 0. ");
            }
            else
            {
                this.Balance -= withDrawAmount;
            }
        }

        /// <summary>
        /// Overridden method calculate the interest rate for a given period in months for deposit account.
        /// </summary>
        /// <param name="months">The given period in months.</param>
        /// <returns>The interest.</returns>
        public override decimal CalculateInterest(decimal months)
        {
            if (this.Balance >= 1000)
            {                
                return months * this.InterestRate * this.Balance;
            }  
            else
            {
                return 0;
            }
        }        
    }
}
