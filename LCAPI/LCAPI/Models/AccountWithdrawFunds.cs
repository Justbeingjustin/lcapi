using System;

namespace LendingClub.Models
{
    /// <summary>
    /// Details of a transaction to withdraw funds
    /// </summary>
    public class AccountWithdrawFunds
    {
        /// <summary>
        ///     Investor ID
        /// </summary>
        public int InvestorId { get; set; }

        /// <summary>
        ///     Amount of funds
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        ///     Estimated start date of funds transfer
        /// </summary>
        public DateTime EstimatedFundsTransferDate { get; set; }
    }
}
