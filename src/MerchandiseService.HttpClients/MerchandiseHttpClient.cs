using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.HttpModels;

namespace MerchandiseService.HttpClients
{
    public interface IMerchandiseHttpClient
    {
        Task<ItemResponse> GetEmployeeMerchInfoAsync(int employeeId, CancellationToken token);

        Task<int> GetMerchAsync(int employeeId, int merchType, CancellationToken token);

    }
    
    public class MerchandiseHttpClient : IMerchandiseHttpClient
    {
        private readonly HttpClient _httpClient;

        public MerchandiseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ItemResponse> GetEmployeeMerchInfoAsync(int employeeId, CancellationToken token)
        {
            return await ResponeHandler<ItemResponse>($"v1/api/merchs/{employeeId}", token);
        }
        
        public async Task<int> GetMerchAsync(int employeeId, int merchType, CancellationToken token)
        {
            return await ResponeHandler<int>($"v1/api/merchs/{employeeId}/{merchType}", token);
        }

        private async Task<T> ResponeHandler<T>(string endpoint, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync(endpoint, token);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync(token);
                return JsonSerializer.Deserialize<T>(body);
            }
            throw new HttpRequestException($"Status Code:{response.StatusCode.ToString()}" +
                                           $" ResponsePhrase: {response.ReasonPhrase}" +
                                           $" Request: {response.RequestMessage}");
        }
    }
}