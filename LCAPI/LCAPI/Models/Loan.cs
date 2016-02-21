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
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int Term { get; set; }

        [DeserializeAs("intRate")]
        public decimal InterestRate { get; set; }
    }
}
