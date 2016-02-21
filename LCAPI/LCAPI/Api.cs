using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LendingClub
{
    public class Api : ApiBase
    {
        public string Customer { get; }

        protected string ApiKey { get; }

        public string Url => $"{BaseUrl}/accounts/{Customer}";

        public Api(string customer, string apiKey) 
        {
            Customer = customer;
            ApiKey = apiKey;
        }

        protected string SummaryUrl => $"{Url}/summary";
        public void Summary()
        {
            using (var client = new HttpClient())
            {
                
            }
        }
    }
}
