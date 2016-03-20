using System;

namespace LendingClub.Models
{
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
