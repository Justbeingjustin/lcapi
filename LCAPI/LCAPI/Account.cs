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

        #region AvailableCash

        protected string AvailableCashUrl => $"{Url}/availablecash";

        public Task<AccountAvailableCash> GetAvailableCashAsync()
        {
            return Client.GetAsync<AccountAvailableCash>(AvailableCashUrl);
        }

        #endregion
    }
}
