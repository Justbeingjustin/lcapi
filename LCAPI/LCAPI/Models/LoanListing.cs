using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCAPI.JSON;

namespace LendingClub.Models
{
    /// <summary>
    /// Details of the loans currently listed on the Lending Club platform.
    /// The list contains the same loans that an investor would see on the browse loans page on the Lending Club website.
    /// </summary>
    public class LoanListing
    {
        public DateTime AsOfDate { get; set; }

        public List<Loan> Loans { get; set; }
    }
}
