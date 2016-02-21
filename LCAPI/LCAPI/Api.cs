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

        public IDeserializer JsonDeserializer { get; }

        protected RestClient Client { get; }

        private Api()
        {
            JsonDeserializer = JsonDeserializer ?? new JsonDeserializer();
        }

        public Api(string investorId, string apiKey) : this()
        {
            InvestorId = investorId;

            Client = new RestClient(JsonDeserializer, apiKey);
        }

        protected string SummaryUrl => $"{Url}/summary";

        public Task<Summary> GetSummaryAsync()
        {
            return Client.GetAsync<Summary>(SummaryUrl);
        }
    }
}
