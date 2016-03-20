using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LCAPI.JSON;

namespace LCAPI.REST
{
    public class RestClient : IRestClient
    {
        public HttpRequestHeaders RequestHeaders => Client.DefaultRequestHeaders;

        protected HttpClient Client { get; } = new HttpClient();

        public IDeserializer Deserializer { get; set; } = new JsonDeserializer();

        public ISerializer Serializer { get; set; } = new JsonSerializer();

        public async Task<string> GetAsync(string url)
        {
            var response = await Client.GetAsync(url);
            ValidateResponse(response);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var content = await GetAsync(url);
            return Deserializer.Deserialize<T>(content);
        }

        public async Task<string> PostAsync(string url, HttpContent content)
        {
            var response = await Client.PostAsync(url, content);
            ValidateResponse(response);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<TResult> PostAsync<TResult, TRequest>(string url, TRequest content,
            string mediaType = "application/json")
        {
            var serialized = Serializer.Serialize(content);
            var stringContent = new StringContent(serialized, Encoding.UTF8, mediaType);

            var responseContent = await PostAsync(url, stringContent);
            return Deserializer.Deserialize<TResult>(responseContent);
        }

        protected virtual void ValidateResponse(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
        }
    }
}
