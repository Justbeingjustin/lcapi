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

        protected IDeserializer Deserializer { get; }
        
        protected IRestClient Client { get; }

        protected ApiBase()
        {
            Deserializer = Deserializer ?? new JsonDeserializer();
            Client = Client ?? new RestClient(Deserializer);
        }

        protected ApiBase(string apiKey) : this()
        {
            //validation will fail because we don't specify the scheme
            //http://stackoverflow.com/a/29587268/102351
            Client.RequestHeaders.TryAddWithoutValidation("Authorization", apiKey);
        }
    }
}
