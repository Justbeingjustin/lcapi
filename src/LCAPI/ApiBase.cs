using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LCAPI.JSON;
using LCAPI.REST;

namespace LendingClub
{
    public abstract class ApiBase
    {
        public static string Version { get; } = "v1";
        public static string BaseUrl { get; } = $"https://api.lendingclub.com/api/investor/{Version}";

        protected IRestClient Client { get; set; } = new RestClient();

        protected ApiBase(string apiKey)
        {
            //validation will fail because we don't specify the scheme
            //http://stackoverflow.com/a/29587268/102351
            Client.RequestHeaders.TryAddWithoutValidation("Authorization", apiKey);
        }
    }
}
