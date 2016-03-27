using System;
using LCAPI.JSON;

namespace LendingClub.Models
{
    /// <summary>
    ///     Details of a note owned by the investor
    /// </summary>
    public class Note
    {
        /// <summary>
        ///     Loan Status
        /// </summary>
        public string LoanStatus { get; set; }

        /// <summary>
        ///     A unique LC assigned ID for the loan listing.
        /// </summary>
        public long LoanId { get; set; }

        /// <summary>
        ///     A unique LC assigned ID for this note.
        /// </summary>
        public long NoteId { get; set; }

        /// <summary>
        ///     LC assigned loan grade
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        ///     The listed amount of the loan applied for by the borrower.
        /// </summary>
        public decimal LoanAmount { get; set; }

        /// <summary>
        ///     The amount invested in this note.
        /// </summary>
        public decimal NoteAmount { get; set; }

        /// <summary>
        ///     Interest rate on the loan.
        /// </summary>
        public decimal InterestRate { get; set; }

        /// <summary>
        ///     Order Id
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        ///     The number of payments on the loan. Values are in months and can be either 36 or 60.
        /// </summary>
        [DeserializeAs("loanLength")]
        public int Term { get; set; }

        /// <summary>
        ///     Issue Date
        /// </summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>
        ///     Order Date
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        ///     Loan Status Date
        /// </summary>
        public DateTime? LoanStatusDate { get; set; }

        /// <summary>
        ///     Payments received to date
        /// </summary>
        public decimal PaymentsReceived { get; set; }
    }
}
