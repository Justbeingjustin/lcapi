using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LCAPI.JSON;

namespace LCAPI.REST
{
    public interface IRestClient
    {
        ISerializer Serializer { get; set; }
        IDeserializer Deserializer { get; set; }
        HttpRequestHeaders RequestHeaders { get; }
        Task<string> GetAsync(string url);
        Task<TResult> GetAsync<TResult>(string url);
        Task<string> PostAsync(string url, HttpContent content);
        Task<TResult> PostAsync<TResult, TRequest>(string url, TRequest content, string mediaType = "application/json");
    }
}