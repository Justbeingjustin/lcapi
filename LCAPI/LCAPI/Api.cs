using System.Threading.Tasks;
using LCAPI.JSON;
using LCAPI.REST;
using LendingClub.Models;

namespace LendingClub
{
    public class Api : ApiBase
    {
        public string InvestorId { get; }

        public string Url => $"{BaseUrl}/accounts/{InvestorId}";
        
        public Api(string apiKey, string investorId) : base(apiKey)
        {
            InvestorId = investorId;
        }

        protected string SummaryUrl => $"{Url}/summary";

        public Task<Summary> GetSummaryAsync()
        {
            return Client.GetAsync<Summary>(SummaryUrl);
        }
        public Summary GetSummary()
        {
            return GetSummaryAsync().Result;
        }
    }
}
