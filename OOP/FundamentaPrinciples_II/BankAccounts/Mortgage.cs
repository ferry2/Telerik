using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Model a mortgage type of account. Derived from <see cref="Account" /> class.
    /// </summary>
    public class Mortgage : Account, IWithDraw
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mortgage" /> class and sets values for customer, balance and interest rate.
        /// </summary>
        /// <param name="customer">The holder of the account.</param>
        /// <param name="balance">The balance of the account.</param>
        /// <param name="interestRate">The interest rate of the account.</param>
        public Mortgage(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {            
        }

        /// <summary>
        /// Method that calculate balance after withdraw.
        /// </summary>
        /// <param name="withDrawAmount">The withdraw amount.</param>
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
        /// Overridden method that calculates the interest for a given period in months for mortgage type of account.
        /// </summary>
        /// <param name="months">The given period in months</param>
        /// <returns>The interest for given period in months.</returns>
        public override decimal CalculateInterest(decimal months)
        {
            if ((this.Customer is Individual) && months <= 6)
            {
                return 0;
            }
            else if((this.Customer is Company) && months <= 12)
            {
                return (months * this.InterestRate * this.Balance) / 2;
            }
            else
            {
                return months * this.InterestRate * this.Balance;
            }
        }
    }
}
