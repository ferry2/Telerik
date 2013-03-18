using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Interface used of classes that withdraw money.
    /// </summary>
    public interface IWithDraw
    {
        /// <summary>
        /// Method that implement withdraw of money.
        /// </summary>
        /// <param name="withDrawAmount">The withdraw amount.</param>
        void WithDraw(decimal withDrawAmount);
    }
}
