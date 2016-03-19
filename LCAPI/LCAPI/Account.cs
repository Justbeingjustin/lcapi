using System.Threading.Tasks;
using LendingClub.Models;

namespace LendingClub
{
    public class Account : ApiBase
    {
        public string InvestorId { get; }

        public string Url => $"{BaseUrl}/accounts/{InvestorId}";

        public Account(string apiKey, string investorId) : base(apiKey)
        {
            InvestorId = investorId;
        }

        #region Summary

        protected string SummaryUrl => $"{Url}/summary";

        public Task<AccountSummary> GetSummaryAsync()
        {
            return Client.GetAsync<AccountSummary>(SummaryUrl);
        }

        #endregion

        #region Available Cash

        protected string AvailableCashUrl => $"{Url}/availablecash";

        public Task<AccountAvailableCash> GetAvailableCashAsync()
        {
            return Client.GetAsync<AccountAvailableCash>(AvailableCashUrl);
        }

        #endregion

        #region Transfer Funds

        protected string AddFundsUrl => $"{Url}/funds/add";

        public Task<AccountAvailableCash> AddFundsAsync()
        {
            return Client.GetAsync<AccountAvailableCash>(AddFundsUrl);
        }

        protected string WithdrawFundsUrl => $"{Url}/funds/withdraw";

        public Task<AccountAvailableCash> WithdrawFundsAsync()
        {
            return Client.GetAsync<AccountAvailableCash>(WithdrawFundsUrl);
        }

        #endregion
    }
}
