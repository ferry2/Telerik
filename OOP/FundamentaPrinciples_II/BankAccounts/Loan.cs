using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Model a loan type of account. Derived from <see cref="Account" /> class.
    /// </summary>
    public class Loan : Account, IWithDraw
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loan" /> class and sets values for customer, balance and interest rate.
        /// </summary>
        /// <param name="customer">The holder of the account.</param>
        /// <param name="balance">The balance of the account.</param>
        /// <param name="interestRate">The interest rate of the account.</param>
        public Loan(Customer customer, decimal balance, decimal interestRate)
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
        /// Overridden method that calculates the interest for a given period in months for loan type of account.
        /// </summary>
        /// <param name="months">The given period in months</param>
        /// <returns>The interest for given period in months.</returns>
        public override decimal CalculateInterest(decimal months)
        {
            if ((this.Customer is Individual) && months > 3)
            {
                return (months - 3) * this.InterestRate * this.Balance;
            }
            else if ((this.Customer is Company) && months > 2)
            {
                return (months - 2) * this.InterestRate * this.Balance;
            }                        
            else
            {
                return 0;
            }
        }
    }
}
