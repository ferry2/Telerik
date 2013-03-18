using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Interface used for classes that deposit money.
    /// </summary>
    public interface IDepositable
    {
        /// <summary>
        /// Method that implement deposit of money.
        /// </summary>
        /// <param name="amount">The amount for deposit</param>
        void Deposite(decimal amount);        
    }
}
