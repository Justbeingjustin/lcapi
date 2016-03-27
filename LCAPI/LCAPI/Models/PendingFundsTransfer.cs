using System;

namespace LendingClub.Models
{
    public class PendingFundsTransfer
    {
        /// <summary>
        ///     Transfer transaction ID
        /// </summary>
        public int TransferId { get; set; }

        /// <summary>
        ///     Scheduled transfer date
        /// </summary>
        /// <remarks>Not meant to be nullable, but returns null for this on LOAD_NOW transactions</remarks>
        public DateTime? TransferDate { get; set; }

        /// <summary>
        ///     Transfer amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        ///     Transfer source account
        /// </summary>
        public string SourceAccount { get; set; }

        /// <summary>
        ///     Status of scheduled transfer
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     Frequency of fund transfer
        /// </summary>
        /// <remarks>Not meant to be nullable, but returns null for this on LOAD_NOW transactions</remarks>
        public TransferFrequency? Frequency { get; set; }

        /// <summary>
        ///     Recurring transfer end date or null in case of one-time transfers
        /// </summary>
        /// <remarks>Not meant to be nullable, but returns null for this on LOAD_NOW transactions</remarks>
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Type of transfer
        /// </summary>
        public TransferType Operation { get; set; }

        /// <summary>
        ///     Whether this transaction can be cancelled
        /// </summary>
        public bool Cancellable { get; set; }
    }
}
