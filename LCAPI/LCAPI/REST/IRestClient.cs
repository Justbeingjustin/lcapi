using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LCAPI.REST
{
    public interface IRestClient
    {
        HttpRequestHeaders RequestHeaders { get; }
        Task<string> GetAsync(string url);
        Task<T> GetAsync<T>(string url);
        Task<string> PostAsync(string url, HttpContent content);
        Task<T> PostAsync<T>(string url, HttpContent content);
    }
}