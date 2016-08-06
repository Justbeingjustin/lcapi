using System.Collections.Generic;

namespace LendingClub.Models
{
    /// <summary>
    ///     Details of a transaction to cancel funds transfers
    /// </summary>
    public class AccountCancelTransfer
    {
        /// <summary>
        ///     Investor ID
        /// </summary>
        public int InvestorId { get; set; }

        /// <summary>
        ///     Results of individual cancellation requests
        /// </summary>
        public List<CancelTransferResult> CancellationResults { get; set; }
    }
}
