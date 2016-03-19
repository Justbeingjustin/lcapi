using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingClub.Models
{
    /// <summary>
    /// Provides the most up to date value of the cash available in the investor's account.
    /// </summary>
    public class AccountAvailableCash
    {
        /// <summary>
        /// Investor ID
        /// </summary>
        public int InvestorId { get; set; }

        /// <summary>
        /// Available cash amount
        /// </summary>
        public decimal AvailableCash { get; set; }
    }
}
