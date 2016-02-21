using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCAPI.JSON;

namespace LendingClub.Models
{
    /// <summary>
    /// Details of a loan currently listed on the Lending Club platform.
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// A unique LC assigned ID for the loan listing.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A unique LC assigned Id for the borrower member.
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// The Number of payments on the loan. Values are in months and can be either 36 or 60.
        /// </summary>
        public int Term { get; set; }

        /// <summary>
        /// Interest Rate on the loan.
        /// </summary>
        [DeserializeAs("intRate")]
        public decimal InterestRate { get; set; }

        /// <summary>
        /// The expected default rate of the loan.
        /// </summary>
        [DeserializeAs("expDefaultRate")]
        public decimal ExpectedDefaultRate { get; set; }

        /// <summary>
        /// Service fee rate paid by the investor for this loan.
        /// </summary>
        public decimal ServiceFeeRate { get; set; }

        /// <summary>
        /// The monthly payment owed by the borrower if the loan originates.
        /// </summary>
        public decimal Installment { get; set; }

        /// <summary>
        /// LC assigned loan grade
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// LC assigned loan subgrade
        /// </summary>
        public string Subgrade { get; set; }

        /// <summary>
        /// Employment length in months. Possible values are whole numbers from 0 and higher. Null indicates not employed.
        /// </summary>
        [DeserializeAs("empLength")]
        public int EmploymentLength { get; set; }
    }
}
