using System;
using LCAPI.JSON;

namespace LendingClub.Models
{
    /// <summary>
    /// Details of a transaction to add funds
    /// </summary>
    public class AccountAddFunds
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
        ///     Frequency of funds transfer
        /// </summary>
        [DeserializeAs("frequency")]
        public TransferRequestFrequency Frequency { get; set; }

        /// <summary>
        ///     Recurring transfer start date or transfer date for one-time transfers
        /// </summary>
        [DeserializeAs("startD")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///     Recurring transfer end date or null in case of one-time transfers
        /// </summary>
        [DeserializeAs("endD")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Estimated start date of funds transfer
        /// </summary>
        public DateTime EstimatedFundsTransferDate { get; set; }
    }
}
