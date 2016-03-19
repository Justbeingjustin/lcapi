using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LCAPI.REST
{
    public interface IRestClient
    {
        HttpRequestHeaders RequestHeaders { get; }
        Task<string> GetAsync(string url);
        Task<T> GetAsync<T>(string url);
    }
}