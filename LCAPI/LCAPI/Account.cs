using System.Threading.Tasks;
using LCAPI.JSON;
using LCAPI.REST;
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

        protected string SummaryUrl => $"{Url}/summary";

        public Task<AccountSummary> GetSummaryAsync()
        {
            return Client.GetAsync<AccountSummary>(SummaryUrl);
        }
        public AccountSummary GetSummary()
        {
            return GetSummaryAsync().Result;
        }
    }
}
