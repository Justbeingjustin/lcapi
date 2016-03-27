namespace LendingClub.Models
{
    /// <summary>
    ///     Result of a cancel transfer request
    /// </summary>
    public class CancelTransferResult
    {
        /// <summary>
        ///     Transfer transaction ID
        /// </summary>
        public int TransferId { get; set; }

        /// <summary>
        ///     Status of the scheduled transfer
        /// </summary>
        public TransferStatus Status { get; set; }

        /// <summary>
        ///     Error message if the cancel request fails fails
        /// </summary>
        public string Message { get; set; }
    }
}
