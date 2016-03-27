using System;

namespace LendingClub.Models
{
    /// <summary>
    ///     Details of a note owned by the investor
    /// </summary>
    public class Note
    {
        public string LoanStatus { get; set; }

        public long LoanId { get; set; }

        public long NoteId { get; set; }

        public string Grade { get; set; }

        public decimal LoanAmount { get; set; }

        public decimal InterestRate { get; set; }

        public long OrderId { get; set; }

        public int LoanLength { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? LoanStatusDate { get; set; }

        public decimal PaymentsReceived { get; set; }
    }
}
