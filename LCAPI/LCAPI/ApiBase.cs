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

        public IDeserializer Deserializer { get; }
        
        protected RestClient Client { get; }

        protected ApiBase()
        {
            Deserializer = Deserializer ?? new JsonDeserializer();
        }

        protected ApiBase(string apiKey) : this()
        {
            Client = new RestClient(Deserializer, apiKey);
        }
    }
}
