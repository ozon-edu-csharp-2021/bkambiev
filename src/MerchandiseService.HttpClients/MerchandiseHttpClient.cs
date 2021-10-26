using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.HttpModels;

namespace MerchandiseService.HttpClients
{
    public interface IMerchandiseHttpClient
    {
        Task<ItemResponse> GetEmployeeMerchInfo(long employeeId, CancellationToken token);

        Task<ItemResponse> GetMerch(long employeeId, long merchType, CancellationToken token);

    }
    
    public class MerchandiseHttpClient : IMerchandiseHttpClient
    {
        private readonly HttpClient _httpClient;

        public MerchandiseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ItemResponse> GetEmployeeMerchInfo(long employeeId, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/merchs/{employeeId}", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<ItemResponse>(body);
        }
        
        public async Task<ItemResponse> GetMerch(long employeeId, long merchType, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/merchs/{employeeId}/{merchType}", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<ItemResponse>(body);
        }
    }
}