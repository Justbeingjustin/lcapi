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
        [DeserializeAs("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// LC assigned loan subgrade
        /// </summary>
        [DeserializeAs("subGrade")]
        public string Subgrade { get; set; }

        /// <summary>
        /// Employment length in months. Possible values are whole numbers from 0 and higher. Null indicates not employed.
        /// </summary>
        [DeserializeAs("empLength")]
        public int? EmploymentLength { get; set; }

        /// <summary>
        /// The home ownership status provided by the borrower during registration.
        /// </summary>
        /// <remarks>
        /// Values are: RENT, OWN, MORTGAGE, OTHER
        /// </remarks>
        [DeserializeAs("homeOwnership")]
        public HomeOwnership HomeOwnership { get; set; }

        /// <summary>
        /// The annual income provided by the borrower during registration.
        /// </summary>
        [DeserializeAs("annualInc")]
        public decimal? AnnualIncome { get; set; }

        /// <summary>
        /// Indicates if income is verified by LC
        /// </summary>
        /// <remarks>
        /// Values are: REQUESTED, NOT_VERIFIED, SOURCE_VERIFIED and VERIFIED.
        /// </remarks>
        [DeserializeAs("isIncV")]
        public IncomeVerification IsIncomeVerified { get; set; }

        /// <summary>
        /// The date which the borrower accepted the offer
        /// </summary>
        [DeserializeAs("acceptD")]
        public DateTime AcceptDate { get; set; }

        /// <summary>
        /// The date the listing will expire
        /// </summary>
        [DeserializeAs("expD")]
        public DateTime ExpireDate { get; set; }

        /// <summary>
        /// The date which the borrower's application was listed on the platform.
        /// </summary>
        [DeserializeAs("listD")]
        public DateTime ListDate { get; set; }

        /// <summary>
        /// The date LC pulled credit for this loan
        /// </summary>
        [DeserializeAs("creditPullD")]
        public DateTime CreditPullDate { get; set; }

        /// <summary>
        /// The date the loan application was reviewed by LC
        /// </summary>
        [DeserializeAs("reviewStatusD")]
        public DateTime? ReviewDate { get; set; }

        /// <summary>
        /// The status of the loan during the listing period.
        /// </summary>
        /// <remarks>
        /// Values: APPROVED, NOT_APPROVED.
        /// </remarks>
        public ReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// Loan description provided by the borrower
        /// </summary>
        [DeserializeAs("desc")]
        public string Description { get; set; }

        /// <summary>
        /// A category provided by the borrower for the loan request.
        /// </summary>
        /// <remarks>
        /// Values are: debt_consolidation, medical, home_improvement, renewable_energy, small_business, wedding, vacation, moving, house, car, major_purchase, credit_card, other
        /// </remarks>
        [DeserializeAs("purpose")]
        public LoanPurpose Purpose { get; set; }

        /// <summary>
        /// The first 3 numbers of the ZIP code provided by the borrower in the loan application.
        /// </summary>
        [DeserializeAs("addrZip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// The address state provided by the borrower during loan application
        /// </summary>
        [DeserializeAs("addrState")]
        public string AddressState { get; set; }

        /// <summary>
        /// The number of investor members who have purchased notes from this loan
        /// </summary>
        public int? InvestorCount { get; set; }

        /// <summary>
        /// The date and time when the loan will no longer be in the initial listing status. After this date is past, the initialListStatus below will not have any effect and the loan will be treated as a FRACTIONAL loan.
        /// </summary>
        [DeserializeAs("ilsExpD")]
        public DateTime? InitialListingExpireDate { get; set; }

        /// <summary>
        /// The initial listing status of the loan. Possible values are W, F.
        /// </summary>
        [DeserializeAs("initialListStatus")]
        public string InitialListingStatus { get; set; }

        /// <summary>
        /// Employment title
        /// </summary>
        [DeserializeAs("empTitle")]
        public string EmploymentTitle { get; set; }

        /// <summary>
        /// The Number of accounts on which the borrower is now delinquent.
        /// </summary>
        [DeserializeAs("accNowDelinq")]
        public int? AccountsNowDelinquent { get; set; } //nullable: Yes

        /// <summary>
        /// Number of trades opened in past 24 months.
        /// </summary>
        [DeserializeAs("accOpenPast24Mths")]
        public int? AccountsOpenedInPast24Months { get; set; } //nullable: Yes

        /// <summary>
        /// Total open to buy on revolving bankcards.
        /// </summary>
        [DeserializeAs("bcOpenToBuy")]
        public int? BankcardOpenToBuy { get; set; } //nullable: Yes

        /// <summary>
        /// Percentage of all bankcard accounts > 75% of limit.
        /// </summary>
        [DeserializeAs("percentBcGt75")]
        public decimal? PercentBankcardOver75 { get; set; } //nullable: Yes

        /// <summary>
        /// Ratio of total current balance to high credit/credit limit for all bankcard accounts.
        /// </summary>
        [DeserializeAs("bcUtil")]
        public decimal? BankcardUtilization { get; set; } //nullable: Yes

        /// <summary>
        /// "The borrower's debt to income ratio, calculated using the monthly payments on the total debt obligations, excluding mortgage, divided by self-reported monthly income."
        /// </summary>
        [DeserializeAs("dti")]
        public decimal? DebtToIncome { get; set; } //nullable: Yes

        /// <summary>
        /// The Number of 30+ days past-due incidences of delinquency in the borrower's credit file for the past 2 years.
        /// </summary>
        [DeserializeAs("delinq2Yrs")]
        public int? DelinquenciesPast2Years { get; set; } //nullable: Yes

        /// <summary>
        /// The past-due amount owed for the accounts on which the borrower is now delinquent.
        /// </summary>
        [DeserializeAs("delinqAmnt")]
        public decimal? DelinquentAmount { get; set; } //nullable: Yes

        /// <summary>
        /// The date the borrower's earliest reported credit line was opened
        /// </summary>
        [DeserializeAs("earliestCrLine")]
        public DateTime? EarliestCreditLineDate { get; set; } //nullable: Yes

        /// <summary>
        /// The lower boundary of range the borrower's FICO belongs to.
        /// </summary>
        [DeserializeAs("ficoRangeLow")]
        public int? FicoRangeLow { get; set; } //nullable: Yes

        /// <summary>
        /// The upper boundary of range the borrower's FICO belongs to.
        /// </summary>
        [DeserializeAs("ficoRangeHigh")]
        public int? FicoRangeHigh { get; set; } //nullable: Yes

        /// <summary>
        /// The Number of inquiries by creditors during the past 6 months.
        /// </summary>
        [DeserializeAs("inqLast6Mths")]
        public int? InquiriesPast6Months { get; set; } //nullable: Yes

        /// <summary>
        /// The Number of months since the borrower's last delinquency.
        /// </summary>
        [DeserializeAs("mthsSinceLastDelinq")]
        public int? MonthsSinceLastDelinquency { get; set; } //nullable: Yes

        /// <summary>
        /// The Number of months since the last public record.
        /// </summary>
        [DeserializeAs("mthsSinceLastRecord")]
        public int? MonthsSinceLastPublicRecord { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent inquiry.
        /// </summary>
        [DeserializeAs("mthsSinceRecentInq")]
        public int? MonthsSinceMostRecentInquiry { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent revolving delinquency.
        /// </summary>
        [DeserializeAs("mthsSinceRecentRevolDelinq")]
        public int? MonthsSinceMostRecentRevolvingDelinquency { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent bankcard account opened.
        /// </summary>
        [DeserializeAs("mthsSinceRecentBc")]
        public int? MonthsSinceRecentBankcard { get; set; } //nullable: Yes

        /// <summary>
        /// Number of mortgage accounts.
        /// </summary>
        [DeserializeAs("mortAcc")]
        public int? MortgageAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// The Number of open credit lines in the borrower's credit file.
        /// </summary>
        [DeserializeAs("openAcc")]
        public int? OpenAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Number of derogatory public records.
        /// </summary>
        [DeserializeAs("pubRec")]
        public int? PublicRecords { get; set; } //nullable: Yes

        /// <summary>
        /// Total credit balance excluding mortgage.
        /// </summary>
        [DeserializeAs("totalBalExMort")]
        public int? TotalBalanceExcludingMortgage { get; set; } //nullable: Yes

        /// <summary>
        /// Total credit revolving balance.
        /// </summary>
        [DeserializeAs("revolBal")]
        public decimal? RevolvingBalance { get; set; } //nullable: Yes

        /// <summary>
        /// Revolving line utilization rate, or the amount of credit the borrower is using relative to all available revolving credit.
        /// </summary>
        [DeserializeAs("revolUtil")]
        public decimal? RevolvingUtilization { get; set; } //nullable: Yes

        /// <summary>
        /// Total bankcard high credit/credit limit.
        /// </summary>
        [DeserializeAs("totalBcLimit")]
        public int? TotalBankcardLimit { get; set; } //nullable: Yes

        /// <summary>
        /// The total Number of credit lines currently in the borrower's credit file
        /// </summary>
        [DeserializeAs("totalAcc")]
        public int? TotalAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Total installment high credit/credit limit
        /// </summary>
        [DeserializeAs("totalIlHighCreditLimit")]
        public int? TotalInstallmentHighCreditLimit { get; set; } //nullable: Yes

        /// <summary>
        /// Number of revolving accounts
        /// </summary>
        [DeserializeAs("numRevAccts")]
        public int? RevolvingAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent bankcard delinquency.
        /// </summary>
        [DeserializeAs("mthsSinceRecentBcDlq")]
        public int? MonthsSinceRecentBankcardDelinquency { get; set; } //nullable: Yes

        /// <summary>
        /// Number of public record bankruptcies.
        /// </summary>
        [DeserializeAs("pubRecBankruptcies")]
        public int? PublicRecordBankruptcies { get; set; } //nullable: Yes

        /// <summary>
        /// Number of accounts ever 120 or more days past due.
        /// </summary>
        [DeserializeAs("numAcctsEver120Ppd")]
        public int? AccountsEver120DaysPastDue { get; set; } //nullable: Yes

        /// <summary>
        /// Number of charge-offs within 12 months.
        /// </summary>
        [DeserializeAs("chargeoffWithin12Mths")]
        public int? ChargeOffsPast12Months { get; set; } //nullable: Yes

        /// <summary>
        /// Number of collections in 12 months excluding medical collections.
        /// </summary>
        [DeserializeAs("collections12MthsExMed")]
        public int? CollectionsPast12MonthsExcludingMedical { get; set; } //nullable: Yes

        /// <summary>
        /// Number of tax liens
        /// </summary>
        [DeserializeAs("taxLiens")]
        public int? TaxLiens { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent 90-day or worse rating.
        /// </summary>
        [DeserializeAs("mthsSinceLastMajorDerog")]
        public int? MonthsSinceLastMajorDerogatory { get; set; } //nullable: Yes

        /// <summary>
        /// Number of satisfactory accounts
        /// </summary>
        [DeserializeAs("numSats")]
        public int? SatisfactoryAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Number of accounts opened in past 12 months
        /// </summary>
        [DeserializeAs("numTlOpPast12m")]
        public int? AccountsOpenedPast12Months { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent account opened
        /// </summary>
        [DeserializeAs("moSinRcntTl")]
        public int? MonthsSinceMostRecentAccount { get; set; } //nullable: Yes

        /// <summary>
        /// Total high credit/credit limit
        /// </summary>
        [DeserializeAs("totHiCredLim")]
        public int? TotalHighCreditLimit { get; set; } //nullable: Yes

        /// <summary>
        /// Total current balance of all accounts
        /// </summary>
        [DeserializeAs("totCurBal")]
        public int? TotalCurrentBalance { get; set; } //nullable: Yes

        /// <summary>
        /// Average current balance of all accounts
        /// </summary>
        [DeserializeAs("avgCurBal")]
        public int? AverageCurrentBalance { get; set; } //nullable: Yes

        /// <summary>
        /// Number of bankcard accounts
        /// </summary>
        [DeserializeAs("numBcTl")]
        public int? BankcardAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Number of currently active bankcard accounts
        /// </summary>
        [DeserializeAs("numActvBcTl")]
        public int? BankcardAccountsActive { get; set; } //nullable: Yes

        /// <summary>
        /// Number of satisfactory bankcard accounts
        /// </summary>
        [DeserializeAs("numBcSats")]
        public int? BankcardAccountsSatisfactory { get; set; } //nullable: Yes

        /// <summary>
        /// Percent of trades never delinquent
        /// </summary>
        [DeserializeAs("pctTlNvrDlq")]
        public int? PercentageTradesNeverDelinquent { get; set; } //nullable: Yes

        /// <summary>
        /// Number of accounts 90 or more days past due in last 24 months
        /// </summary>
        [DeserializeAs("numTl90gDpd24m")]
        public int? Accounts90PastDuePast24Months { get; set; } //nullable: Yes

        /// <summary>
        /// Number of accounts currently 30 days past due (updated in past 2 months)
        /// </summary>
        [DeserializeAs("numTl30dpd")]
        public int? Accounts30PastDue { get; set; } //nullable: Yes

        /// <summary>
        /// Number of accounts currently 120 days past due (updated in past 2 months)
        /// </summary>
        [DeserializeAs("numTl120dpd2m")]
        public int? Accounts120PastDue { get; set; } //nullable: Yes

        /// <summary>
        /// Number of installment accounts
        /// </summary>
        [DeserializeAs("numIlTl")]
        public int? InstallmentAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Months since oldest installment account opened
        /// </summary>
        [DeserializeAs("moSinOldIlAcct")]
        public int? MonthsSinceOldestInstallmentAccount { get; set; } //nullable: Yes

        /// <summary>
        /// Number of currently active revolving trades
        /// </summary>
        [DeserializeAs("numActvRevTl")]
        public int? RevolvingTradesActive { get; set; } //nullable: Yes

        /// <summary>
        /// Months since oldest revolving account opened
        /// </summary>
        [DeserializeAs("moSinOldRevTlOp")]
        public int? MonthsSinceOldestRevolvingAccount { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent revolving account opened
        /// </summary>
        [DeserializeAs("moSinRcntRevTlOp")]
        public int? MonthsSinceRecentRevolvingAccount { get; set; } //nullable: Yes

        /// <summary>
        /// Total revolving high credit/credit limit
        /// </summary>
        [DeserializeAs("totalRevHiLim")]
        public int? RevolvingHighCreditLimit { get; set; } //nullable: Yes

        /// <summary>
        /// Number of revolving trades with balance > 0
        /// </summary>
        [DeserializeAs("numRevTlBalGt0")]
        public int? RevolvingTradesWithBalance { get; set; } //nullable: Yes

        /// <summary>
        /// Number of open revolving accounts
        /// </summary>
        [DeserializeAs("numOpRevTl")]
        public int? RevolvingAccountsOpen { get; set; } //nullable: Yes

        /// <summary>
        /// Total collection amounts ever owed
        /// </summary>
        [DeserializeAs("totCollAmt")]
        public int? CollectionAmountEverOwed { get; set; } //nullable: Yes

        /// <summary>
        /// The total amount funded by investors for that loan at that point in time.
        /// </summary>
        [DeserializeAs("fundedAmount")]
        public decimal FundedAmount { get; set; } //nullable: No

        /// <summary>
        /// The listed amount of the loan applied for by the borrower.
        /// If at some point in time, the credit department reduces the loan amount,
        /// then it will be reflected in this value.
        /// </summary>
        [DeserializeAs("loanAmount")]
        public decimal LoanAmount { get; set; } //nullable: No

        /// <summary>
        /// It will indicate whether loan application is Individual or Joint.
        /// </summary>
        /// <remarks>
        /// Valid values are "INDIVIDUAL" or "JOINT"
        /// </remarks>
        [DeserializeAs("applicationType")]
        public ApplicationType ApplicationType { get; set; } //nullable: Yes

        /// <summary>
        /// The joint annual income if the applicationType is "Joint".
        /// </summary>
        [DeserializeAs("annualIncJoint")]
        public decimal? AnnualIncomeJoint { get; set; } //nullable: Yes

        /// <summary>
        /// The joint debt to joint income ratio. This field is populated if the applicationType is "Joint".
        /// Calculated using the monthly payments on the total debt obligations, excluding mortgage, divided by self-reported monthly income.
        /// </summary>
        [DeserializeAs("dtiJoint")]
        public decimal? DebtToIncomeJoint { get; set; } //nullable: Yes

        /// <summary>
        /// Indicates if joint income is verified by LC.
        /// </summary>
        /// <remarks>
        /// Valid values are NOT_VERIFIED, SOURCE_VERIFIED and VERIFIED.
        /// </remarks>
        [DeserializeAs("isIncVJoint")]
        public IncomeVerification IsIncomeVerifiedJoint { get; set; } //nullable: Yes

        /// <summary>
        /// Number of open trades in last 6 months.
        /// </summary>
        [DeserializeAs("openAcc6m")]
        public int? AccountsOpenPast6Months { get; set; } //nullable: Yes

        /// <summary>
        /// Number of currently active installment trades.
        /// </summary>
        [DeserializeAs("openIl6m")]
        public int? InstallmentAccountsActive { get; set; } //nullable: Yes

        /// <summary>
        /// Number of installment accounts opened in past 12 months.
        /// </summary>
        [DeserializeAs("openIl12m")]
        public int? InstallmentAccountsOpenedPast12Months { get; set; } //nullable: Yes

        /// <summary>
        /// Number of installment accounts opened in past 24 months.
        /// </summary>
        [DeserializeAs("openIl24m")]
        public int? InstallmentAccountsOpenedPast24Months { get; set; } //nullable: Yes

        /// <summary>
        /// Months since most recent installment accounts opened.
        /// </summary>
        [DeserializeAs("mthsSinceRcntIl")]
        public int? MonthsSinceRecentInstallmentAccount { get; set; } //nullable: Yes

        /// <summary>
        /// Total current balance of all installment accounts.
        /// </summary>
        [DeserializeAs("totalBalIl")]
        public decimal? InstallmentBalance { get; set; } //nullable: Yes

        /// <summary>
        /// Ratio of total current balance to high credit/credit limit on all install acct.
        /// </summary>
        [DeserializeAs("iLUtil")]
        public decimal? InstallmentUtilization { get; set; } //nullable: Yes

        /// <summary>
        /// Number of revolving trades opened in past 12 months.
        /// </summary>
        [DeserializeAs("openRv12m")]
        public int? RevolvingAccountsOpenedPast12Months { get; set; } //nullable: Yes

        /// <summary>
        /// Number of revolving trades opened in past 24 months.
        /// </summary>
        [DeserializeAs("openRv24m")]
        public int? RevolvingAccountsOpenedPast24Months { get; set; } //nullable: Yes

        /// <summary>
        /// Maximum current balance owed on all revolving accounts.
        /// </summary>
        [DeserializeAs("maxBalBc")]
        public decimal? RevolvingMaximumBalanceOwed { get; set; } //nullable: Yes

        /// <summary>
        /// Balance to credit limit on all trades.
        /// </summary>
        [DeserializeAs("allUtil")]
        public decimal? Utilization { get; set; } //nullable: Yes

        /// <summary>
        /// Number of personal finance inquiries.
        /// </summary>
        [DeserializeAs("inqFi")]
        public int? FinanceInquiries { get; set; } //nullable: Yes

        /// <summary>
        /// Number of credit union trades.
        /// </summary>
        [DeserializeAs("totalCuTl")]
        public int? CreditUnionAccounts { get; set; } //nullable: Yes

        /// <summary>
        /// Number of credit inquiries in past 12 months.
        /// </summary>
        [DeserializeAs("inqLast12m")]
        public int? InquiriesPast12Months { get; set; } //nullable: Yes

    }
}
