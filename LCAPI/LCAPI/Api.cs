using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LCAPI.JSON;
using LCAPI.REST;

namespace LendingClub
{
    public class Api : ApiBase
    {
        public string Customer { get; }

        public string Url => $"{BaseUrl}/accounts/{Customer}";

        public IDeserializer JsonDeserializer { get; }

        protected RestClient Client { get; }

        private Api()
        {
            JsonDeserializer = JsonDeserializer ?? new JsonDeserializer();
        }

        public Api(string customer, string apiKey) : this()
        {
            Customer = customer;

            Client = new RestClient(JsonDeserializer, apiKey);
        }

        protected string SummaryUrl => $"{Url}/summary";
        public void Summary()
        {
            throw new NotImplementedException();
        }
    }
}
