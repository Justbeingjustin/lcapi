// ReSharper disable InconsistentNaming
namespace LendingClub.Models
{
    public enum LoanStatus
    {
        None = 0,
        Issued,
        InReview,
        FullyPaid,
        Current,
        InGracePeriod,
        Late_16_30_Days,
        Late_31_120_Days,
        Default,
        ChargedOff
    }
}
