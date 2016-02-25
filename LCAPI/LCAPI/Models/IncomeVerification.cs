using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingClub.Models
{
    public enum IncomeVerification
    {
        //NOT_VERIFIED, SOURCE_VERIFIED and VERIFIED.
        None = 0,
        Requested,
        NotVerified,
        SourceVerified,
        Verified
    }
}
