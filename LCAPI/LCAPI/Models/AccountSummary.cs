using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingClub.Models
{
    /// <summary>
    /// Summary of the investor's account.
    /// </summary>
    public class AccountSummary
    {
        /// <summary>
        /// Available cash amount
        /// </summary>
        public decimal AvailableCash { get; set; }

        /// <summary>
        /// Investor ID
        /// </summary>
        public int InvestorId { get; set; }

        /// <summary>
        /// Accrued interest amount
        /// </summary>
        public decimal AccruedInterest { get; set; }

        /// <summary>
        /// Outstanding principal amount
        /// </summary>
        public decimal OutstandingPrincipal { get; set; }

        /// <summary>
        /// Account total
        /// </summary>
        public decimal AccountTotal { get; set; }

        /// <summary>
        /// Total notes
        /// </summary>
        public int TotalNotes { get; set; }

        /// <summary>
        /// Total portfolios
        /// </summary>
        public int TotalPortfolios { get; set; }

        /// <summary>
        /// In-Funding balance
        /// </summary>
        public decimal InFundingBalance { get; set; }

        /// <summary>
        /// Received interest
        /// </summary>
        public decimal ReceivedInterest { get; set; }

        /// <summary>
        /// Received principal
        /// </summary>
        public decimal ReceivedPrincipal { get; set; }

        /// <summary>
        /// Received late fees
        /// </summary>
        public decimal ReceivedLateFees { get; set; }
    }
}
